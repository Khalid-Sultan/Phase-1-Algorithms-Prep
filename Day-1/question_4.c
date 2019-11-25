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
                bigger_size = first_number_length;
                bigger_one = 1;
                break;
            } 
            else if(first_number[temp]<second_number[temp]){
                bigger_size = second_number_length;
                bigger_one = 2;
                break;
            }            
            temp+=1;
        }
    }

    int shifter = 0;
    

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

        if(first_number_digit<0 || first_number_digit>9) {
            first_number_digit = 0;
            first_number[first_number_length-1] = '0';
        }
        if(second_number_digit<0 || second_number_digit>9){
            second_number_digit = 0;
            second_number[second_number_length-1] = '0';
        }

        if(bool_check==0 || bool_check==3){
            sum = first_number_digit + second_number_digit + shifter;
            printf("%d + %d = %d \n", first_number_digit, second_number_digit, sum);
        }

        else if(bool_check==1){
            if(first_number_digit>second_number_digit){
                sum = first_number_digit - second_number_digit;
                printf("%d - %d = %d \n", first_number_digit, second_number_digit, sum);
            }
            else if(first_number_digit<second_number_digit){
                int checker = first_number_digit;
                int temp = first_number_length-1;
                while(checker<second_number_digit){
                    checker = ( (char) first_number[temp] ) - '0';
                    if(checker==0){
                        first_number[temp] = '9';
                        temp-=1;
                        continue;
                    }
                    first_number_digit += 10;
                    temp-=1;
                    if (( ( (char) first_number[temp] ) - '0')==0) {
                        int curr = temp;
                        while (1)
                        {
                            if(first_number[curr]=='0') first_number[curr] = '9';
                            else{
                                first_number[curr]-=1;
                                break;
                            }
                            curr -= 1;
                        }                    
                    }
                    else{
                        first_number[temp]-=1;
                    }
                    break;
                }
                sum = first_number_digit - second_number_digit;
                printf("%d - %d = %d \n", first_number_digit, second_number_digit, sum);
                // if(sum<0) sum*=-1;
            }
            else{
                sum = 0;
            }
        }
        else if(bool_check==2){
            if(second_number_digit>first_number_digit){
                int checker = first_number_digit;
                int temp = first_number_length-1;
                while(checker<second_number_digit){
                    checker = ( (char) first_number[temp] ) - '0';
                    if(checker==0){
                        first_number[temp] = '9';
                        temp-=1;
                        continue;
                    }
                    first_number_digit += 10;
                    temp-=1;
                    if (( ( (char) first_number[temp] ) - '0')==0) {
                        int curr = temp;
                        while (1)
                        {
                            if(first_number[curr]=='0') first_number[curr] = '9';
                            else{
                                first_number[curr]-=1;
                                break;
                            }
                            curr -= 1;
                        }                    
                    }
                    else{
                        first_number[temp]-=1;

                    }
                    break;
                }
                sum = first_number_digit - second_number_digit;
                printf("%d - %d = %d \n", first_number_digit, second_number_digit, sum);
                // if(sum<0) sum*=-1;
            }
            else if(second_number_digit<first_number_digit){
                sum = first_number_digit - second_number_digit;
                printf("%d - %d = %d \n", first_number_digit, second_number_digit, sum);
            }
            else{
                sum = 0;
            }
        }

        first_number_length -= 1;
        second_number_length -= 1;

        if(sum>=10 && positive_or_negative==1) {
            sum = sum-10;
            shifter = 1; 
        }
        else{            
            shifter = 0;
        }
        result[temp_counter] = sum+48;
        temp_counter+=1;
    }
    if(positive_or_negative==-1){
        printf("%c", '-');
    }
    else{
        printf("%c", '+');
    }
    if(shifter!=0){
        printf("%c",shifter+48);
    }
    int counter = temp_counter-1;    
    int found = 0;
    while(counter>=0){
        if(found==0){
            if(result[counter]-48==0){
                counter-=1;
                continue;
            }
            found = 1;            
        }
        printf("%c",result[counter]);
        counter-=1;
    }
    printf("\n");
}