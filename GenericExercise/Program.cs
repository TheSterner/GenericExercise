using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExercise
{
	public class Program
	{
		static void Main(string[] args)
		{
			Employee<string> employee = new Employee<string>();
			Employee<int> employeeId = new Employee<int>();
			employee.Things = new List<string>() { "Blake", "Bob", "Barry", "Jason" };
			employeeId.Things = new List<int>() { 5, 6, 7, 8, };

			for (int i = 0; i < employee.Things.Count; i++)
			{
				Console.WriteLine("Name : " + employee.Things[i] + " and your Id Number is :" + employeeId.Things[i]);
			}

			Console.ReadLine();
			//public void PrinttoConsole()
			//{
			//	foreach (string name in employee.Things )
			//	{
					


			//	}
			//}

		}
	}
}
