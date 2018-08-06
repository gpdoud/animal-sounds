using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds {
	class Program {
		static void Main(string[] args) {

			Dog dog = new Dog();
			Monkey monkey = new Monkey();
			Bells bell = new Bells();

			ISounds[] animals = {
				dog, monkey, bell
			};

			foreach(ISounds animal in animals) {
				string animalName = animal.GetName();
				string animalSound = animal.GetSound();
				string message = $"A(n) {animalName} says {animalSound}.";
				Console.WriteLine(message);
			}
			Console.ReadKey();
		}
	}
}
