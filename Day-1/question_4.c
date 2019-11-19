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
    //  = malloc(1000000*sizeof(char));    
    int bigger_size = 0;

    int bigger_one = 0;
    if(first_number_length<second_number_length){
        bigger_size = second_number_length;
        bigger_one = 2;
    }
    else if(first_number_length>second_number_length){
        bigger_size = first_number_length;
        bigger_one = 1;
    }
    else{
        int temp = 0;
        while(temp<first_number_length){
            if(first_number[temp]>second_number[temp]){
                bigger_size = first_number;
                bigger_one = 1;
                break;
            } 
            else if(first_number[temp]<second_number[temp]){
                bigger_size = second_number;
                bigger_one = 2;
                break;
            }            
            temp+=1;
        }
    }

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
        else{
            bool_check = 2;
        }        
    }

    if(bool_check==1 && bigger_one==1){
        positive_or_negative = -1;
    }
    else if(bool_check==2 && bigger_one==2){
        positive_or_negative = -1;
    }

    int temp_counter = 0;
    while (temp_counter<bigger_size)
    {
        int first_number_digit = ( (char) first_number[first_number_length-1] )- '0';
        int second_number_digit = ( (char) second_number[second_number_length-1] )- '0';

        int sum = 0;

        if(bool_check==0){
            if(first_number_digit<0 || first_number_digit>9) first_number_digit = 0;
            if(second_number_digit<0 || second_number_digit>9) second_number_digit = 0;
            sum = first_number_digit + second_number_digit + shifter;
        }

        else if(bool_check==1){
            if(first_number_digit>second_number_digit){
                sum = first_number_digit - second_number_digit;
            }
            else if(first_number_digit<second_number_digit){
                int checker = first_number_digit;
                int temp = first_number_length-1;
                while(checker<second_number_digit){
                    checker = ( (char) first_number[temp] ) - '0';
                    if(checker<0) first_number[temp] = '9';
                    else first_number[temp] = 
                }
            }
            else{
                sum = 0;
            }
        }
        else {
        }
        printf("%c with %c \n", first_number_digit+48, second_number_digit+48);

        first_number_length -= 1;
        second_number_length -= 1;

        if(sum>=10) {
            sum = sum-10;
            shifter = 1; 
        }
        else{            
            shifter = 0;
        }
        result[temp_counter] = sum+48;
        temp_counter+=1;
    }
    if(shifter!=0){
        printf("%c",shifter+48);
    }
    int counter = temp_counter-1;    
    while(counter>=0){
        printf("%c",result[counter]);
        counter-=1;
    }
    printf("\n");
}