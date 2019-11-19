#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void main(){
    char first_number[1000000];
    //  = malloc(1000000*sizeof(char));
    char second_number[1000000];
    //  = malloc(1000000*sizeof(char));

    printf("First Number : ");
    scanf("%s", first_number);
    printf("Second Number : ");
    scanf("%s", second_number);

    int first_number_length = strlen(first_number);
    int second_number_length = strlen(second_number);

    char result[1000000];
    int shifter = 0;
    
    int bool_check = 0;
    int positive_or_negative = 1;

    if(first_number[0]=='-'){
        bool_check = 1;
    }
    if(second_number[0]=='-'){
        if(bool_check==1) {
            bool_check = 0;
            positive_or_negative = -1;
        }
    }

    int temp_counter_first = first_number_length-1;
    int temp_counter_second = second_number_length-1;
    int shifting_index = 0;
    while (temp_counter_second>=0){
        int carry = 0;
        int index = 0;
        char temp_result[1000000];
        while(temp_counter_first>=0){
            int first_number_digit = ( (char) first_number[temp_counter_first] )- '0';
            int second_number_digit = ( (char) second_number[temp_counter_second] )- '0';

            int product = (first_number_digit * second_number_digit) + carry;
            carry = (int) product/10;
            int unit = (carry*10)- product; 
            temp_result[index] = unit + 48;

            temp_counter_first-=1;
            index+=1;
            // printf("%d * %d = %d[]%d\t", first_number_digit, second_number_digit, unit, carry);
        }
        printf("\n");
        // int temp_counter = 0;
        // while (temp_counter<strlen(temp_result))
        // {
        //     int digit = ( (char) temp_result[first_number_length-1] ) - '0';
        //     result[shifting_index] += digit;
        //     temp_counter+=1;
        // }
        temp_counter_first=strlen(first_number)-1;
        temp_counter_second-=1;

        first_number_length = strlen(first_number)-1;
        second_number_length = strlen(second_number)-1;

        int counter = strlen(temp_result)-1;    
        while(counter>=0){
            printf("%c",temp_result[counter]);
            counter-=1;
        }
    } 
    printf("\n");
}