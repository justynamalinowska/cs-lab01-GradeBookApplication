using System;
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
	}
}

