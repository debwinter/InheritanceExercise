using System;
namespace Inheritance
{
	public class Bird : Animal
	{
		public Bird()
		{
		}

		public bool CanFly { get; set; } = false;

		public string Color { get; set; }

		public bool CanSpeak { get; set; } = false;

		public string? FavoriteSaying { get; set; }

		public void Describe(Bird b)
		{
			Console.WriteLine($"Allow me to introduce you to a bird named {b.Name}.");
			Console.WriteLine($"{b.Name} is a {b.Color} {b.Species} with {b.Legs} legs.");
			Console.WriteLine($"{b.Name} {(b.CanFly ? "can" : "cannot")} fly and " +
				$"{(b.LaysEggs ? "does" : "does not")} lay eggs. " +
				$"{b.Name} {(b.CanSpeak ? "can also speak!" : "also cannot speak.")}");
			if (b.CanSpeak)
			{
				Console.WriteLine($"{b.Name}'s favorite saying is: \"{b.FavoriteSaying}\"");
			}
		}
	}
}

