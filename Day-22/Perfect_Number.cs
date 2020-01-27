using System;
using System.Collections.Generic;
using System.Text;

namespace Day_22
{
    class Perfect_Number
    {
        public bool CheckPerfectNumber(int num)
        {
            if (num <= 0) return false;
            int sum = 0;
            int index = 1;
            while (index * index <= num)
            {
                if (num % index == 0)
                {
                    sum += index;
                    if (index * index != num)
                    {
                        sum += num / index;
                    }
                }
                index++;
            }
            return num == sum - num;
        }
    }
}
