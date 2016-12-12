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

			/// <summary>
			/// Initializes a new instance of the <see cref="T:PetShop.Animals.Bunny"/> class. 	
			/// I have different constructors, one with zero arguments for easier instanciation	
			/// </summary>
			public Bunny() : this(22, 22, 240)
			{

			}
		}
	}
}
