using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda
{
    class example : IEnumerable
    {

        public example()
        {

        }
        public delegate int AddStringOfInts(string s);
        public delegate string AddNumbersToString(string s);
        public delegate string AddFrequencyToString(string s);
        public delegate void CheckArrayForMultiple(int[] array, int number);

        public AddStringOfInts operateString;
        public AddNumbersToString operateNextString;
        public AddFrequencyToString operateWithFreq;
        public CheckArrayForMultiple operateTheMultiple;


        public int StringToIntAverage(string str)
        {
            int total = 0;
            List<int> final = new List<int>();
            foreach(var s in str.Split(','))
            {
                int num;
                if (int.TryParse(s, out num))
                    final.Add(num);
            }
            final.Sort();
            for (int i = 3; i < final.Count; i++)
            {
                total += final[i];
            }
            total = total / (final.Count - 3);
            return total;
        }
        public string InsertNumbersToString(string str)
        {
            string temporary = str;
            string[] alphabetArray = { string.Empty, "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            for (int i = 0; i < temporary.Length; i++)
            {
                for (int j = 0; j < alphabetArray.Length; j++)
                {
                    if (temporary[i].ToString().ToUpper() == alphabetArray[j])
                    {
                        temporary = temporary.Insert(i + 1, Convert.ToString(j));
                    }

                }
            }
            return temporary;
        }
        public string InsertNumberFrequency(string str)
        {
            List<string> uniqueLetters = new List<string>();
            List<int> numberFreq = new List<int>();
            List<LetterFreq> FreqLetter = new List<LetterFreq>();
            string workingString = str;
            string tempString = "";

            foreach (char character in workingString)
            {
                if (!uniqueLetters.Contains(character.ToString().ToLower()))
                {
                    int temporaryCount = 0;
                    uniqueLetters.Add(character.ToString().ToLower());
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (character.ToString().ToLower() == str[i].ToString().ToLower())
                        {
                            temporaryCount++;
                        }
                    }
                    numberFreq.Add(temporaryCount);
                }
            }
            for (int i = 0; i < uniqueLetters.Count; i++)
            {
                LetterFreq letterFreq = new LetterFreq(uniqueLetters[i].ToString(), numberFreq[i]);
                FreqLetter.Add(letterFreq);
            }
            List<LetterFreq> newFreqLetter = FreqLetter.OrderBy(x => x.letter).ToList();
            for (int i = 0; i < newFreqLetter.Count; i++)
            {
                tempString = tempString + newFreqLetter[i].letter.ToUpper() + newFreqLetter[i].freq.ToString();
            }
            return tempString;
        }

          
        //////////////////////////////////END PART ONE

        public delegate string DetermineIfTH(List<string> strs);//#1
        public delegate bool IsArrayAllOdd(int[] numbers);//#3

        public DetermineIfTH operateTH;
        public IsArrayAllOdd searchArray;

        public bool CheckIfTH(string str)
        {
            if (str.ToUpper().Contains("TH"))
                return true;
            else return false;
        }
        public string CountEachTHWord(List<string> strs)
        {
            int index = 0;
            for (int i = 0; i < strs.Count; i++)
            {
                if (CheckIfTH(strs[i]))
                    index++;
            }
            return "Your list contains " + index + " words that contain 'th'.";
        }

        public bool SearchArrayForOdds(int[] numbers)
        {
            foreach(int number in numbers)
            {
                if (number % 2 == 0)
                    return false;
            }
            return true;
        }
        public void PrintMatches(Product product, List<Product> productArray)
        {
            int index = 1;
            foreach(Product product2 in productArray)
            {
                if(product.catagory == product2.catagory)
                {
                    Console.WriteLine("Product #{0}: CATAGORY:{1} PRODUCT:{2} STOCK:{3}\n", index, product2.catagory, product2.name, product2.stock);
                    index++;
                }
            }
        }
        public void PrintOnlyInStock(Product product, List<Product> productArray)
        {
            int index = 1;
            foreach (Product product2 in productArray)
            {
                if (product.catagory != product2.catagory)
                {
                    Console.WriteLine("Product #{0}: CATAGORY:{1} PRODUCT:{2} STOCK:{3}\n", index, product2.catagory, product2.name, product2.stock);
                    index++;
                }
            }
        }

        public void PrintAllMultiples(int[] myArray, int myNumber)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                if(myArray[i] % myNumber == 0)
                    Console.WriteLine("Array position #{0}: {1} is a multiple of {2}.", i + 1, myArray[i], myNumber);
                else
                    Console.WriteLine("Array position #{0}: {1} is NOT a multiple of {2}.", i + 1, myArray[i], myNumber);
            }
        }









        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
