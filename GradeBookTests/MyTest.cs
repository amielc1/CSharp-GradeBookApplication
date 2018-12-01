using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.GradeBooks;
using Xunit;
using System.Linq;
using GradeBook;
using GradeBook.Enums;

namespace GradeBookTests
{
    public class MyTest
    {

        //[Fact]
        //public void GradeRange()
        //{
        //    RankedGradeBook rankedGradeBook = new RankedGradeBook("Amiel");
          
      
        //    for (int i = 0; i < 10; i++)
        //        rankedGradeBook.Students.Add(new Student($"Student {i}", StudentType.Standard, EnrollmentType.Campus) {Grades = GenerateGradeList() });

        //    var gradeRank = rankedGradeBook.GetLetterGrade(rankedGradeBook.Students[5].AverageGrade);

        //}

        List<double> GenerateGradeList()
        {
            var rand = new Random();
            var gradeList = Enumerable.Repeat<double>(100, 10).ToList();
            for (int i = 0; i < gradeList.Count; i++)
                gradeList[i] *= rand.NextDouble();

            return gradeList;
        }
    }
}

