using System;

namespace ClassPractice
{
	public class Pets
	{
		private string petName, petType;

		//pet type setter/getter
		public void setPetType(string newPetType) {
			petType = newPetType;
		}

		public string getPetType() {
			return petType;
		}

		//pet setter/getter
		public void setPetName(string newPetName) {
			petName = newPetName;
		}

		public string getPetName() {
			return petName;
		}
	}
}

