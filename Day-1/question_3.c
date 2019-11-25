#include <stdio.h>
#include <stdlib.h>

void print_spaces(int spaces_counter);
void print_stars(int stars_counter);

void main(){
    int sides;

    printf("Provide n:");
    scanf("%d", &sides);
    printf("\n");

    if(sides<=0 || sides>=2000000000){
        printf("Invalid Integer with Out Of Bounds\n");
        return;
    }

    int row_counter = 0;
    int spaces_counter = sides-1;
    int stars_counter = 1;
    while(row_counter<sides){
        print_spaces(spaces_counter);
        print_stars(stars_counter);
        printf("\n");
        //Increment RowCounter, StarsCounter and SpacesCounter
        row_counter+=1;
        stars_counter+=2;
        spaces_counter-=1;
    }
}
void print_spaces(int spaces_counter){
    //Print Out The Spaces
    int temp = 0;
    while(temp<=spaces_counter){
        printf(" ");
        temp+=1;
    }
}
void print_stars(int stars_counter){
    //Print out the stars
    int temp = 0;
    while(temp<stars_counter){
        printf("*");
        temp+=1;
    }
}