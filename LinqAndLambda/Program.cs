using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            example example = new example();

            string numbers = "80,90,96,83,55,86,100,99";

            example.operateString = (string s) => { return example.StringToIntAverage(s); };

            Console.WriteLine(example.operateString(numbers).ToString());
            Console.ReadLine();

            string name = "Kristofer";
            string name2 = "Llewellyn";
            string name3 = "HahATheLaughTaughtMeAndTee";

            example.operateNextString = (string s) => { return example.InsertNumbersToString(s); };

            Console.WriteLine(example.operateNextString(name).ToString());
            Console.ReadLine();

            example.operateWithFreq = (string s) => { return example.InsertNumberFrequency(s); };

            Console.WriteLine(example.operateWithFreq(name2).ToString());
            Console.ReadLine();

            example.operateWithFreq = (string s) => { return example.InsertNumberFrequency(s); };

            Console.WriteLine(example.operateWithFreq(name3).ToString());
            Console.ReadLine();


            //////////////////////////////////END PART ONE

            //#1
            List<string> list1 = new List<string>();
            list1.Add("There"); list1.Add("is"); list1.Add("a"); list1.Add("lot");
            list1.Add("that"); list1.Add("thought"); list1.Add("wonderful");

            example.operateTH = (List<string> strs) => { return example.CountEachTHWord(strs); };

            Console.WriteLine(example.operateTH(list1));
            Console.ReadLine();

            //#2
            List<Product> toys = new List<Product>();
            Product one = new Product("boys", "lego", 3);
            Product two = new Product("girls", "barbie", 4);
            Product three = new Product("boys", "action figure", 0);
            Product four = new Product("girls", "tiara", 1);
            toys.Add(one); toys.Add(two); toys.Add(three); toys.Add(four);

            List<Product> groupedToys;

            groupedToys = (from x in toys
                           where x.stock == 0
                           select x).ToList();
            groupedToys.ForEach((x) => { example.PrintMatches(x, toys); });
            Console.ReadLine();
            
            //#3
            int[] numbers2 = { 1, 2, 3, 4, 5 };
            int[] oddNumbers = { 1, 3, 5, 7, 9 };

            example.searchArray = (int[] tempArray) => { return example.SearchArrayForOdds(tempArray); };

            Console.WriteLine("That array does {0}contain all odd numbers.", example.searchArray(numbers2) ? "" : "not ");
            Console.ReadLine();

            Console.WriteLine("That array does {0}contain all odd numbers.", example.searchArray(oddNumbers) ? "" : "not ");
            Console.ReadLine();

            //#4
            List<Product> groupedToys2;

            groupedToys2 = (from x in toys
                           where x.stock == 0
                           select x).ToList();
            groupedToys2.ForEach((x) => { example.PrintOnlyInStock(x, toys); });
            Console.ReadLine();

            //#5

            //#10

            int[] numbersArray = { 12, 44, 45, 76, 24, 96, 87, 52, 100, 101, 9999 };
            int checkMultiple = 4;

            example.operateTheMultiple = (int[] x, int y) => { example.PrintAllMultiples(x, y);};
            example.operateTheMultiple(numbersArray, checkMultiple);
            Console.ReadLine();


        }
    }
}