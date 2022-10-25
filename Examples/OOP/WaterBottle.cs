
namespace OOP
{
    // Class name is always noun
    public class WaterBottle
    {
        //private double waterAmount; // Field
        //public double waterAmount;
        private double waterAmount;
        //public string color;
        private string color;
        private double capacity;
        public bool IsOpen { get; set; }

        // Constructor
        public WaterBottle(string color, double capacity)
        {
            this.color = color;
            if (capacity <= 100)
            {
                this.capacity = 100;
            }
            else this.capacity = capacity;
        }

        // Get color
        //public string GetColor()
        //{
        //    return color;
        //}

        // Get Color using property
        // Property
        public string Color
        {
            get
            {
                return color;
            }
        }

        //private void AddWater(double amount)
        //{
        //    waterAmount += amount;
        //}

        // Add water using method
        public void AddWater(double amount)
        {
            waterAmount += amount;
        }

        // Set and get water amount using property
        // Property

        public double WaterAmount
        {
            get
            {
                if (waterAmount <= 0) return 0;
                else if (waterAmount > capacity) return capacity;
                else return waterAmount;
            }
            set
            {
                if (value > 0 && value < capacity)
                {
                    waterAmount = value;
                }
            }
        }

        //public bool IsOpen
        //{
        //    get
        //    {
        //        return isOpen;
        //    }
        //    set { isOpen = value; }
        //}
    }
}
