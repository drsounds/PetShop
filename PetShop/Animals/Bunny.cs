using System;
using PetShop.Animals;

namespace PetShop
{
	namespace Animals
	{
		public class Bunny : Mammal
		{
			public string Color { get; set; }
			public string Race { get; set; }
			public string Order { get; set; }
			public Bunny(int width, int weight, decimal price) : base(width, weight, price)
			{

			}
			public Bunny() : this(22, 22, 240)
			{

			}
		}
	}
}
