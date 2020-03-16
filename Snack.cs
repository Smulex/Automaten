using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    public class Snack
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private double price;

		public double Price
		{
			get { return price; }
			set { price = value; }
		}

		public Snack(string name, double price)
		{
			this.name = name;
			this.price = price;
		}
	}
}
