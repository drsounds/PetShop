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

			public Bunny(Gender gender, string color, string race, string order, int width) : base(gender, 22, 22, 240)
			{
				Color = color;
				Race = race;
				Order = order;
				width = 100;
			}
			public Bunny(string color, string race, string order, int width) : base(22, 22, 240)
			{
				Color = color;
				Race = race;
				Order = order;
				width = 100;
			
			}

			/// <summary>
			/// Initializes a new instance of the <see cref="T:PetShop.Animals.Bunny"/> class. 	
			/// I have different constructors, one with zero arguments for easier instanciation	
			/// </summary>
			public Bunny() : this("white", "test", "t", 222)
			{

			}

		}
	}
}
