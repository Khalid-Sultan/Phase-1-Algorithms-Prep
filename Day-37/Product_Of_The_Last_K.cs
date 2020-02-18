using System;
using System.Collections.Generic;

namespace Day_37
{
    class Product_Of_The_Last_K
    {
        public class ProductOfNumbers
        {

            private List<int> numbers;
            public ProductOfNumbers()
            {
                this.numbers = new List<int>();
            }

            public void Add(int num)
            {
                this.numbers.Add(num);
            }

            public int GetProduct(int k)
            {
                int product = 1;
                if (k % 2 != 0)
                {
                    product *= this.numbers[this.numbers.Count - k];
                    k--;
                }

                int left = this.numbers.Count-k;
                int right = this.numbers.Count-1;
                while (left<right)
                {
                    product *= this.numbers[left] * this.numbers[right];
                    left++;
                    right--;
                }
                return product;
            }
        }
        //static void Main(string[] args)
        //{
        //    /*
        //    ["ProductOfNumbers","add","add","add","add","add","getProduct","getProduct","getProduct","add","getProduct"]
        //    [[],[3],[0],[2],[5],[4],[2],[3],[4],[8],[2]]
        //     */
        //    ProductOfNumbers product = new ProductOfNumbers();
        //    product.Add(3);
        //    product.Add(0);
        //    product.Add(2);
        //    product.Add(5);
        //    product.Add(4);
        //    Console.WriteLine(product.GetProduct(2));
        //    Console.WriteLine(product.GetProduct(3));
        //    Console.WriteLine(product.GetProduct(4));
        //    product.Add(8);
        //    Console.WriteLine(product.GetProduct(2));

        //    /*
        //     ["ProductOfNumbers","add","getProduct","getProduct","getProduct","add","add","add"]
        //        [[],[1],[1],[1],[1],[7],[6],[7]]
        //    */
        //    //ProductOfNumbers product = new ProductOfNumbers();
        //    //product.Add(1);
        //    //Console.WriteLine(product.GetProduct(1));
        //    //Console.WriteLine(product.GetProduct(1));
        //    //Console.WriteLine(product.GetProduct(1));
        //    //product.Add(7);
        //    //product.Add(6);
        //    //product.Add(7);
        //}
    }
}
