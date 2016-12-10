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
		/// Däggdjur
		/// </summary>
		public abstract class Mammal : Animal
		{
			public Gender Gender { get; set; }
			public Mammal(int weight, int length, decimal price) : base(weight, length, price)
			{
			}
		}
	}
}
