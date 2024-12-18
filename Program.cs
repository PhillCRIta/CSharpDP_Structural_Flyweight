using Structural_Flyweight;
/*
 The problem can try to resolve with Flyweight pattern is the resource consumption
 for example using a share object
In this case the icon of the same crop can be share in a unique object

THIS IS A CLIENT OBJECT
 */
CropServiceBAD cropService = new CropServiceBAD();
foreach(CropBAD crop in cropService.GetCrops())
{
	crop.Render();
}

Console.WriteLine("***********************");

CropService cropServiceFlyweight = new CropService(new CropIconFactory());
foreach (Crop crop in cropServiceFlyweight.GetCrops())
{
	crop.Render();
}