using System;
using GraphicsExtensions; //http://stackoverflow.com/questions/1835062/drawing-circles-with-system-drawing

namespace OOP{
	{
	// Below cannot be instantiated
		public abstract class GeometricShape{
			public abstract void Draw();
		}
		public class Circle : GeometricShape{
			public void Draw(){
				GraphicsExtensions circle = new GraphicsExtensions();
				circle.DrawCircle(30,30,20);
			}
		}
	}
}
