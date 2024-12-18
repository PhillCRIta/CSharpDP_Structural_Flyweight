﻿namespace Structural_Flyweight
{
	internal class CropIcon
	{
		private readonly CropType _type;
		private readonly byte[] _icon;

		public CropIcon(CropType type, byte[] icon)
		{
			_type = type;
			_icon = icon;
		}

		public CropType GetType() => _type;
	}
}