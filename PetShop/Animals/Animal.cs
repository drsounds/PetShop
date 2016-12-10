using System;
namespace PetShop
{
	namespace Animals
	{
		public abstract class Animal : IProduct
		{
			public int Weight { get; set; }
			public int Length { get; set; }
			public decimal Price { get; set; }
			public Animal(int weight, int length, decimal price)
			{
				Weight = weight;
				Length = length;
				Price = price;
			}
		}
	}
}
