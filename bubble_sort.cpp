#include"stdafx.h"
#include<iostream>
 
using namespace std;
 
int main()
{
    int n,i,j;
	int array[]={6,5,4,3,2,1,0};
	n=7;
	for(i=0;i<n;i++)
		for(j=6;j>i;j--){
			if(array[j-1]>array[j]){
				swap(array[j-1],array[j]);
			}
		
		}
		cout<<"The numders before sorting:";
		cout<<"6,5,4,3,2,1,0";
		cout<<"\nThe numders after sorting:";
for(i=0;i<n;i++){
		cout<<array[i]<<" ";}
        cout<<"\n\n";        
system("pause");
    return 0;
}
x
