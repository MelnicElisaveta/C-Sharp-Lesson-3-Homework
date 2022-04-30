

namespace C_Sharp_Lesson_3_Homework
{
    public class Homework
    {
        public void GetCentralElementFromMatrix(int[,] matrixOfIntegers)
        {
            /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
             * |   input           | result             |
             * |-------------------|--------------------|
             * | {                 |                    |
             * |  { 1,   3,  5},   |    The central     |
             * |  {-1, 100, 11},   |  element is 100    |
             * |  { 2,  15, 44}    |                    |
             * |  }                |                    |
             * |----------------------------------------|
             * |{                  |                    |
             * | { 1,  6, 21,  8 },| This matrix doesn't|
             * | { 5, -4,  5,  7 },| have a central     |
             * | {77,  5,  0, 74 } |  element           |
             * | }                 |                    |
             * ------------------------------------------
             *    
             */
            int len0 = matrixOfIntegers.GetLength(0);
            int len1 = matrixOfIntegers.GetLength(1);
            int middle = matrixOfIntegers[len0 / 2, len1 / 2];


            if (len0 % 2 == 1 && len1 % 2 == 1)
            {
                Console.WriteLine("The central element is " + middle);
            }
            else
            {
                Console.WriteLine("This matrix doesn't have a central element");
            }
        }

        public void GetSummOfDiagonalsElements(int[,] matrixOfIntegers)
        {
            /*print to console the sum of diagonals from matrixOfIntegers, if not exist print: "This matrix doesn't have a diagonal"
             * |   input           | result              |
             * |-------------------|---------------------|
             * | {                 |                     |
             * |  { 1,   3,  5},   | First diagonal: 145 |
             * |  {-1, 100, 11},   | Second diagonal: 107|
             * |  { 2,  15, 44}    |                     |
             * |  }                |                     |
             * |-----------------------------------------|
             * |{                  |                     |
             * | { 1,  6, 21,  8 },| This matrix doesn't |
             * | { 5, -4,  5,  7 },| have a diagonal     |
             * | {77,  5,  0, 74 } |                     |
             * | }                 |                     |
             * ------------------------------------------
             *    
             */
            //your code here
            int sum1 = 0;
            int sum2 = 0;

            if (array.GetLength(0) != array.GetLength(1))
            {
                Console.WriteLine("This matrix doesn't have a diagonal");
                return;
            }

            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int column = 0; column < array.GetLength(1); column++)
                {
                    if (row == column)
                    {
                        sum1 += array[row, column];
                    }
                    if (array.GetLength(1) - column - 1 == row)
                    {
                        sum2 += array[row, column];
                    }
                }
            }
            Console.WriteLine("First Diagonal : " + sum1);
            Console.WriteLine("Second Diagonal : " + sum2);
        }

        public void StarPrinter(int triangleHight)
        {
            /* Write a programm that will print a triagle of stars  with hight = triangleHight
             *  Example: triangleHight = 3;
             *  Result:   *
             *           * *
             *          * * * 
             */
            //your code here
            for (int row = 0; row < triangleHight; row++)
            {
                for (int column = 0; column < (triangleHight * 2 - 1); column++)
                {
                    if (row == triangleHight - 1 || row + triangleHight - 1 == column || row == (triangleHight - column - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
        }

            public void SortList(IList<int> listOfNumbers)
            {
                //Print to console elements of  listOfNumbers in ascending order
                //your code here
                var sortedList = new List<int>(listOfNumbers);
                sortedList.Sort();

                foreach (int item in sortedList)
                {
                    Console.WriteLine(item.ToString());
                }

                Console.ReadKey();
            }
        }

            public static void Main(String[] args)
            {
                Homework homework = new Homework();
                IList<int> list = new List<int>() { -5, 8, -7, 0, 44, 121, -7 };
                int[,] matrix = new int[3, 3] {
                { 1,   3,  5},
                { 2, 3, 5},
                {100, 56 , -54} };
                int[,] matrix2 = new int[3, 4] {
                { 1,   3,  5,   6},
                { 2,   3,  5,  78},
                {100, 56 , -54, 6} };

                homework.GetCentralElementFromMatrix(matrix);
                homework.GetCentralElementFromMatrix(matrix2);
                homework.GetSummOfDiagonalsElements(matrix);
                homework.GetSummOfDiagonalsElements(matrix2);
                homework.StarPrinter(5);
                homework.SortList(list);
            }

}
