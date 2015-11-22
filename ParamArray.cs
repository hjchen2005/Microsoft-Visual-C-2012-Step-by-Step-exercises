using System;

namespace OOP
{
	public class ParamArray
	{
		public static void VarArgs(int val1, params int[] vals){
			foreach (int i in vals){
				Console.WriteLine("vals[]:{0}", vals[]);	
			}
			Console.WriteLine();
		}

	}
}
