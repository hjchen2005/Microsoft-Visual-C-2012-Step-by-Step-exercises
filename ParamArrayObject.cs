using System;

public class ParamArrayObject {
	public paramArrayObject(object myObject1, object myObject2,object myObject3){
		Hole(myObject1, myObject2, myObject3);
	}
	
	public void Hole(params object[] objs){
		//https://msdn.microsoft.com/en-us/library/cxt053xf(v=vs.110).aspx
		foreach (object obj in objs){
			Console.WriteLine (obj.id, "\n");
		}
	}
}
