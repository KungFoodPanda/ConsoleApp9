using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
	public class Student
	{
		private string firstname;
		private string lastname;
		private int age;

		public Student(string firstnamne, string lastname, int age)
		{
			this.firstname = firstnamne;
			this.lastname = lastname;
			this.age = age;
		}
		public string Getfullname()
		{
			return $"{firstname}{lastname}";

		}
		public bool Isadult()
		{
			return age >= 18;
		}

	}
}
