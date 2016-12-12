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
			public Cat() : this("test", true, "cat")
			{
			}
			public Cat(Gender gender, string race, bool isWild, string taxonomy) : this(gender, 22, 22, 190)
			{
				Race = race;
				IsWild = isWild;
				Taxonomy = taxonomy;
			}
			public Cat(string race, bool isWild, string taxonomy) : base(22, 22, 190)
			{
				Race = race;
				IsWild = isWild;
				Taxonomy = taxonomy;
			}
			public Cat(Gender gender, int weight, int length, decimal price) : base(gender, weight, length, price)
			{
				
			}
		}
	}
}
