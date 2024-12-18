using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Flyweight
{
	internal class CropService
	{
		private CropIconFactory _iconFactory;

		public CropService(CropIconFactory iconFactory)
		{
			_iconFactory = iconFactory;
		}

		public List<Crop> GetCrops()
		{

			//simulate loading crop from data source
			List<Crop> cropList = new List<Crop>();
			var carrot1 = new Crop(1, 4, _iconFactory.GetCropIcon(CropType.Carrot));
			var carrot2 = new Crop(41, 4, _iconFactory.GetCropIcon(CropType.Carrot));
			var carrot3 = new Crop(21, 4,  _iconFactory.GetCropIcon(CropType.Carrot));
			var Wheat = new Crop(3, 5,  _iconFactory.GetCropIcon(CropType.Wheat));
			var Wheat2 = new Crop(5, 7,  _iconFactory.GetCropIcon(CropType.Wheat));
			var Potato = new Crop(15, 17,  _iconFactory.GetCropIcon(CropType.Potato));
			var Potato1 = new Crop(25, 27,  _iconFactory.GetCropIcon(CropType.Potato));
			var Wheat3 = new Crop(9, 11, _iconFactory.GetCropIcon(CropType.Wheat));

			cropList.Add(carrot1);
			cropList.Add(carrot2);
			cropList.Add(carrot3);
			cropList.Add(Wheat);
			cropList.Add(Wheat2);
			cropList.Add(Potato);
			cropList.Add(Potato1);
			cropList.Add(Wheat3);

			return cropList;
		}
	}
}
