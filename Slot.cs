using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasinoWeb
{
	public class Slot
	{

		public int GenerateRandomNo()
		{
		    int min = 1;
		    int max = 9;

            Random _rdm = new Random();
			return _rdm.Next(min, max);
		}
	}
}
