using System;

namespace homeWorkPrentheticalEpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringParentheticalesCorrect = "(()(()))";
 
            int[] numberesDeepParenthetical =  new int [1];
            int[] tempNumbresDeepParenthetical = new int[numberesDeepParenthetical.Length + 1];

            char openParenthetical = '(';
            char closeParenthetical = ')';

            int countOpenParenthetical = 0;
            int countCloseParenthetical = 0;
            int maxDeepParenthetical = 0;

            Console.Write(stringParentheticalesCorrect);
            Console.WriteLine();

            for (int i = 0; i < stringParentheticalesCorrect.Length; i++)
            {
                if (stringParentheticalesCorrect[i] == openParenthetical)
                {
                    countOpenParenthetical++;
                }
                else if (stringParentheticalesCorrect[i] == closeParenthetical)
                {
                    countCloseParenthetical++;
                }
                if((countOpenParenthetical - countCloseParenthetical) == 0)
                {
                    numberesDeepParenthetical[0] = countOpenParenthetical;
                    for (int j = 0; j < numberesDeepParenthetical.Length; j++)
                    {
                        tempNumbresDeepParenthetical[j] = numberesDeepParenthetical[j];
                    }
                    numberesDeepParenthetical = tempNumbresDeepParenthetical;
                }
            }

            for (int i = 0; i < numberesDeepParenthetical.Length; i++)
            {
                Console.Write(numberesDeepParenthetical[i] + " ");
            }

            Console.WriteLine("\n\n\n");

            if(countOpenParenthetical == countCloseParenthetical)
            {
                Console.WriteLine($"{stringParentheticalesCorrect} - its correct string parenthetical");
            }
            else
            {
                Console.WriteLine($"{stringParentheticalesCorrect} - its not correct string parenthetical");
            }

            for (int i = 0;i < numberesDeepParenthetical.Length - 1; i++)
            {
                if (numberesDeepParenthetical[i] > numberesDeepParenthetical[i + 1])
                {
                    maxDeepParenthetical = numberesDeepParenthetical[i];
                }
            }
            
            Console.WriteLine("Max deep = " + maxDeepParenthetical );
        }
    }
}
