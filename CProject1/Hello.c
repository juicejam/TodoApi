#include <stdio.h>
#include <stdlib.h>
int main() {
	int a = 3;
	int * c = &a;
	int * d = *c;

	printf(" %x\n", a);
	printf(" %x\n", c);
	printf(" %x\n", d);

	system("pause");
	return 0;
}