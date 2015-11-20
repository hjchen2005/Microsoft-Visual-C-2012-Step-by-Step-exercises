using System;
using System.ArgumentOutOfRangeException;

namespace ErrMgmt{
	public class ThrowException{
		public static void Main (string[] args){
			Console.WriteLine(nameOfMonth(13));
		}
		
		public static string nameOfMonth(int month){
			case 1:
				return "January";
			// if month<1 or month>12, method shouldn't return anything
			// Similar scenario: "Attenders must be 21 or above" etc
			default:
			//exceptions caused by invalid arguments that are not null
				throw new ArgumentOutOfRangeException("Not a month");
		}
	}
}
