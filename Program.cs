using System;

namespace homeWorkPrentheticalEpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string parentheticalesCorrect = "(()(()))";
             
            int depth = 0;

            int maxDepth = 0;   

            char openParenthetical = '(';
            char closeParenthetical = ')';

            for (int i = 0; i < parentheticalesCorrect.Length; i++)
            {
                if (parentheticalesCorrect[i] == openParenthetical)
                {
                    depth++;
                    maxDepth = Math.Max(maxDepth, depth);
                }
                else if (parentheticalesCorrect[i] == closeParenthetical)
                {
                    depth--;
                }

                if (depth < 0)
                {
                    Console.Write("Exention not correct");
                    break;
                }
            }

            Console.WriteLine($"Exeption {parentheticalesCorrect} is correct, depth = {maxDepth}");
        }
    }
}
