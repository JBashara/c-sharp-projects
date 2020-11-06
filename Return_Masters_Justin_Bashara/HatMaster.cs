namespace HatMaster_JustinBashara
{
    internal class HatMaster : ClothingMaster, IReporter
    {
        protected string name, message;
        protected int clothingAmount;

        public HatMaster(string name, int clothingAmount):base(name, clothingAmount)
        {
            this.clothingAmount = clothingAmount;
            this.name = name;
        }

        public string Report()
        {
            return message = name + " is wearing " + clothingAmount + " hats.";
        }
    }
}