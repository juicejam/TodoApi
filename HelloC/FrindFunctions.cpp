#include <iostream>
using namespace std;
class Box
{
	double width;
public:
	friend void printWidth(Box box);
	friend class BigBox;
	void setWidth(double wid);
};

class BigBox
{
public:
	void Print(int width,Box &box)
	{
		//BigBox是Box的右元类，它可以直接访问Box类的任何成员
		box.setWidth(width);
		cout << "Width of box:" << box.width << endl;
	}
};

//成员函数定义
void Box::setWidth(double wid)
{
	width = wid;
}

//请注意：printWidth()不是任何类的成员函数
void printWidth(Box box)
{
	//因为printWidth()是Box的友元，它可以直接访问该类的任何成员
	cout << "Width of box:" << box.width << endl;
}

//程序的主函数
int main1()
{
	Box box;
	BigBox big;

	//使用友元函数设置宽度
	box.setWidth(10.0);

	//使用友元函数输出宽度
	printWidth(box);

	//使用右元类中的方法设置宽度
	big.Print(20,box);
	getchar();
	return 0;
}




