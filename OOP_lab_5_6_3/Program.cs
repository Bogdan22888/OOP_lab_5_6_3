using System;
using System.Collections.Generic;

namespace OOP_lab_5_6_3
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Hour> hours = MetroStation.ReadData();

			string menu = "\nEnter:\tA - add a new item\n\tE - edit item\n\tD - delete item\n\tO - output items\n\tS - get passengers sum\n\tL - get hour with the least number of passengers\n\tW - get hour with the most words in comment\n\t0 - exit the program";
			char user2;
			do
			{
				Console.WriteLine(menu);
				user2 = Convert.ToChar(Console.ReadLine());

				switch (user2)
				{
					case 'A':
						MetroStation.AddItem(ref hours);
						break;
					case 'E':
						MetroStation.EditItem(ref hours);
						break;
					case 'D':
						MetroStation.DeleteItem(ref hours);
						break;
					case 'O':
						MetroStation.OutputList(ref hours);
						break;
					case 'S':
						int sum = MetroStation.PassengersSum(ref hours);
						Console.WriteLine("Passenger sum is: {0}", sum);
						break;
					case 'L':
						Hour leastHour = MetroStation.LeastPassengers(ref hours);
						leastHour.Output();
						break;
					case 'W':
						Hour mostWordsHour = MetroStation.MostWordsInComment(ref hours);
						mostWordsHour.Output();
						break;
					case '0':
						break;
					default:
						throw new Exception("There is no such button in menu.");
				}
			} while (user2 != '0');

			Console.ReadKey();
		}
	}
}
