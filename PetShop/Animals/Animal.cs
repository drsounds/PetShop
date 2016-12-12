using System;
using System.Diagnostics;

namespace PetShop
{
	namespace Animals
	{
		public abstract class Animal : IProduct
		{
			public int Weight { get; set; }
			public int Length { get; set; }
			public decimal Price { get; set; }
			public void Walk()
			{
				Debug.WriteLine("Animal is walking");
			}
			public void Eat(string food)
			{
				Debug.WriteLine("Eating");
			}
			public Animal(int weight, int length, decimal price)
			{
				Weight = weight;
				Length = length;
				Price = price;
			}
		}
	}
}
