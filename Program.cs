using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGUID
{
	class Program
	{
		static void Main(string[] args)
		{
			string g = Guid.NewGuid().ToString();
			Console.WriteLine("===============================================================================");
			Console.WriteLine("GUID: ");
			Console.WriteLine("===============================================================================");
			Console.WriteLine("");
			Console.WriteLine(g);
			Console.WriteLine("");
			Console.WriteLine("Press Any Key To Continue");
			Console.ReadKey();
		}
	}
}
