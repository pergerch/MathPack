// <copyright file="Basics.cs" company="Christoph Perger">
// Copyright (c) Christoph Perger. All rights reserved.
// </copyright>

namespace MathPack
{
	using System;
	using NumSharp;

	public static class Basics
	{
		public static int Numerics()
		{
			NDArray nd = np.full(5, 12); //[5, 5, 5 .. 5]
			nd = np.zeros(12); //[0, 0, 0 .. 0]
			nd = np.arange(12); //[0, 1, 2 .. 11]
			return nd.ndim;
		}

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