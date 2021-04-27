#include <iostream>
#include <fmt/format.h>

using namespace std;

void intersection(bool a[4][4], bool b[4][4])
{
	cout << "intersection \n";
	for (int i = 0;  i < 4; i++) 
	{
		for (int j = 0; j < 4; j++)
		{
			fmt::print("{0} ", (a[i][j] && b[i][j] ? 1:0));
		}
		
		cout << "\n";
	}
	cout << "---------------------------------" << endl;
}

void unionn(bool a[4][4], bool b[4][4])
{
	cout << __func__ << endl;
	for (int i = 0;  i < 4; i++) 
	{
		for (int j = 0; j < 4; j++)
		{
			fmt::print("{0} ", (a[i][j] || b[i][j] ? 1:0));
		}
		
		cout << "\n";
	}
	cout << "---------------------------------" << endl;
}

void diff(bool a[4][4], bool b[4][4])
{
	cout << __func__ << endl;
	for (int i = 0;  i < 4; i++) 
	{
		for (int j = 0; j < 4; j++)
		{
			fmt::print("{0} ", (a[i][j] == 1 && b[i][j] == 1 ? 0 : a[i][j] == 1 ? 1:0));
		}
		
		cout << "\n";
	}
	cout << "---------------------------------" << endl;
}

void sumetricdiff(bool a[4][4], bool b[4][4])
{
	cout << __func__ << endl;
	for (int i = 0;  i < 4; i++) 
	{
		for (int j = 0; j < 4; j++)
		{
//			fmt::print("{0} ", (!(a[i][j] ^ b[i][j]) ? 1:0));
			fmt::print("{0} ", ( (a[i][j] ^ b[i][j]) && (b[i][j] ^ a[i][j]) ? 1:0 ));;
		}
		
		cout << "\n";
	}
	cout << "---------------------------------" << endl;
}

void dopov(bool a[4][4])
{
	cout << __func__ << endl;
	for (int i = 0;  i < 4; i++) 
	{
		for (int j = 0; j < 4; j++)
		{
			fmt::print("{0} ", a[i][j] ? 0:1);
		}
		
		cout << "\n";
	}
	cout << "---------------------------------" << endl;
}

void comp(bool a[4][4], bool b[4][4])
{
	cout << __func__ << endl;
	bool temp;
	for (int i = 0;  i < 4; i++) 
	{
		for (int j = 0; j < 4; j++)
		{
			for (int k = 0; k < 4; k++) 
			{
				temp = temp || (a[i][k] && b[k][j]);
			}
			fmt::print("{0} ", temp ? 1 : 0);
		}
		
		cout << "\n";
	}
	cout << "---------------------------------" << endl;
}

int main(int argc, char *argv[]) {
//	bool p[4][4] = {{1,0,1,1},
//					{1,1,1,1},
//					{0,0,1,0},
//					{1,0,1,1}};
//					
//	bool q[4][4] = {{1,0,0,0},
//					{0,1,0,0},
//					{0,0,1,0},
//					{0,0,0,1}};
					
					
bool p[4][4] = {{1,0,1,0},
				{0,1,1,0},
				{1,0,1,1},
				{0,0,1,1}};
				
bool q[4][4] = {{0,0,1,1},
				{1,1,1,0},
				{0,1,1,1},
				{0,1,1,0}};
	
//	for (int i = 0;  i < 4; i++) 
//	{
//		for (int j = 0; j < 4; j++)
//		{
//			fmt::print("{0} ",p[i][j]);
//		}
//		cout << "\n";
//	}
	
	intersection(p,q);
	unionn(p,q);
	diff(p,q);
	sumetricdiff(p, q);
	dopov(p);
	comp(p,q);
//	fmt::print("{0}", true ? 1:0);
}
