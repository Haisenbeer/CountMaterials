using System;

namespace CountMaterials
{
    public static class Calculation
    {
        public static int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            float productCoef;
            float materialCoef;

            switch (productType)
            {
                case 1: productCoef = 1.1f; break;
                case 2: productCoef = 2.5f; break;
                case 3: productCoef = 8.43f; break;
                default: return -1;
            }

            switch (materialType)
            {
                case 1: materialCoef = 1.003f; break;
                case 2: materialCoef = 1.0012f; break;
                default: return -1;
            }

            if (count <= 0 || width <= 0 || length <= 0)
            {
                return -1;
            }

            try
			{
                return (int)Math.Ceiling(productCoef * materialCoef * count * width * length);
			}
			catch (Exception)
			{
                return -1;
			}
        }
    }
}
