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

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5 )
            {
                throw new InvalidOperationException();
            }
            Students.OrderBy(s => s.AverageGrade);
            var studentRankSize = Students.Count / 5;
            int studentIndex = -1;
            for (int i = 0; i < Students.Count; i++)
            {
                if(Students[i].AverageGrade == averageGrade)
                {
                    studentIndex = i;
                    break;
                }
            }
            if (studentIndex <= 5 * studentRankSize && studentIndex > 4 * studentRankSize) { return 'A'; }
            if (studentIndex <= 4 * studentRankSize && studentIndex > 3 * studentRankSize) { return 'B'; }
            if (studentIndex <= 3 * studentRankSize && studentIndex > 2 * studentRankSize) { return 'C'; }
            if (studentIndex <= 2 * studentRankSize && studentIndex > 1 * studentRankSize) { return 'D'; }

            return 'F';
        }
    }
}
