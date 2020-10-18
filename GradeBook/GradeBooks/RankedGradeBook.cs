using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook: BaseGradeBook
    {
        public RankedGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Type = GradeBookType.Ranked;
        }

        public override void CalculateStatistics()
        {
            //string students1 = Convert.ToString(Students);
            int result1 = Students.Count;
            if (result1 < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else
            {
                base.CalculateStatistics();
            }
        }
        public override void CalculateStudentStatistics(string name)
        {
            //string students1 = Convert.ToString(Students);
            int result1 = Students.Count;
            if (result1 < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else
            {
                base.CalculateStudentStatistics(name);
            }
        }

        public virtual char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException();
            }
            else 
            {
                if (averageGrade >= 90)
                    return 'A';
                else if (averageGrade >= 80)
                    return 'B';
                else if (averageGrade >= 70)
                    return 'C';
                else if (averageGrade >= 60)
                    return 'D';
            }
            else
                return 'F';

        }
    }
}
