using System;
using System.Collections.Generic;
using System.Data;

namespace TuplesDemo {
    class Program {
        static void Main(string[] args) {
            var values = new List<double> { 10, 20, 30, 40, 50 };
            Tuple<int, double> tuple = Calculate(values);
            Console.WriteLine($"their count is {tuple.Item1} There sum is {tuple.Item2}");

            var result = Calulate(values);
            Console.WriteLine($"their sum is {result.Item1} There are {result.Item3} values");

            var (count, sum, resultMessage) = Calulate(values);
            if (resultMessage!="") {
                Console.WriteLine($"There are {count} values and their sum is {sum}");
            }
            

            Console.ReadKey();
        }

        private static (int count, double sum, string message) Calulate(IEnumerable<double> values) {
            int count = 0;
            double sum = 0.0;
            foreach (var value in values) {
                count++;
                sum += value;
            }  
            return (count, sum, "success");
        }

        private static Tuple<int, double> Calculate(List<double> values) {
            int count = 0;
            double sum = 0.0;
            foreach (var item in values) {
                count++;
                sum += item;
            }
            //Creating an object of Touble class by calling the static create method
            Tuple<int, double> t = Tuple.Create(count, sum);

            return t;
        }
    }
}
