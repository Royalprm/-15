using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упражнение_15
{
	internal class Program
	{
		public static void Main()
		{
			ArithProgression ob = new ArithProgression();
			for (int i = 0; i < 5; i++)
			Console.WriteLine("Следующее значение = " + ob.GetNext());
			Console.WriteLine("\nПереход в исходное состояние.");

			
			Console.Write("Для завершения нажмите любую клавишу на клавиатуре");
			Console.ReadKey();
		}
	}
	interface ISeries
	{
		void SetStart(int x);
		int GetNext();
		void Reset();
	}

	class ArithProgression : ISeries
	{
		int start = 0;
		int val = 0;
		

		public void SetStart(int x) 
		{
			x = Convert.ToInt32(Console.ReadLine());
		}

		public int GetNext() 
		{
			val += 2;
			return val;
		}

		public void Reset() 
		{
			val = start;
		}

			
	}

	class GeomProgression : ISeries
	{
		int difference = 5;
		int x = 0;

		public GeomProgression()
		{
			x = Convert.ToInt32(Console.ReadLine());
		}

		public void SetStart(int x) 
		{
			x = Convert.ToInt32(Console.ReadLine());
		}

		public int GetNext() 
		{
			int secondNumber = x * difference;
			return secondNumber;
		}

		public void Reset() 
		{
			int firstNumber = x / difference;
		}
	}
}



