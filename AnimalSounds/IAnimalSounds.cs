﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds {

	public interface ISounds {
		string GetName();
		string ToPrint();
		string GetSound();
	}
}
