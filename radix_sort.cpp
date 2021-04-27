#include"stdafx.h"
#include "cstdio"
#include "cstring"
#include "iostream"


int r(int, int);
void swap (int *a, int *b)
{
    int c;
    c = *b;
    *b = *a;
    *a = c;
}

void print(int a[], int n)
{
    for(int i =0; i<n; ++i)
    {
        std::cout<<a[i]<< " ";
    }
    std::cout<<'\n'<<'\n';
}

int max(int *mas,  int n)
{
 int xmax;
 xmax = mas[0];
 for (int i = 1 ; i<n; ++i)
    {
        if(mas[i]>xmax)
        {
            xmax = mas[i];
        }
    }
    return xmax;
}


void CountingSort (int *A , int *B, int c, int n)
{
    int *a = new int[n];
    for(int i=0; i<n; i++)
    {
        a[i] = r(A[i],c);
    }
    int k = max(a,n);
    int *C = new int[k+1];
    for (int i = 0; i<k+1; i++)
    {
        C[i] = 0;
    }

    for (int j = 0 ; j<n; ++j)
    {
        C[a[j]]++;
    }
    for (int j = 1; j<k+1; ++j)
    {
        C[j]+=C[j-1];
    }

    for (int j = n-1; j>=0; --j)
    {
        B[C[a[j]]-1] = A[j];
        C[a[j]]--;
    }

    memcpy(A, B, n*sizeof(int));
    delete [] C;
    delete [] a;
}


int power(int x, int n)
{
    int res = 1;
    for (int i = 0; i<n; ++i)
        res*=x;
    return res;
}

int r(int num, int c)
{
    num /= power(10,c);
    return num%10;
}

int main()
{
    const int n = 7;
    int mas [n] =  {720,457,657,839,436,720,355},
    *B,c=0;
    B = new int[n];
    print(mas, n);

    for (int c =0; c<3; c++)
    {
        CountingSort(mas,B,c,n);
        print(mas, n);
    }

    delete [] B;
 system("pause");
	return 0;
}
