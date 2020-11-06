using System;

public class PantsMaster : ClothingMaster, IReporter
{
    protected string name, message;
    protected int clothingAmount;

    public PantsMaster(string name, int clothingAmount) : base(name, clothingAmount)
    {
        this.clothingAmount = clothingAmount;
        this.name = name;
    }

    public string Report()
    {
        return message = name + " is wearing " + clothingAmount + " pants.";
    }
}
