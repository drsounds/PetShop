using System;
namespace PetShop
{
	namespace Animals
	{
		public class Dog : Mammal
		{
			public string Race { get; set; }
			public string Color { get; set; }
			public string Origin { get; set; }
			public Dog(Gender gender, int weight, int length, decimal price)
				: base(gender,weight, length, price)
			{
				Race = "Labradour";
				Color = "green";
				Origin = "Africa";
			}
			public Dog(int weight, int length, decimal price)
				: base( weight, length, price)
			{
				Race = "Labradour";
				Color = "green";
				Origin = "Africa";
			}
			public Dog() : this(22, 22, 190)
			{
			}
		}
	}
}
