// <copyright file="Basics.cs" company="Christoph Perger">
// Copyright (c) Christoph Perger. All rights reserved.
// </copyright>

namespace MathPack
{
	using System;

	public static class Basics
	{
		public static int Sum(int a, int b)
		{
			return a + b;
		}

		public static int Diff(int a, int b)
		{
			return a - b;
		}

		public static int Multi(int a, int b)
		{
			return a * b;
		}

		public static int Div(int a, int b)
		{
			if (b == 0)
			{
				throw new ArithmeticException("No div by 0!");
			}

			return a / b;
		}
	}
}