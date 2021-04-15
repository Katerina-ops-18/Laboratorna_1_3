using System;

namespace Lab_1_3
{
    public delegate int Number();
    public delegate int MediumCalc(Number[] arrayX);
    class Program
    {
        public static int Random()
        {
            Random rand = new Random();
            return rand.Next(1, 10);
        }
        static void Main(string[] args)
        {
            Number[] numArr = new Number[5]; //
            for (int i = 0; i<numArr.Length; i++)
            {
                numArr[i] = Random;
                Console.Write("" + numArr[i].Invoke() + ""); // 
            }
            Console.WriteLine();
            MediumCalc mediumCalc = delegate (Number[] arrayX)
            {
                int sum = 0; //
                for (int i = 0; i < arrayX.Length; i++)
                {
                    sum += arrayX[i](); //
                }
                return ((sum) / (arrayX.Length)); //
            };
            Console.WriteLine(mediumCalc(numArr));
            Console.ReadLine();
        }
    }
}
