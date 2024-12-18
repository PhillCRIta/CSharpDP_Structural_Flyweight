using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Flyweight
{
	internal class CropServiceBAD
	{
		public List<CropBAD> GetCrops()
		{
			//simulate loading crop from data source
			List<CropBAD> cropList = new List<CropBAD>();
			var carrot1 = new CropBAD(1, 4, CropType.Carrot, null);
			var carrot2 = new CropBAD(21, 4, CropType.Carrot, null);
			var carrot3 = new CropBAD(41, 4, CropType.Carrot, null);
			
			cropList.Add(carrot1);
			cropList.Add(carrot2);
			cropList.Add(carrot3);

			return cropList;
		}
	}
}
