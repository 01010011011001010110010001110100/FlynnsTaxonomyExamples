using System;

namespace FlynnsTaxonomy {
    public class SIMD {
        public void Example() {

            // Multiple Data Sets
            int[] data = new int[]{1,2,3,4,5};
            int[] data2 = new int[]{6,7,8,9,10};
            int[] result = new int[data.Length];

            // do one process for multi data sets
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = data[i] + data2[i];
            }

            //Print the result
            Console.WriteLine($"DATASET#1: [ {String.Join(',',data)} ]");
            Console.WriteLine($"DATASET#2: [ {String.Join(',',data2)} ]");
            Console.WriteLine($"RESULT - ADD [data + data2]: [ {String.Join(',',result)} ]");
        }

    }
}