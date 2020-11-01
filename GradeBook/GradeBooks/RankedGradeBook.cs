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
            int result = Students.Count;
            if (result < 5)
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
            int result = Students.Count;
            if (result < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else
            {
                base.CalculateStudentStatistics(name);
            }
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException();
            }

            int i = -1;
            double count = 0;
            double range = (double)Students.Count * 20;

            foreach (var student in Students)
            {
                if ((double)student.AverageGrade >= averageGrade)
                {
                    count ++;
                    
                }
            }
            count *= 100;
            
            //double part = (count / range);
            do
            {
               i++;
            } while (i * range < count  && i <= 5);

                char studentGrade = 'F';    
                //double studentGrade = Students[count].Grades[0];
                
                    switch (i)
                    {
                        case 1:
                            studentGrade = 'A';
                            break;
                        case 2:
                            studentGrade = 'B';
                            break;
                        case 3:
                            studentGrade = 'C';
                            break;
                        case 4:
                            studentGrade = 'D';
                            break;
                        case 5:
                            studentGrade = 'F';
                            break;
                        
                    }


            return studentGrade;
        }
    }
}
