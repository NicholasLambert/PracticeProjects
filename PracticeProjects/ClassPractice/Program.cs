using System;

namespace ClassPractice
{
	class Person {
		private string name, birthdate;
		private int day, month, year, age;

		public Person(string newName, int newAge) {
			name = newName;
			age = newAge;
		}

		public void setBirthdate(int newDay, int newMonth, int newYear) {
			day = newDay;
			month = newMonth;
			year = newYear;
			birthdate = (day + "/" + month + "/" + year);
		}

		public string getBirthdate() {
			return birthdate;
		}

		public string getName() {
			return name;
		}
	}//end person

	class Program {
		static int main() {
			Person person1 = new Person ("Nicholas", 20);
			person1.setBirthdate (8, 7, 1995);

			Console.WriteLine (person1.getName ());
			Console.WriteLine(person1.getBirthdate ());

			return 0;
		}
	}//end program
}
