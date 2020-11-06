using System;

public abstract class ClothingMaster
{
	protected string name;
	protected int clothingAmount;

	public ClothingMaster (string name, int clothingAmount)
	{
		this.name = name;
		this.clothingAmount = clothingAmount;
	}
}
