// Implementation of adding Complex numbers
using System;

public class OverloadAddOperator {
	double real=0; // Originally it's a struct, and structs cannot instance field initializers
	double imaginary=0;

	// default constructor
	public OverloadAddOperator(double real, double imaginary){
		this.real = real;
		this.imaginary = imaginary;
	}

	// In case of 2 complex numbers add each other
	static public OverloadAddOperator Add(OverloadAddOperator lhs, OverloadAddOperator rhs){
		return new OverloadAddOperator(lhs.real + rhs.real, lhs.imaginary+lhs.imaginary);
	}

	// in case of a complex number adding a double
	static public OverloadAddOperator Add (OverloadAddOperator lhs, double rhs){
		return new OverloadAddOperator (rhs+lhs.real,lhs.imaginary);
	}

	// Also in case of a complex number adding a double
	static public OverloadAddOperator Add (double lhs, OverloadAddOperator rhs){
		return new OverloadAddOperator (rhs.real+lhs,rhs,imaginary);
	}
}
