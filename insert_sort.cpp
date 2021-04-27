#include"stdafx.h"
#include<stdio.h>
#include<iostream>
using namespace std;
 
int main()
{
    int i,j,n,loc,temp,min;
	int A[]={1,2,3,4,6,7,5};
	n=7;
    
     for (int i = 0; i < n; i++) {
        int j = i;

        while (A[j] < A[j - 1]/* && j > 0*/) {
            swap(A[j], A[j - 1]);
            j--;
        }
    }

    cout<<"\nSorted list is as follows\n";
    for(i=0;i<n;i++)
    {
        cout<<A[i]<<" ";
    }
    system("pause");
    return 0;
}
