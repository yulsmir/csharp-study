using System;

namespace Less01_task02
{
	class MyClass
	{
		private string name;

		public string Name
		{
			set
			{
				name = value;
			}

			get
			{
				if (name == null)
					return "Name is not defined";
				else
					return name;
			}
		}

	}
	class Program
	{
		static void Main()
		{
			MyClass myClass = new MyClass();
			Console.WriteLine(myClass.Name);
			Console.ReadKey();
		}
	}
}