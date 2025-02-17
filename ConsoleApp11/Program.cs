using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static List<int> grades = new List<int>();

        static void Main()
        {
            while (true)
            {//display options
                Console.WriteLine("\nWelcome to Grade Management application");
                Console.WriteLine("1. Add Grade");
                Console.WriteLine("2. Remove Grade");
                Console.WriteLine("3. Display Grades");
                Console.WriteLine("4. Calculate Average");
                Console.WriteLine("5. Find Highest & Lowest Grade");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();//ties inputs to methods
                switch (choice)
                {
                    case "1":
                        AddGrade();
                        break;
                    case "2":
                        RemoveGrade();
                        break;
                    case "3":
                        DisplayGrades();
                        break;
                    case "4":
                        CalculateAverage();
                        break;
                    case "5":
                        FindHighestAndLowest();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        static void AddGrade()//method to add grades
        {
            Console.Write("Enter the grade to add: ");
            if (int.TryParse(Console.ReadLine(), out int grade) && grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
                Console.WriteLine("Grade added successfully");
            }
            else
            {
                Console.WriteLine("Invalid input. Grade must be between 0 and 100.");
            }
        }

        static void RemoveGrade()//method to remove grades
        {
            Console.Write("Enter the grade to remove: ");
            if (int.TryParse(Console.ReadLine(), out int grade) && grades.Contains(grade))
            {
                grades.Remove(grade);
                Console.WriteLine("Grade removed successfully.");
            }
            else
            {
                Console.WriteLine("Grade not found");
            }
        }

        static void DisplayGrades()//method to display grades
        {
            if (grades.Count == 0)
            {
                Console.WriteLine("No grades to display.");
                return;
            }
            Console.WriteLine("Grades: " + string.Join(", ", grades));
        }

        static void CalculateAverage()//calculate the average of the grades
        {
            if (grades.Count == 0)
            {
                Console.WriteLine("No grades available to calculate average.");
                return;
            }
            double average = grades.Average();
            Console.WriteLine("Average grade: {average:F2}");
        }

        static void FindHighestAndLowest()//Gets the min and max of the grades
        {
            if (grades.Count == 0)
            {
                Console.WriteLine("No grades available.");
                return;
            }
            Console.WriteLine("Highest Grade: " + grades.Max());
            Console.WriteLine("Lowest Grade: " + grades.Min());
        }
    }

}
