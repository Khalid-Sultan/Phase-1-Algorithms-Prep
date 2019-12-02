using System;

namespace Day_4 { 
    class Program
    {       
        static int[] extractDigits(string number)
        {
            char[] array = number.ToCharArray();
            int[] digits = new int[array.Length];
            int low = 0;
            if (array[low] == '-') low += 1;
            for(int i = 0;i<array.Length; i++)
            {
                digits[i] = (Convert.ToInt32(char.GetNumericValue(array[i])));
            }
            return digits;
        }
        static void printArray(int[] digits)
        {
            Console.Write("Results : [ ");
            for(int i=digits.Length-1; i>=0; i--)
            {
                if (i == digits.Length - 1 && digits[i] == 0) continue;
                Console.Write($"{digits[i]} ");
            }
            Console.WriteLine("]");
        }
        static int[] add(int[] first_digits, int[] second_digits, int positivity)
        {
            int first_digits_length = 0;
            int second_digits_length = 0;
            int low = 0;
            if (positivity == 0)
            {
                first_digits_length = first_digits.Length;
                second_digits_length = second_digits.Length;
            }
            else if (positivity == 1)
            {
                first_digits_length = first_digits.Length - 1;
                second_digits_length = second_digits.Length;
                low += 1;
            }
            else if (positivity == 2)
            {
                first_digits_length = first_digits.Length;
                second_digits_length = second_digits.Length-1;
                low += 1;
            }
            else
            {
                first_digits_length = first_digits.Length - 1;
                second_digits_length = second_digits.Length - 1;
                low += 1;
            }
            int bigger_size = first_digits_length > second_digits_length? first_digits_length: second_digits_length;
            if (first_digits_length == second_digits_length)
            {
                for(int i = low; i < first_digits_length; i++)
                {
                    if (first_digits[i] > second_digits[i])
                    {
                        bigger_size = first_digits.Length;
                        break;
                    }
                    else if(first_digits[i]<second_digits[i]){
                        bigger_size = second_digits.Length;
                        break;
                    }
                }
            }
            int[] results = new int[bigger_size+1];
            int first_number_length = first_digits.Length;
            int second_number_length = second_digits.Length;
            int carry = 0;
            int k = 0;
            for(int i = first_number_length-1, j = second_number_length-1; bigger_size>low; i--, j--, k++)
            {
                int a = first_number_length > 0 ? first_digits[i] : 0;
                int b = second_number_length > 0 ? second_digits[j] : 0;
                if (positivity == 0 || positivity==3)
                {
                    int sum = a + b + carry;
                    if (sum >= 10)
                    {
                        sum -= 10;
                        carry += 1;
                    }
                    else carry = 0;
                    first_number_length -= 1;
                    second_number_length -= 1;
                    bigger_size -= 1;
                    results[k] = sum;
                }
                else if(positivity==1)
                {
                    if (a < b)
                    {
                        carry += a;
                        k -= 1;
                        continue;
                    }
                    int sum = a + b + carry;
                    if (sum >= 10)
                    {
                        sum -= 10;
                        carry += 1;
                    }
                    else carry = 0;
                    first_number_length -= 1;
                    second_number_length -= 1;
                    bigger_size -= 1;
                    results[k] = sum;

                }
            }
            if (carry > 0)
            {
                results[k] = carry;
            }
            return results;
        }
        static int[] sub(int[] first_digits, int[] second_digits)
        {
            int bigger_size = first_digits.Length > second_digits.Length ? first_digits.Length : second_digits.Length;
            if (first_digits.Length == second_digits.Length)
            {
                for (int i = 0; i < first_digits.Length; i++)
                {
                    if (first_digits[i] > second_digits[i])
                    {
                        bigger_size = first_digits.Length;
                        break;
                    }
                    else if (first_digits[i] < second_digits[i])
                    {
                        bigger_size = second_digits.Length;
                        break;
                    }
                }
            }
            int[] results = new int[bigger_size + 1];
            int first_number_length = first_digits.Length;
            int second_number_length = second_digits.Length;
            int carry = 0;
            int k = 0;
            for (int i = first_number_length - 1, j = second_number_length - 1; bigger_size > 0; i--, j--, k++)
            {
                int a = first_number_length > 0 ? first_digits[i] : 0;
                int b = second_number_length > 0 ? second_digits[j] : 0;
                int sum = a + b + carry;
                if (sum >= 10)
                {
                    sum -= 10;
                    carry += 1;
                }
                else carry = 0;
                first_number_length -= 1;
                second_number_length -= 1;
                bigger_size -= 1;
                results[k] = sum;
            }
            if (carry > 0)
            {
                results[k] = carry;
            }
            return results;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter First Number : ");
            string first_number = Console.ReadLine();
            Console.Write("Enter Second Number : ");
            string second_number = Console.ReadLine();
            Console.Write("Enter Operation (+,-,*,/) : ");
            string key = Console.ReadLine();
            int[] first_digits = extractDigits(first_number);
            int[] second_digits = extractDigits(second_number);
            switch (key)
            {
                case "+":
                    int positivity = 0;
                    if (first_digits[0] == '-' && second_digits[0] != '-') positivity = 1;
                    else if (first_digits[0] != '-' && second_digits[0] == '-') positivity = 2;
                    else if (first_digits[0] == '-' && second_digits[0] == '-') positivity = 3;
                    int[] added = add(first_digits, second_digits, positivity);
                    printArray(added);
                    break;
                case "-":
                    //int[] subbed = sub(first_digits, second_digits);
                    //printArray(subbed);
                    break;
                case "*":
                    //int[] mulled = mul(first_digits, second_digits);
                    //printArray(mulled);
                    break;
                case "/":
                    //int[] dived = div(first_digits, second_digits);
                    //printArray(dived);
                    break;
                default:
                    break;
            }
        }
    }
}
