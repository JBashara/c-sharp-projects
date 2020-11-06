using System;

public class RingMaster : ClothingMaster, IReporter
{
    protected string name, message;
    protected int clothingAmount;

    public RingMaster(string name, int clothingAmount) : base(name, clothingAmount)
    {
        this.clothingAmount = clothingAmount;
        this.name = name;
    }

    public string Report()
    {
        return message = name + " is wearing " + clothingAmount + " rings.";
    }
}
