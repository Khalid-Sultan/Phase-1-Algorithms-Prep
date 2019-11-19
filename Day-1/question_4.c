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

    if(first_number_length<=second_number_length){
        bigger_size = second_number_length;
    }
    else{
        bigger_size = first_number_length;
    }

    int temp_counter = 0;
    int shifter = 0;
    int bool_check = 0;
    if(first_number[0]=='-'){
        bool_check = 1;
    }
    if(second_number[0]=='-'){
        if(bool_check==1) {
            bool_check = 0;
        }
        else{
            bool_check = 2;
        }        
    }
    while (temp_counter<bigger_size)
    {
        char first_number_digit;
        char second_number_digit;

        if(bool_check==0 || bool_check==1 && first_number_length>0 || bool_check==2 && second_number_length>0){
            first_number_digit = (char) first_number[first_number_length-1];
            second_number_digit = (char) second_number[second_number_length-1];
        } 
        else if(bool_check==1 && first_number_length==0){
            first_number_digit = '0';
            second_number_digit = (char) second_number[second_number_length-1];
        }         
        else if(bool_check==2 && second_number_length==0){
            first_number_digit = (char) first_number[first_number_length-1];
            second_number_digit = '0';
        }         

        if(second_number_digit<48 || second_number_digit>57) second_number_digit = 48;
        if(first_number_digit<48 || first_number_digit>57) first_number_digit = 48;
        printf("%c with %c \n", first_number_digit, second_number_digit);

        first_number_length -= 1;
        second_number_length -= 1;

        int sum = 0;
        if(bool_check==0){
            sum = (((int)first_number_digit)-48)+(((int)second_number_digit)-48)+ shifter;
            if(sum>=10) {
                sum = sum-10;
                shifter = 1; 
            }
            else{            
                shifter = 0;
            }
        }
        else if(bool_check==1){
            sum = ((-1 * (int)first_number_digit)-48)+(((int)second_number_digit)-48)+ shifter;
            if(sum>=10) {
                sum = sum-10;
                shifter = 1; 
            }
            else{            
                shifter = 0;
            }
        }
        else{
            sum = (((int)first_number_digit)-48)+((-1*(int)second_number_digit)-48)+ shifter;
            if(sum>=10) {
                sum = sum-10;
                shifter = 1; 
            }
            else{            
                shifter = 0;
            }
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