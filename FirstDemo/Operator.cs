﻿using System;

public class Operator
{
	public Operator()
	{
		decimal num1, num2, res;
		Console.WriteLine("Enter First Number : ");
		num1 = Convert.ToDecimal(Console.Read());

		Console.WriteLine("Enter Second Number : ");
		num2 = Convert.ToDecimal(Console.Read());

		res = num1 + num2;
		Console.WriteLine("The result is : {0}", res);
	}
}