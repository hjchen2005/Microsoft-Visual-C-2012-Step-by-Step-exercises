/*
Example Usage: 
ArraySorting[] arr = {
  new ArraySorting("Tiffany"),
  new ArraySorting("Carson"),
  new ArraySorting("Kenneth")
};
Array.Sort(arr);
*/

using System;
usibg System.NotImplementedException;

public class ArraySorting : IComparable {
  public ArraySorting(){}
  public ArraySorting(string s){
    name = s;
  }
  string name;
  
  public int CompareTo(object obj){
    ArraySorting arr = obj as ArraySorting;
    if (arr==null){
      throw NotImplementedException;
    }
    return this.Name.CompareTo(arr.Name);
  }
}
