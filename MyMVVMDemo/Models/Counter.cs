using MyMVVMDemo.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMVVMDemo.Models
{
	class Counter : BaseINotify
	{
		private int contador;
		public int Contador
        {
        	get { return contador; }
        	set { contador = value; OnPropertyChange("Contador"); }
        }
    }
}
