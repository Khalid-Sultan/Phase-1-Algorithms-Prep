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
    int product_size = first_number_length+second_number_length;
    char result[1000000];
    
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
        int index = shifting_index;
        char temp_result[product_size];
        int temp_shifting = 0;
        while (temp_shifting<index)
        {
            temp_result[temp_shifting] = '-';
            temp_shifting+=1;
        }
        
        while(temp_counter_first>=0){
            int first_number_digit = ( (char) first_number[temp_counter_first] )- '0';
            int second_number_digit = ( (char) second_number[temp_counter_second] )- '0';

            int product = (first_number_digit * second_number_digit) + carry;
            carry = (int) product/10;
            int unit = product - (carry*10); 

            temp_result[index] = unit + 48;

            temp_counter_first-=1;
            index+=1;
            // printf("%d * %d = %d [] %d  \t", first_number_digit, second_number_digit, unit, carry);
        }
        if(carry!=0) temp_result[index] = carry+48;
        int counter = strlen(temp_result)-1;    
        printf("\n");
        // while(counter>=0){
        //     printf("%c",temp_result[counter]);
        //     counter-=1;
        // }
        // printf("\n");

        int temp_counter = 0;
        int shifter = 0;

        while (temp_counter<strlen(temp_result))
        {
            int sum = 0;
            if(((char) temp_result[temp_counter])=='-'){
                int digit = 0;
                int result_digit = ((char) result[temp_counter])-'0';
                if(result_digit<0 || result_digit>9) result_digit = 0;
                sum = digit+result_digit + shifter;
                if(sum>=10) {
                    sum = sum-10;
                    shifter = 1; 
                }
                else{            
                    shifter = 0;
                }
            }
            else
            {            
                int digit = ( (char) temp_result[temp_counter] ) - '0';
                int result_digit = ((char) result[temp_counter])-'0';
                if(result_digit<0 || result_digit>9) result_digit = 0;
                sum = digit+result_digit + shifter;
                if(sum>=10) {
                    sum = sum-10;
                    shifter = 1; 
                }
                else{            
                    shifter = 0;
                }
            }
            // printf("%d",sum);
            result[temp_counter] = sum+48;
            temp_counter+=1;
        }
        temp_counter_first=strlen(first_number)-1;
        temp_counter_second-=1;
        shifting_index += 1;
        first_number_length = strlen(first_number)-1;
        second_number_length = strlen(second_number)-1;

    } 
    int counter = strlen(result)-1;    
    while(counter>=0){
        printf("%c",result[counter]);
        counter-=1;
    }

    printf("\n");
}