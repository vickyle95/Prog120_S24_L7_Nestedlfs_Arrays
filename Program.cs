using System.Threading.Channels;

namespace Prog120_S24_L7_Nestedlfs_Arrays
{
    internal class Program
    {
        // 3 levels of variable scope
        // Class Level
        // Method Level
        // Block Level
        static void Main(string[] args)
        {
           // Vicky Le
           // Programming 120 
           // 4/23/24
            
            // What is nested if statement?
            // If - Answer one question
            // If ( condition1 && condition2 )
            //If ( condition ) {
            //      if ( sebsequent condition) {
            // }

            // }

            // Arrays
            // An array is a COLLECTION of variables of the same TYPE
            // Method Scope
            // To DECLARE AN ARRAY you TYPE[size]
            // To INITIALIZE = new type[size]
            int[] vickyGrades = new int[10];

            // How to initialize an array with values
            int[] willGrades = new int[] {10, 45, 99, 14, 56};

            // Change the value of an element
            int changeGrade = 10;
            vickyGrades[0] = 10;


            // To ACCESS an ELEMENT in the array, you use [index]
            // Element is the term for an individual value you an array
            // ALL ARRAYS START AT INDEX 0
            int firstgrade = vickyGrades[0];

            Console.WriteLine(firstgrade);

            Console.WriteLine("Display Wills Grades");

            // i = 0 starts at the beginning of our array
            // length indicate the number of elements in the array
            // array.length
            // The LAST INDEX is ALWAYS .Length -1
            // Elements: 1, 2, 3, 4, 5, 6, 
            // Values: 10, 45, 99, 14, 56, 87
            // Index: 0, 1, 2, 3, 4, 5, 

            int totalGrade = 0;

            for (int i = 0; i < willGrades.Length; i++)
            {
                // Storing the current grade
                int willsCurrentGrade = willGrades[i];
                int currentElement = i + 1;
                int currentIndex = i;
                string currentGrade = GradeCovertor(willsCurrentGrade);

                Console.WriteLine($"Index {currentIndex} : Value {willsCurrentGrade} : Element {currentElement} : Letter Grade {currentGrade}" );
                // Index 0 : Value 10 : Element 1


            }
            double averageGrade = Math.Round((double)totalGrade / willGrades.Length);
            string letterAverage = GradeCovertor((int)averageGrade);

            Console.WriteLine($"Wills Average Grade is {averageGrade} : {letterAverage}");




        } // Main   
        
        public static void randonExample()
        {
            // Introduce the Random Object
            // Type Random
            Random rand = new Random();
            //// In order to use our random object, we call the .Next Method
            int randomNumber = rand.Next();
            //// Calling Next with a max value (exclusive)
            int randomNumberMaxValue = rand.Next(101);
            //// Calling Next with a min and max value
            int randomNumberMinMax = rand.Next(-50, 51);

            // ---- Calling the same seed
            Random rand2 = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rand2.Next());
            }
        } // randomExample

        public static void LetterGradeConventorLoop()
        {
            // Nested Conditions
            // Grading Table
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                string grade = GradeCovertor(rand.Next(40, 106));
            }

          
        } // LetterGradeConventorLoop

        public static string GradeCovertor(int grade)
        {
            int numericalGrade = grade;

            // Error > 100
            // A - 90 - 100
            // B - 80 - 89
            // C - 70 - 79
            // D - 60 - 69
            // F - < 60



            Console.Write($"{numericalGrade} - ");
            string letterGrade = "";

            // | 101 ----------------------------------------
            if (numericalGrade > 100)
            {
                letterGrade = "Invalid Input";
            }
            // | 90 -----------A---------- 100
            else if (numericalGrade >= 90)
            {
                numericalGrade %= 10;
                letterGrade = "A";

                if (numericalGrade <= 95)
                {
                    letterGrade += "-";
                }

            }
            else if (numericalGrade >= 80)
            {
                numericalGrade -= 80;
                letterGrade = "B";

                if (numericalGrade > 7)
                {
                    letterGrade += "+";
                }
                else if (numericalGrade <= 3)
                {
                    letterGrade += "-";
                }
            }
            else if (numericalGrade >= 70)
            {
                numericalGrade -= 70;
                letterGrade = "C";

                if (numericalGrade > 7)
                {
                    letterGrade += "+";
                }
                else if (numericalGrade <= 3)
                {
                    letterGrade += "-";
                }
            }
            else if (numericalGrade >= 60)
            {
                numericalGrade -= 60;
                letterGrade = "D";
                if (numericalGrade > 7)
                {
                    letterGrade += "+";
                }
                else if (numericalGrade <= 3)
                {
                    letterGrade += "-";
                }
            }
            else
            {
                letterGrade = "F";

            }


            //letterGrade = "Grade " + letterGrade;
            Console.WriteLine(letterGrade);

            return letterGrade;
        }

    } // class
} //namespace
