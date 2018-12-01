using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name):base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5 )
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return; 
            }
            else
            {
                base.CalculateStatistics();
            }
          
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }
            else
            {
                base.CalculateStudentStatistics(name);
            }         
        }
        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5 )
            {
                throw new InvalidOperationException();
            }
            Students.Sort();
            Students.Reverse();

            var studentRankSize = Students.Count / 5;

            if (averageGrade >= Students[(studentRankSize*1)-1].AverageGrade )
                return 'A';
            else if (averageGrade >= Students[(studentRankSize * 2) - 1].AverageGrade)
                return 'B';
            else if (averageGrade >= Students[(studentRankSize * 3) - 1].AverageGrade)
                return 'C';
            else if (averageGrade >= Students[(studentRankSize * 4) - 1].AverageGrade)
                return 'D';
            else
            return 'F';
        }
    }
}
