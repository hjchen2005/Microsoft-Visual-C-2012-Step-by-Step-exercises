using System;
https://github.com/hjchen2005/Microsoft-Visual-C-2012-exercises/blob/master/IInterface.cs
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
