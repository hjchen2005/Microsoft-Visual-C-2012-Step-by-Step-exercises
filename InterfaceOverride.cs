using System;
using OOP.IInterface;

public interface IUIControl{
	void show();
}

public class Combobox : IUIControl, IInterface{
	public void show(){
		Console.WriteLine("Show");
	}
	
	public void paint(){
		Console.WriteLine("Paint");
	}
}
