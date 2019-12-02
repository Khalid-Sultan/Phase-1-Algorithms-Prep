#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void printOutResults(char *result){
    int counter = strlen(result)-1;
    while(counter>=0){
        printf("%c",result[counter]);
        counter-=1;
    }
}
void printOutSign(int positive){
    if(positive==1) printf("%c", '+');
    else printf("%c",'-');
}

void main(){
    //Receive Two Numbers From the User
    char first_number[1000000];
    char second_number[1000000];
    printf("First Number : ");
    scanf("%s", first_number);
    printf("Second Number : ");
    scanf("%s", second_number);

    //Estimate Which is the larger size and Create An Array Of That
    int first_number_length = strlen(first_number);
    int second_number_length = strlen(second_number);
    int product_size = first_number_length+second_number_length;
    char result[1000000];

    //Check For Negativity
    int bool_check = 0;
    int positive_or_negative = 1;
    //If the first Number Has - sign at the first instance set flags
    if(first_number[0]=='-'){
        bool_check = 1;
        positive_or_negative = -1;
    }
    //If the second Number has - sign at the first instance set flags
    if(second_number[0]=='-'){
        //If both have them
        if(bool_check==1) {
            bool_check = 3;
            positive_or_negative = 1;
        }
            //If only the second has -
        else{
            bool_check = 2;
            positive_or_negative = -1;
        }
    }

    //Shift the First Number to replace the - sign
    if(bool_check==1){
        int temp = 0;
        while(temp<=first_number_length){
            first_number[temp] = first_number[temp+1];
            temp+=1;
        }
        first_number_length-=1;
    }
        //Shift the Second Number to replace the - sign
    else if(bool_check==2){
        int temp = 0;
        while(temp<=second_number_length){
            second_number[temp] = second_number[temp+1];
            temp+=1;
        }
        second_number_length-=1;
    }
        //Shift Both Numbers to replace the - sign
    else if(bool_check==3){
        int temp = 0;
        while(temp<=first_number_length){
            first_number[temp] = first_number[temp+1];
            temp+=1;
        }
        temp = 0;
        while(temp<=second_number_length){
            second_number[temp] = second_number[temp+1];
            temp+=1;
        }
        first_number_length-=1;
        second_number_length-=1;
    }


    //Count Digits in the first and second number
    int temp_counter_first = first_number_length-1;
    int temp_counter_second = second_number_length-1;

    //Use a shifting index to move with every number multiplied from the second number
    int shifting_index = 0;

    //Main Loop- Every element in the Denominator Multiplies the numerator and shifts to the right one step before the last
    while (temp_counter_second>=0){
        int carry = 0;
        char temp_result[product_size];

        //SPACING SECTION
        //Using the shifting index to multiply every element in the numerator
        int index = shifting_index;
        //Put Stars if there is value in the shifting index
        int temp_shifting = 0;
        while (temp_shifting<index)
        {
            temp_result[temp_shifting] = '*';
            temp_shifting+=1;
        }


        //MULTIPLICATION SECTION
        //Multiply Every Element in the numerator by the selected element of the denominator
        while(temp_counter_first>=0){
            int first_number_digit = ( (char) first_number[temp_counter_first] )- '0';
            int second_number_digit = ( (char) second_number[temp_counter_second] )- '0';

            int product = (first_number_digit * second_number_digit) + carry;
            //Carry Element - When element reaches more than 9
            carry = (int) product/10;
            //Unit Element - Bounded between 0 and 9
            int unit = product - (carry*10);

            //Set the result on the temporary result before adding it to the main one.
            temp_result[index] = unit + 48;
            temp_counter_first-=1;
            index+=1;
            // printf("%d * %d = %d [] %d  \t", first_number_digit, second_number_digit, unit, carry);
        }

        //If there is any irregularities set the carry to 0
        if(carry!=0) temp_result[index] = carry+48;

        //ADDITION SECTION
        //Here we add the temporary result to the main result before moving on to the next item.
        int temp_counter = 0;
        int shifter = 0;

        while (temp_counter<strlen(temp_result))
        {
            int sum = 0;
            //If we find a star, set the digit to 0 and proceed with the sum
            if(((char) temp_result[temp_counter])=='*'){
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
    printOutSign(positive_or_negative);
    printOutResults(result);
    printf("\n");
}

