using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            #region first solution
            //int[] array = new int[50];
            //for (int index = 0; index < 50; index++)
            //    array[index] = index + 1;
            #endregion

            int numberToAdd, index = 0;
            Random r = new Random();
            int[] array = new int[50];

            while (index < array.Length)
            {
                numberToAdd = r.Next(0, 101);
                if (!array.Contains(numberToAdd))
                {
                    array[index] = numberToAdd;
                    index++;
                }
            }

            #region second solution
            Console.Write("Sudé indexy: ");
            for (int outEven = 0; outEven < 50; outEven += 2)
            {
                Console.Write(array[outEven]);
                if (outEven != 48)
                    Console.Write(", ");
            }
            Console.WriteLine();


            Console.Write("Liché indexy: ");
            for (int outOdd = 1; outOdd < 50; outOdd += 2)
            {
                Console.Write(array[outOdd]);
                if (outOdd != 49)
                    Console.Write(", ");
            }
            Console.WriteLine();
            #endregion

            #region third solution
            Console.WriteLine("Liché indexy: " + GetNumbers(0, array.Length - 1, array));
            Console.WriteLine("Sudé indexy: " + GetNumbers(1, array.Length, array));
            #endregion 
            Console.WriteLine();
            */
            MyStack<char> m = new MyStack<char>();
            string input = "(({}))]]";
            List<char> brackets = new List<char>();
            foreach (var item in input)
                m.Push(item);

            while (!m.IsEmpty())
            {
                if (m.Peek() == '{' || m.Peek() == '}'
                    || m.Peek() == '(' || m.Peek() == ')'
                    || m.Peek() == '[' || m.Peek() == ']')
                    brackets.Add(m.Pop());
                else
                    m.Pop();
            }
            brackets.Reverse();

            if (brackets[brackets.Count - 1] == '{'
                || brackets[brackets.Count - 1] == '('
                || brackets[brackets.Count - 1] == '['
                || brackets.Count % 2 != 0)
            {
                Console.WriteLine("Špatně zapsaný výraz!!!");
                Console.ReadLine();
                return;
            }

            for (int i = brackets.Count - 1; i >= 0; i--)
            {
                if (brackets[i] == '}' || brackets[i] == ']' || brackets[i] == ')')
                    continue;
                else if ((brackets[i] == '{' && brackets[i + 1] == '}')
                    || (brackets[i] == '[' && brackets[i + 1] == ']')
                    || (brackets[i] == '(' && brackets[i + 1] == ')'))
                {
                    brackets.RemoveAt(i + 1);
                    brackets.RemoveAt(i);
                }
                else
                {
                    Console.WriteLine("Špatně zapsaný výraz!!!");
                    Console.ReadLine();
                    return;
                }

            }
            if (brackets.Count == 0)
            {
                Console.WriteLine("Správně zapsaný příklad :)");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Špatně zapsaný výraz!!!");
                Console.ReadLine();
            }
            return;
        }

        static string GetNumbers(int startNumber, int max, int[] array)
        {
            string outString = "";
            for (int index = startNumber; index < max; index += 2)
            {
                outString += (array[index]);
                if (index != max - 1)
                    outString += ", ";
            }
            return outString;
        }
    }
}
