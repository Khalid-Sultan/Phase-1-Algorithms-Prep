#include <stdio.h>

int main()
{
	int value = 0;
	scanf("%d", &value);
	if (value == 2) {
		printf("NO\n");
		return 0;
	}
	else if (((int)(value % 2)) == 0) {
		printf("YES\n");
		return 0;
	}
	else {
		printf("NO\n");
		return 0;
	}
}