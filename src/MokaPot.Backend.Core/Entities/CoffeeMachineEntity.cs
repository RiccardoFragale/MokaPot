namespace MokaPot.Backend.Core.Entities
{
    /// <summary>
    /// DDD object.
    /// </summary>
    public class CoffeeMachineEntity
    {
        public int CoffeeQty { get; set; }
        public int WaterQty { get; set; }
        public int BlastTime { get; set; }
        public bool IsClean { get; set; }

        public CoffeeMachineEntity()
        {
            IsClean = true;
        }

        public bool GetWater(int ml = 25)
        {
            bool result = ml <= 100;
            result = result && ml > 0;

            if (result)
            {
                WaterQty = ml;
            }

            return result;
        }

        public bool SetCoffee(int grams = 6)
        {
            IsClean = false;
            bool result = grams <= 10;
            result = result && grams > 0;

            if (result)
            {
                CoffeeQty = grams;
            }

            return result;
        }

        public bool SteamBlast(int seconds = 2)
        {
            bool isValidBlast = seconds <= 10;
            isValidBlast = isValidBlast && seconds > 0;

            if (isValidBlast)
            {
                BlastTime = seconds;
            }

            if (isValidBlast && seconds > 5)
            {
                IsClean = true;
            }

            return isValidBlast;
        }


        public bool IsReadyForEspresso()
        {
            bool isSuccessful = CoffeeQty > 0;
            isSuccessful = isSuccessful && (WaterQty > 0);

            return isSuccessful;
        }


        public bool IsReadyForSteamBlast()
        {
            bool isSuccessful = (WaterQty > 0);
            isSuccessful = isSuccessful && (BlastTime > 0);

            return isSuccessful;
        }
    }
}
