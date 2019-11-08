#include <iostream>
#include <iomanip>
#include <istream>
#include <algorithm>
#include <string>
using namespace std;

int main2(void)
{
	/*int a[6] = {23,15,64,33,40,58};
	int s1, s2;
	s1 = s2 = a[0];
	for (int *p = a + 1;p < a + 6;p++)
	{
		if (s1 > *p)
		{
			s1 = *p;
		}
		if (s2 < *p)
		{
			s2 = *p;
		}
	}
	cout << s1 + s2 << endl;*/

	/*int j, n;
	for (int i = 1;i <= 5;i++) {
		for (j = 1;j < i;j++)
			cout << ' ';
		for (n = 9;n > 2 * i;n--)
			cout << "*";
		cout << endl;
	}*/
	/*int a = 1, b = -2, c = 3;
	if (a < b)
		if (b < 0)c = 0;
		else c += 1;
	cout << c << endl;*/
	
	//大小写转换
	cout << "输入字符串：";
	string str;
	cin >> str;
	transform(str.begin(), str.end(), str.begin(), ::tolower);
	cout << "转化小写:" << str << endl;
	transform(str.begin(), str.end(), str.begin(), ::toupper);
	cout << "转化大写：" << str << endl;




	system("pause");
	return 0;
}





class A
{
public:
	/*A()
	{
		cout << "A" << endl;
	};*/
	void f()
	{
		cout << "FF";
	}
};

 class B
{
	B()
	{
		cout << "B" << endl;
	}
};

 class Sample
 {
 public:
	 Sample(float val);
	 ~Sample();
 private:
	 float a = 2.5;
	 Sample();
 };





