using System;
namespace PetShop
{
	namespace Animals
	{
		public class Cat : Mammal
		{
			public string Taxonomy { get; set; }
			public bool IsWild { get; set; }
			public string Race { get; set; }
			public Cat() : this(22, 22, 190)
			{
				Race = "test";
				IsWild = false;
				Taxonomy = "Z";
			}
			public Cat(int weight, int length, decimal price) : base(weight, length, price)
			{
				
			}
		}
	}
}
