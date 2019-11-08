#include <stdio.h>
int main()
{
	Matching("(1+(3+4)*2)");
	system("pause");	
	return 0;
}

//201811A
#define MAXSTACK 100
typedef char EnumType;
typedef struct {
	EnumType Data[MAXSTACK];
	int top;
}SqStack;
//��ʼ��˳���
InitStack(SqStack *s)
{
	s->top = -1;
}
//push��ջ
Push(SqStack *s,EnumType *x)
{
	if (s->top == MAXSTACK-1)
	{
		printf("���\n");
	}
	s->Data[++s->top] = x;
}
//�ж�ջ�Ƿ�Ϊ��
StackEmpty(SqStack *s)
{
	return s->top == -1;
}
//�ж�ջ�Ƿ�����
Overbrim(SqStack *s)
{
	return s->top == MAXSTACK-1;
}
//��ջ
Pop(SqStack *s)
{
	if (s->top == -1)
	{
		printf("ջ��\n");
	}
	return s->Data[s->top--];
}
//��ȡջ��Ԫ��
GetTop(SqStack *s)
{
	if (StackEmpty(s))
	{
		printf("ջ��\n");
	}
	return s->Data[s->top];
}

Matching(char *str)	//ƥ��
{
	SqStack *s;
	int i = 0, j = 0;
	InitStack(&s);
	for (i = 0;str[i] != '\0';i++)
	{
		switch (str[i])
		{
		case '(':
			Push(&s, str[i]);
			break;
		case ')':
			if (StackEmpty(&s))
			{			
				printf("Cancel\n");
				return;
			}
			Pop(&s);
			j++;
			break;
		default:
			break;
		}
	}
	if (StackEmpty(&s) && j != 0)
	{
		printf("%s %2d\n", "the match brackes is", j);
	}
	else {
		printf("Cancel\n");
	}
}




//#pragma region f33
//typedef int DataType;
//typedef struct node {
//	DataType key;
//	struct node * lchild, * rchild;
//}BinTNode;
//typedef BinTNode * BinTree;
//
//void f33(BinTree root, int left, int right)
//{
//	if (root == NULL) return;
//	f33(root->lchild, left, right);
//	if (root->key >= left && root->key < right) printf("%d", root->key);
//	f33(root->rchild, left, right);
//}
//#pragma endregion

//#pragma region f34
//#define MAXSIZE 100
//typedef int DataType;
//typedef struct node {
//	DataType data;
//	struct node *next;
//}Node;
//typedef Node * SeqList[MAXSIZE];
//
////���ҳɹ�����1������ʧ�ܷ���0
//int f34(SeqList A, int n, int key)
//{
//	int i;
//	Node *p;
//	for (i = 0;i < n;i++)
//	{
//		p = A[i];
//		while (p != NULL && p->data != key)
//		{
//			p = p->next;
//		}
//		if (p != NULL) return 1;
//	}
//	return 0;
//}
//#pragma endregion