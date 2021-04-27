#include <stdio.h> 
#include <unistd.h> 
#include <mpi.h>
#include <math.h>
#define a 2
#define b 10
#define n 100
long double h = (double)(b-a)/n;
const int MY_TAG = 42; 
long double func(long double x){
return 5+x*x;
}

int main(int argc, char* argv[]) {
int np; 
int rank;
MPI_Init(&argc,&argv ); 
MPI_Comm_size(MPI_COMM_WORLD, &np); 
MPI_Comm_rank(MPI_COMM_WORLD, &rank);
if(rank == 0) {
long double area0 = 0;
long double area1[2];
long double area2 = 0;
for (int i = 0;i < n/2;i++) {
area0 += func(a+i*h);
}
printf("area0 %Lf\n", area0);
MPI_Request recv_req1; 
MPI_Irecv(&area1 , 2 , MPI_LONG_DOUBLE, 1 , MY_TAG, MPI_COMM_WORLD, &recv_req1 ) ;
MPI_Request recv_req2; 
MPI_Irecv(&area1 , 1 , MPI_LONG_DOUBLE, 2 , MY_TAG, MPI_COMM_WORLD, &recv_req2 ) ;
MPI_Wait(&recv_req1, MPI_STATUS_IGNORE);
MPI_Wait(&recv_req2, MPI_STATUS_IGNORE);
area0 += area1[0];
area0 += area2;
printf("%Lf", area0);
}
if(rank == 2){
long double area2 = 0;
for (int i = 0;i < n/3;i++) {
area2+= func((a+(h*n/3)*2)+i*h);
}
area2 *= h;
MPI_Request send_req2; 
MPI_Isend(&area2 , 1 , MPI_LONG_DOUBLE, 0 , MY_TAG, MPI_COMM_WORLD,
&send_req2 ) ;
MPI_Wait(&send_req2, MPI_STATUS_IGNORE);
}
MPI_Finalize() ;
return 0; 
}
