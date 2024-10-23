using System;

namespace FlynnsTaxonomy {
    public class SISD {                

        public void Example() {

            // Single Data Set
            List<int> data = new List<int>{1,2,3,4,5};

            // Add all the numbers of the data set
            int result = Add(data);

            //Print the result
            Console.WriteLine($"DATASET: [ {String.Join(',',data)} ]");
            Console.WriteLine($"RESULT - ADD: [ {result} ]");
        }

        public int Add(List<int> nums) {
            int result = 0;
            foreach (int num in nums) result += num;
            return result;
        }
    }
}