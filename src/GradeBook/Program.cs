using System;
using System.Collections.Generic;

namespace GradeBook
{

	class Program
	{
		static void Main(string[] args)
		{
			var book = new Book("Pascal Grade Book");

			book.AddGrade(89.1);
			book.AddGrade(90.5);
			book.AddGrade(77.5);

			var stats = book.GetStatistics();

			Console.WriteLine($"Moyenne = {stats.Average:N1}");
			Console.WriteLine($"Note la plus haute = {stats.High}");
			Console.WriteLine($"Note la plus basse = {stats.Low}");
		}
	}
}
