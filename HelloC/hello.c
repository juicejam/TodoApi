#include <stdio.h>
int main()
{
	puts("Hello World!!!");

	
	

	system("pause");	
	return 0;
}

typedef int DataType;
typedef struct node {
	DataType key;
	struct node * lchild, * rchild;
}BinTNode;
typedef BinTNode * BinTree;

void f33(BinTree root, int left, int right)
{
	if (root == NULL) return;
	f33(root->lchild, left, right);
	if (root->key >= left && root->key < right) printf("%d", root->key);
	f33(root->rchild, left, right);
}