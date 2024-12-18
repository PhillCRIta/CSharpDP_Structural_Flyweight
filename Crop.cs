using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Flyweight
{
	internal class Crop
	{
		private int _x;//4 bytes
		private int _y;//4 bytes
					   //X and Y can change in time >> EXTRINSIC STATE
		private CropIcon _cropIcon;
		public Crop(int x, int y,  CropIcon cropIcon)
		{
			_x = x;
			_y = y;
			_cropIcon = cropIcon;
		}

		public void Render()
		{
			Console.WriteLine($"I'm drawing {_cropIcon.GetType()} at {_x} {_y}");
		}
	}
}
