using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
	class Shape
	{
		private List<Точка> list = new List<Точка>();
		public Shape(Точка[] p)
		{
			for (int i = 0; i < p.Length; i++)
			{
				list.Add(p[i]);
			}
		}
		public Точка [] getТочка()
		{
			return list.ToArray();
		} 
	}
}
