using System;
namespace PetShop
{
	namespace Animals
	{
		public enum Gender
		{
			Male, Female
		}
		/// <summary>
		/// Däggdjur. This class is abstract since mammal is a type of animal
		/// </summary>
		public abstract class Mammal : Animal
		{
			public Mammal(Gender gender, int weight, int length, decimal price) : base(weight, length, price)
			{
				Gender = gender;
			}
			public Gender Gender { get; set; }
			public Mammal(int weight, int length, decimal price) : this(new Random().Next(0, 1) == 1 ? Gender.Male : Gender.Female, weight, length, price)
			{

			}
			public Mammal(Gender gender) : this(gender, 22, 22, 22)
			{
			}

			/// <summary>
			/// Random gender
			/// </summary>
			public Mammal() : this(22, 22, 22)
			{
				
			}
		}
	}
}
