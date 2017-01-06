using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Junk
{
	class ComplexNumbers
	{
		/// <summary>
		/// real attribute
		/// </summary>
		private int real;
		/// <summary>
		/// imaginary attribute
		/// </summary>
		private int imaginary;

		/// <summary>
		/// Default Constructor
		/// </summary>
		/// <param name="real"></param>
		/// <param name="imaginary"></param>
		public ComplexNumbers(int real, int imaginary)
		{
			this.real = real;
			this.imaginary = imaginary;
		}
		/// <summary>
		/// Real property getter & setter
		/// </summary>
		public int Real
		{
			get
			{
				return real;
			}
			set
			{
				real = value;
			}
		}
		/// <summary>
		/// Imaginary Property getter & setter
		/// </summary>
		public int Imaginary
		{
			get
			{
				return imaginary;
			}

			set
			{
				imaginary = value;
			}
		}
		/// <summary>
		/// A method "ToString", which would return "(2,-3)" 
		/// </summary>
		/// <returns>(real,imagginary)</returns>
		public override string ToString()
		{
			return "(" + Real + "," + Imaginary + ")";
		}
		/// <summary>
		/// A method "GetMagnitude" to return the magnitude of the complex number 
		/// (square root of a2+b2) 
		/// </summary>
		/// <returns>magnitude of the complex number</returns>
		public double GetMagnitude()
		{
			return Math.Sqrt( (double)(Real * Real) + (double)(Imaginary * Imaginary) );
		}
		
		public int Add (ComplexNumbers c2)
		{
			// to be implemented
			return 1;
		}
	}
}
