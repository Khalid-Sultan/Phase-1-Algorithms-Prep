#include <stdio.h>
#include <stdlib.h>
#include <math.h>

void main(){
    long long int big_number;
    printf("Input : ");
    scanf("%ld", &big_number);
    printf("Given Big Number %ld\n", big_number);
    printf("Size %lld\n", pow(2, sizeof(long long int)));
}