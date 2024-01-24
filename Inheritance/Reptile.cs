using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
		public Reptile()
		{
		}

		public string Color { get; set; }

		public bool CanCamouflage { get; set; } = false;

		public string Movement { get; set; }

		public double TopSpeed { get; set; }

		public void Describe(Reptile r)
		{
			Console.WriteLine($"Allow me to introduce you to a reptile named {r.Name}.");
			Console.WriteLine($"{r.Name} is a {r.Color} {r.Species} with {r.Legs} legs.");
			Console.WriteLine($"{r.Name} {(r.CanCamouflage ? "can" : "cannot")} change colors and " +
				$"{(r.LaysEggs ? "does" : "does not")} lay eggs.");
			Console.WriteLine($"A {r.Species} like {r.Name} can {r.Movement} up to {r.TopSpeed} miles per hour!");
		}
	}
}

