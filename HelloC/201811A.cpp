#include <iostream>
#include <string>
#include <algorithm>

using namespace std;
class MyClass
{
private:
	int x, y;
public:
	MyClass()
	{
		x = 0;
		y = 0;
		cout << "Default Contructorl" << endl;
	}
	MyClass(int a, int b)
	{
		x = a;
		y = b;
	}
	int GetX()
	{
		return x;
	}
	int GetY()
	{
		return y;
	}
	friend int Display(MyClass &mc);
};

int Display(MyClass &mc)
{
	return mc.x*mc.y;
}

class YourClass :public MyClass
{
private:
	int z;
public:
	YourClass(int a)
	{
		z = a;
	}
	void Show()
	{
		cout << z + GetX() + GetY() << endl;
	}
};

//Сдת��
void ToLower()
{
	string str;
	cout << "�����ַ�תСд:" <<endl;
	cin >> str;
	transform(str.begin(), str.end(), str.begin(), ::tolower);
	cout << "ת���ɹ�:" << str << endl;
}

//��дת��
void ToUpper() 
{
	string str;
	cout << "�����ַ�ת��д" << endl;
	cin >> str;
	transform(str.begin(), str.end(), str.begin(), ::toupper);
	cout << "ת���ɹ�:" << str << endl;
}

void main1()
{
	MyClass a(2, 3);
	cout <<"�˻���"<< Display(a) << endl;
	YourClass b(10);
	b.Show();

	ToLower();
	ToUpper();

	getchar();
};







