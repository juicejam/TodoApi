#include <iostream>
using namespace std;

class Point
{
private:
	int a, b;
public:
	Point(int x, int y)
	{
		a = 10;
		b = 20;
	}
	Point() {}

	~Point()
	{
		cout << "Destructor!" << endl;
	}
	
	friend void show(Point &p);
};

void show(Point &p)
{
	cout << "The value of a is" << p.a << ",the value of b is" << p.b << endl;
}

class Circle:public Point
{
private:
	int r;
public:
	Circle(int x,int y,int z) {
		Point p(x,y);
		r = z;
	}

	double Area()
	{
		return 3.14 * r * r;
	}
};

void MulDate()
{
	int a[]={ 3,4,5,6,7,8,9,10 };
	int b[] = { 1,2,3,4,5,6,7,8 };
	int aLength = sizeof(a) / sizeof(a[0]);
	int bLength = sizeof(b) / sizeof(b[0]);
	for (int i = 0;i < aLength && i<bLength ;i++)
	{
		b[i] = a[i] * b[i];
		cout << b[i]<<endl;
	}
}


void main22()
{
	//Circle c1(8,5,10);
	//cout << "c1Ãæ»ý£º" << c1.Area() << endl;

	MulDate();

	system("pause");
}