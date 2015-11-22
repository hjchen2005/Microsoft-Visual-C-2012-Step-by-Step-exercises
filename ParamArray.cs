using System;

namespace OOP
{
	public class ParamArray
	{

                ParaArray(){
                        VarArgs(12,13,14,15,16);
                }
		public static void VarArgs(int val1, params int[] vals){
			foreach (int i in vals){
				Console.WriteLine("vals[]:{0}", vals[]);	
			}
			Console.WriteLine();
		}

	}
}
