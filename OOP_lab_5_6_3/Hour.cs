using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab_5_6_3
{
	public class Hour : MetroStation
	{
		private int passengerAmount;
		private string comment;

		public Hour() { }
		public Hour(string n, int y, int passAm, string c) : base(n, y)
		{
			passengerAmount = passAm;
			comment = c;
		}

		public int GetPassengerAmount() { return passengerAmount; }
		public string GetComment() { return comment; }

		public void ReadPassAmount()
		{
			Console.WriteLine("Enter passenger amount:");
			try
			{
				passengerAmount = Convert.ToInt32(Console.ReadLine());
			}
			catch (FormatException)
			{
				Console.WriteLine("Wrong format!");
			}
		}

		public void ReadComment()
		{
			Console.WriteLine("Enter a comment:");
			comment = Console.ReadLine();
		}

		public void Output()
		{
			Console.WriteLine("Metro station name: {0}", name);
			Console.WriteLine("Year of opening: {0}", openYear);
			Console.WriteLine("Amount of passengers: {0}", passengerAmount);
			Console.WriteLine("Comment: {0}", comment);
		}
	}
}
