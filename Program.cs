using System;
using System.Collections.Generic;

namespace GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = gradingStudents(grades);
        }

        static List<int> gradingStudents(List<int> grades)
        {
            List<int> resList = new List<int>();
            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] >= 38)
                {
                    var temp = (grades[i] / 5) + 1;
                    var next5 = temp + 1 * 5;
                    if (next5 - grades[i] <= 2)
                        resList.Add(next5);
                    else
                        resList.Add(grades[i]);
                }
                else resList.Add(grades[i]);

            }
            return resList;


        }
    }
}
