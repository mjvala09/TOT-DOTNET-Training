using System;

namespace MyApplication
{
	public class Person
	{
		string name {  get; set; }
		int age { get; set; }

		public void Introduce()
		{
			Console.WriteLine("Name : " + name + "\nAge : " + age)
		}
	}
}
