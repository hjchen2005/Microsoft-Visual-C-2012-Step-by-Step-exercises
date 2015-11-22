using System;

namespace OOP
{
	public interface IInterface
	{
		void Paint();
	}

	public class Painting : IInterface{
		public void Paint(){
			Console.WriteLine("Painting");
		}

	}
}
