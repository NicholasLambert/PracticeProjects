using System;

namespace ClassPractice
{
	class Program {
		static int Main() {
			//tests
			Person person1 = new Person ("Nicholas", 20);
			person1.setBirthdate (8, 7, 1995);

			Console.WriteLine (person1.getName ());
			Console.WriteLine(person1.getBirthdate ());

			//pet tests
			Pets pet1 = new Pets();
			pet1.setPetName ("Rusty");
			pet1.setPetType ("Dog");

			Console.WriteLine(pet1.getPetType() + ": " + pet1.getPetName());
			return 0;
		}
	}//end program
}
