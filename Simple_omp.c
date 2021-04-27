#include <stdio.h>
#include<omp.h>
#include<time.h>
#include<stdlib.h>
int main ( ){
    int summary=0,i,j,num,res,z,x;
    srand(time(NULL));
    printf("Enter the size of your array:",num);
    scanf("%d",&num);
    int A[num][num];
    for(i=0;i<num;i++){
        for(j=0;j<num;j++){
           // printf ("\n Enter the element  A [%d][%d]=", i ,j);
            A[i][j]=1+rand()% 10;
             }
    }
    for(i=0;i<num;i++){
        for(j=0;j<num;j++){
           // printf ("\n Enter the element  A [%d][%d]=", i ,j);
           printf("A[%d][%d]  =  %d  \n",i,j,A[i][j]);
             }
    }
double start = omp_get_wtime();
omp_set_num_threads(8);
#pragma omp parallel  reduction(+:summary)
    {
  #pragma omp for schedule(dynamic)
        for(int z=0; z< num; z++) {
                       for (int x=0; x< num; x++) {
                           summary+=A[z][x];
                            printf("i = %d, j= %d, threadId = %d ;num_th = %d \n", z,x, omp_get_thread_num(),omp_get_num_threads());
                       }
        }
}
double end = omp_get_wtime();
printf("\n time   = %f  ;",end-start);
printf(" result of sum   = %d  ",summary);
system("pause");
}
