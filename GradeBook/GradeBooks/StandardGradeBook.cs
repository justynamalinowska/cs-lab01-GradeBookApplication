using System;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
	public class StandardGradeBook : BaseGradeBook
	{
		public string Name { get; set; }
		public GradeBookType Type { get; set; }

		public StandardGradeBook(string name) : base(name)
		{
			Type = GradeBookType.Standard;

        }
	}
}

