/*A checked statement is a block preceded by the checked keyword. 
All integer arithmetic in a checked statement always throws an 
OverflowException if an integer calculation in the block overflows*/

using System;
using System.OverflowException;

namespace ErrMgmt{
  public class CheckedUnchecked
	{
			static void Main(string[] args){
				int num = int.MaxValue;
				checked{
					//Only integer arithmetic directly inside the checked block is subject to overflow checking
					int willThrow =num++; 
				}
				unchecked{
					try{
						int wontThrow = num++;
					} catch (OverflowException e){
						Console.WriteLine("Error: ",e.Message);
					}
				}
			} 
		}
}
