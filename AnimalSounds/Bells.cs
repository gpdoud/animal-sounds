using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds {

	public class Bells : ISounds {
		public string GetName() {
			return "Bell";
		}

		public string GetSound() {
			return "Ting";
		}

		public string ToPrint() {
			throw new NotImplementedException();
		}
	}
}
