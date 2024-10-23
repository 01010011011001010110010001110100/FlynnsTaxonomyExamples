using System;

namespace FlynnsTaxonomy {
    public class MIMD {
        public void Example() {

            // Single Data Set
            int[] data = new int[]{1,2,3,4,5};
            int[] data2 = new int[]{6,7,8,9,10};
            int[] data3 = new int[]{11,12,13,14,15};

            // Applay multiple proccess to a multiples data sets
            Task task1 = Task.Run(() => {
                int result = Add(data);
                Console.WriteLine($"DATASET#1: [ {String.Join(',',data)} ]");
                Console.WriteLine($"TASK - ADD : [ {result} ]");
            });

            Task task2 = Task.Run(() => {
                int result = Multiply(data2);
                Console.WriteLine($"DATASET#2: [ {String.Join(',',data2)} ]");
                Console.WriteLine($"TASK - MULTIPLY : [ {result} ]");                
            });

            Task task3 = Task.Run(() => {
                int result = LargerNumber(data3);
                Console.WriteLine($"DATASET#3: [ {String.Join(',',data3)} ]");
                Console.WriteLine($"TASK - MAJOR : [ {result} ]");                   
            });

            //Wait all the process end
            Task.WaitAll(task1,task2,task3);

            Console.WriteLine("\nTasks Completed");
        }

        public int Add(int[] nums) {
            int result = 0;
            foreach (int num in nums) result += num;
            return result;
        }

        public int Multiply(int[] nums) {
            int result = 1;
            foreach (int num in nums) result *= num;
            return result;
        }

        public int LargerNumber(int[] nums) {
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