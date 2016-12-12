using System;
using PetShop.Animals;
namespace PetShop
{
	public class AnimalShop
	{
		/// <summary>
		/// We define money as private so it cannot be changed outside the class
		/// </summary>
		private decimal money;

		/// <summary>
		/// Gets the money stored in the shop
		/// </summary>
		/// <value>The money.</value>
		public decimal Money
		{
			get
			{
				return this.money;
			}
		}
		/// <summary>
		/// Deposit money to the shop's banking account
		/// </summary>
		/// <param name="amount">Amount.</param>
		private void DepositMoney(decimal amount)
		{
			money += amount;
		}

		public void SellProduct(IProduct product)
		{
			DepositMoney(product.Price);
		}

		public Animal SellAnimal(string animalType)
		{
			switch (animalType)
			{
				case "cat":
					Cat cat = new Cat(22, 22, 190);
					DepositMoney(cat.Price);
					money += cat.Price;
					return cat;
				case "dog":
					Dog dog = new Dog(22, 22, 20);
					SellProduct(dog);
					return dog;
				case "bunny":
					Bunny bunny = new Bunny();
					SellProduct(bunny);
					DepositMoney(bunny.Price);
					return bunny;
				default:
					return null;
			}
		}
	}
}
