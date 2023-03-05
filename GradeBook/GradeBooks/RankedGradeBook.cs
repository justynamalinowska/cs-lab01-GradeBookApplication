using System;
using System.Linq;
using System.Xml.Linq;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
	public class RankedGradeBook : BaseGradeBook
    {
		public RankedGradeBook(string name) : base(name)
        {
			Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            //int counter = 0;
            int N = (int)Math.Ceiling(0.2 * Students.Count);
            var sortedAverages = Students.OrderByDescending(s => s.AverageGrade).Select(s => s.AverageGrade).ToList();

            if (Students.Count < 5)
            {
                throw new InvalidOperationException("Program requires a minimum 5 students");
            }

            for (int i = 0; i < sortedAverages.Count; i += N)
            {
                if (i + N > sortedAverages.Count)
                {
                    N = sortedAverages.Count - i;
                }

                if (averageGrade >= sortedAverages[i])
                {
                    return 'A';
                }
                else if (averageGrade >= sortedAverages[i + N])
                {
                    return 'B';
                }
                else if (averageGrade >= sortedAverages[i + (N * 2)])
                {
                    return 'C';
                }
                else if (averageGrade >= sortedAverages[i + (N * 3)])
                {
                    return 'D';
                }
                else if (averageGrade >= sortedAverages[i + (N * 4)])
                {
                    return 'F';
                }  
            }
            return 'F';
        }

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
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
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else
            {
                base.CalculateStudentStatistics(name);
            }
        }
    }
}

