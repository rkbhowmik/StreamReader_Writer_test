using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_Write_StreamReader_StreamWriter
{
	class Demo
	{
		public static void Main(string[] args)
		{
			String filePath = "test.txt";

			WriteToFile(filePath);
			ReadFromFile(filePath);
		}
		public static void ReadFromFile(string filePath)
		{
			StreamReader reader = new StreamReader(filePath);
			int count = 0;
			while (!reader.EndOfStream)
			{
				Console.WriteLine(reader.ReadLine());
				count++;
			}

			Console.WriteLine("There are {0} names in your text file", count);
			reader.Close();
		}

		public static void WriteToFile(string filePath)
		{
			StreamWriter writer = new StreamWriter(filePath, true);
			String temp = String.Empty;

			do
			{
				Console.Write("Enter a name [-1 to exit]: ");
				temp = Console.ReadLine();

				if (temp != "-1")
				{
					writer.WriteLine(temp);
				}

			} while (temp != "-1");

			writer.Close();
		}
	}
}


