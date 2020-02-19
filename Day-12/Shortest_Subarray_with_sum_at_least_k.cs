using System;
using System.Collections.Generic;
using System.Text;

namespace Day_12
{
    class Shortest_Subarray_with_sum_at_least_k
    {
        public int ShortestSubarray(int[] A, int target) {
            int low = 1;
            int high = A.Length;

            while(low<high){
                int mid = (low + high)/2;
                if(CalculateSum(A, target, mid)){
                    high = mid;
                }
                else{
                    low = mid+1;
                }
            }

            if(CalculateSum(A, target, low)){
                return low;
            }
            return -1;
        }
        public bool CalculateSum(int[] arr, int target, int counter){
            int left = 0;
            int sum = 0;
            for(int i = 0; i<arr.Length; i++){
                sum += arr[i];
                if(sum<0){
                    sum = 0;
                    left = i + 1;
                    continue;
                }
                while(left<i && (arr[left]<0 || i - left+1 > counter)){
                    sum -= arr[left];
                    left++;
                }
                if(sum>=target){
                    return true;
                }
            }
            return false;
        }
    }
}
