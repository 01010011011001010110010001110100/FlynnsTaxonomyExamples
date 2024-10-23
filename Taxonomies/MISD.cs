using System;

namespace FlynnsTaxonomy {
    public class MISD {
        public void Example() {

            // Single Data Set
            List<int> data = new List<int>{1,2,3,4,5};

            // Applay multiple proccess to a one data set
            int addResult = Add(data);
            int subtractResult = Subtract(data);
            int multiplyResult = Multiply(data);
            int largeNumberResult = LargerNumber(data);

            //Print the results
            Console.WriteLine($"DATASET : [ {String.Join(',',data)} ]");
            Console.WriteLine($"RESULT - ADD : [ {addResult} ]");
            Console.WriteLine($"RESULT - SUBTRAC : [ {subtractResult} ]");
            Console.WriteLine($"RESULT - MULTIPLY : [ {multiplyResult} ]");
            Console.WriteLine($"RESULT - MAJOR NUM : [ {largeNumberResult} ]");
        }

        public int Add(List<int> nums) {
            int result = 0;
            foreach (int num in nums) result += num;
            return result;
        }

        public int Subtract(List<int> nums) {
            int result = 0;
            foreach (int num in nums) result -= num;
            return result;
        }

        public int Multiply(List<int> nums) {
            int result = 1;
            foreach (int num in nums) result *= num;
            return result;
        }

        public int LargerNumber(List<int> nums) {
            int major = 0;
            foreach (int num in nums) {
                if (num > major) {
                    major = num;
                }
            }
            return major;
        }
    }
}