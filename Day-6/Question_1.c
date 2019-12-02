using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
	class Question_1
	{
		public int[] SortArrayByParityII(int[] A) {
			int max_digit = 0;
			for (int i = 0; i < A.Length; i++)
			{
				if (max_digit < A[i]) max_digit = A[i];
			}
			int[] accumulation_array = new int[max_digit + 1];
			for (int i = 0; i < accumulation_array.Length; i++)
			{
				accumulation_array[i] = 0;
			}
			for (int i = 0; i < A.Length; i++)
			{
				accumulation_array[A[i]] += 1;
			}
			int[] result_array = new int[A.Length];
			int index = 0;
			for (int i = 0; i < accumulation_array.Length; i++)
			{
				if (accumulation_array[i] == 0) continue;
				for (int j = 0; j < accumulation_array[i]; j++)
				{
					result_array[index] = i;
					index += 1;
				}
			}
			for (int i = 0; i < result_array.Length; i++)
			{
				int current_number = result_array[i];
				if (current_number % 2 == 0 && i % 2 == 0) continue;
				else if (current_number % 2 != 0 && i % 2 != 0) continue;
				else
				{
					for (int j = i + 1; j < result_array.Length; j++)
					{
						if (i % 2 == 0) {
							if (result_array[j] % 2 == 0)
							{
								int temp = result_array[i];
								result_array[i] = result_array[j];
								result_array[j] = temp;
								break;
							}
						}
						else {
							if (result_array[j] % 2 != 0)
							{
								int temp = result_array[i];
								result_array[i] = result_array[j];
								result_array[j] = temp;
								break;
							}
						}
					}
				}
			}
			return result_array;

		}
	}
}
