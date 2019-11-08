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
		//BigBox��Box����Ԫ�࣬������ֱ�ӷ���Box����κγ�Ա
		box.setWidth(width);
		cout << "Width of box:" << box.width << endl;
	}
};

//��Ա��������
void Box::setWidth(double wid)
{
	width = wid;
}

//��ע�⣺printWidth()�����κ���ĳ�Ա����
void printWidth(Box box)
{
	//��ΪprintWidth()��Box����Ԫ��������ֱ�ӷ��ʸ�����κγ�Ա
	cout << "Width of box:" << box.width << endl;
}

//�����������
int main1()
{
	Box box;
	BigBox big;

	//ʹ����Ԫ�������ÿ��
	box.setWidth(10.0);

	//ʹ����Ԫ����������
	printWidth(box);

	//ʹ����Ԫ���еķ������ÿ��
	big.Print(20,box);
	getchar();
	return 0;
}




