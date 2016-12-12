using System;
using System.Diagnostics;
using PetShop.Animals;

namespace PetShop
{
	public class MainClass
	{
		static AnimalShop shop = new AnimalShop();
		private static void BuyAnimal(string animal)
		{
			
			Debug.WriteLine("Buying a " + animal);
				
			Animal _animal = shop.SellAnimal(animal);
			switch (animal)
			{
				case "cat":
					Cat cat = (Cat)_animal;

					Debug.WriteLine("Gender: " + cat.Gender.ToString());
					Debug.WriteLine("Race: " + cat.Race);
					Debug.WriteLine("Taxonomy: " + cat.Taxonomy);
					Debug.WriteLine("Weight: " + cat.Weight);

					break;
				case "dog":
					Dog dog = (Dog)_animal;

					Debug.WriteLine("Gender: " + dog.Gender);
					Debug.WriteLine("Color: " + dog.Color);
					Debug.WriteLine("Race: " + dog.Race);
					Debug.WriteLine("Length: " + dog.Length);
					Debug.WriteLine("Origin: " + dog.Origin);
					Debug.WriteLine("Weight: " + dog.Weight);
					break;
				case "bunny":
					Bunny bunny = (Bunny)_animal;

					Debug.WriteLine("Gender: " + bunny.Gender);
					Debug.WriteLine("Color: " + bunny.Color);
					Debug.WriteLine("Race: " + bunny.Race);
					Debug.WriteLine("Length: " + bunny.Length);
					Debug.WriteLine("Order: " + bunny.Order);
					Debug.WriteLine("Weight: " + bunny.Weight);
					break;
				default:
					Debug.WriteLine("Unfortunately, " + animal + " is not available for sale");
					return;

			}
			Debug.WriteLine("Brought a " + animal);
		}
		public static void Main(string[] args)
		{
			Debug.WriteLine(String.Format("Shop cashier is empty: {0}", shop.Money == 0));
			BuyAnimal("cat");
			BuyAnimal("dog");
			BuyAnimal("bunny");
			BuyAnimal("rat");
			BuyAnimal("bird");
			Console.ReadLine();
		}
	}
}
