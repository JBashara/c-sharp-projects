using System;

public class Person : IReporter
{
    protected string name, message;
	public Person(string name)
	{
        this.name = name;
	}

    public string Report()
    {
        return message = "My name is " + name + " and I'm just happy to be here.";
    }
}
