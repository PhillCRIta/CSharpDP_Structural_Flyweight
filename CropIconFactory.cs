using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Flyweight
{
	internal class CropIconFactory
	{
		//this is a cache
		private Dictionary<CropType, CropIcon> _icons = new Dictionary<CropType, CropIcon>();
		public CropIcon GetCropIcon(CropType cropType)
		{
			if (_icons.ContainsKey(cropType) == false)
			{
				//if not exixts , create new
				var icon = new CropIcon(cropType, null);
				Console.WriteLine("I'm loading icon for: " + cropType);
				_icons.Add(cropType, icon);
			}
			return _icons[cropType];
		}
	}
}
