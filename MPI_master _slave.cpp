#include <mpi.h>
#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#define tagFloatData	1
#define tagLongData  2
#define tagIntData      3
#define maxMessageElems 100
int main( int argc , char **argv )
{
int size,rank,count,i,n,ok ;
float *floatPtr;
int *longPtr;
int *intPtr;
char *typeName ;
MPI_Status status;
MPI_Init(&argc,&argv ) ;
MPI_Comm_size( MPI_COMM_WORLD, &size) ;
MPI_Comm_rank( MPI_COMM_WORLD, &rank ) ;

/*if(size!=3) {
if (rank==0)
printf( " Error : 3 processes  required instead of %d\n" , size) ;
MPI_Barrier( MPI_COMM_WORLD);
MPI_Abort( MPI_COMM_WORLD, MPI_ERR_OTHER );
return -1;
}*/
srand ( ( rank + 1 ) * ( unsigned )time ( 0 ) ) ;
switch(rank) {
case 0 :
count = 1 + rand ( ) % maxMessageElems ;
floatPtr = malloc ( count * sizeof(float));
for( i =0; i<count ; i++)
floatPtr[ i ] = (float)i ;
MPI_Send( floatPtr , count , MPI_FLOAT,
2 , tagFloatData , MPI_COMM_WORLD ) ;
printf( "%d Send %d  float items to process 2\n" ,
rank , count ) ;
break;
case 1:

count = 1 + rand ( ) % maxMessageElems ;
longPtr = malloc ( count * sizeof(long) ) ;
for( i =0; i<count ; i++ )
longPtr [ i ] = i ;

MPI_Send( longPtr , count , MPI_LONG,
2 , tagLongData , MPI_COMM_WORLD ) ;
printf( "%d  Send %d long  items to process  2\n" ,
rank,count);
break ;
case 2 :
for( n=0;n<3;n++){
MPI_Probe(
MPI_ANY_SOURCE, 
MPI_ANY_TAG,
MPI_COMM_WORLD, &status);
if(status.MPI_TAG == tagFloatData )
{
MPI_Get_count( &status , MPI_FLOAT, &count ) ;
floatPtr = malloc ( count*sizeof( float) ) ;
MPI_Recv( floatPtr , count , MPI_FLOAT,
MPI_ANY_SOURCE, MPI_ANY_TAG, MPI_COMM_WORLD,
&status ) ;

for( ok=1, i =0; i<count ; i++ )
if(floatPtr[i]!=(float)i)
ok = 0;
typeName="float";
}
if(status.MPI_TAG == tagIntData )
{
MPI_Get_count( &status , MPI_INT, &count ) ;
intPtr = malloc ( count*sizeof( int) ) ;
MPI_Recv( intPtr , count , MPI_INT,
MPI_ANY_SOURCE, MPI_ANY_TAG, MPI_COMM_WORLD,
&status ) ;

for( ok=1, i =0; i<count ; i++ )
if(intPtr[i]!=(int)i)
ok = 0;
typeName="int";
}
else if( status.MPI_TAG == tagLongData )
{
MPI_Get_count( &status , MPI_LONG, &count ) ;
longPtr = malloc( count * sizeof(long)) ;
MPI_Recv( longPtr , count , MPI_LONG,
MPI_ANY_SOURCE, MPI_ANY_TAG, MPI_COMM_WORLD,
&status ) ;
for ( ok=1, i =0; i<count ; i++ )
if( longPtr[ i ] != i )
ok = 0 ;
typeName = "long" ;
}
printf ( "%d  %d %s items are  received from %d :  %s \n" , rank ,
count , typeName , status .MPI_SOURCE, ok ? "OK" : "FAILED" ) ;
}
break ;
case 3:
count = 1 + rand ( ) % maxMessageElems ;
intPtr = malloc ( count * sizeof(long) ) ;
for( i =0; i<count ; i++ )
intPtr [ i ] = i ;

MPI_Send( intPtr , count , MPI_INT,
2 , tagIntData , MPI_COMM_WORLD ) ;
printf( "%d  Send %d long  items to process  2\n" ,
rank,count);
break ;
}
MPI_Finalize ( ) ;
return 0;
}
