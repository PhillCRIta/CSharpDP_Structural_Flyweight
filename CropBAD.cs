using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Flyweight
{
	internal class CropBAD
	{
		private int _x;//4 bytes
		private int _y;//4 bytes
		//X and Y can change in time >> EXTRINSIC STATE
		private CropType _cropType;//4 bytes
		private byte[] _icon;//40 Kbytes  ==> became 40 MB if istantiate 1.000 crops  >> INTRINSIC STATE - remain fixed -- CONSTANT STATE, extrac in a new object
		//those last 2 fields are FLYWEIGHT OBJECT
		public CropBAD(int x, int y, CropType cropType, byte[] icon)
		{
			_x = x;
			_y = y;
			_cropType = cropType;
			_icon = icon;
		}

		public void Render()
		{
			Console.WriteLine($"I'm drawing {_cropType} at {_x} {_y}");
		}
	}
}
