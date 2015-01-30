using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Component
{
    private string name;
    private string details;
    private decimal price;

    public Component(string name, decimal price, string details = null)
    {
        this.Name = name;
        this.Price = price;
        this.Details = details;
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("The name cannot be empty!");
            }
            this.name = value;
        }
    }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            if ((decimal)value <= 0)
            {
                throw new ArgumentOutOfRangeException("The price cannot be negative or zero!");
            }
            this.price = value;
        }
    }

    public string Details
    {
        get { return this.details; }
        set
        {
            if (value != null && value.Length < 0)
            {
                throw new ArgumentException("Invalid component!");
            }
            this.details = value;
        }
    }
}

public class Computer
{
    private string name;
    private List<Component> components = new List<Component>();
    private decimal price;

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("The name cannot be empty!");
            }
            this.name = value;
        }
    }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            if ((decimal)value <= 0) throw new ArgumentException("The price must not to be negative or zero.");
            this.price = value;
        }
    }

    public Computer(string name, Component boxPC, Component motherboard, Component hdd, Component processor,
        Component graficsCard, Component ram)
    {
        this.Name = name;
        this.components.Add(boxPC);
        this.components.Add(motherboard);
        this.components.Add(hdd);
        this.components.Add(processor);
        this.components.Add(graficsCard);
        this.components.Add(ram);

        foreach (Component component in this.components)
        {
            this.price += component.Price;
        }
    }

    public Computer(string name, Component boxPC, Component motherboard, Component hdd, Component procesor, Component graficsCard, Component ram, params Component[] componets) :
        this(name, boxPC, motherboard, hdd, procesor, graficsCard, ram)
    {
        this.components.AddRange(componets);
        foreach (Component componet in componets)
        {
            this.price += componet.Price;
        }
    }

    public override string ToString()
    {
        StringBuilder computer = new StringBuilder();
        computer.AppendLine("name: " + this.Name);
        computer.AppendLine("price: " + this.Price);
        foreach (var component in this.components)
        {
            computer.AppendLine("component name: " + component.Name + component.Price);
            computer.AppendLine("component price: " + component.Price);
        }
        return computer.ToString();
    }
}

class PCCatalog
{
    static void Main()
    {
        Component boxPC = new Component(name: "PC box Shenha V6", price: 55.20m, details: "Size: 475 x 185 x 465 cm");
        Component motherboard = new Component(name: "motherboard ASROCK FM2A88X Extreme6+", price: 188.40m);
        Component hdd = new Component(name: "disc SEAGATE 2T, ES.3, SATA III", price: 330m, details: "capacity: 2 TB");
        Component processor = new Component(name: "processor: Intel Core I3-4340", price: 316.80m);
        Component graficsCard = new Component(name: "graphics card: PALIT GeForce GT 610", price: 80.40m, details: "capacity: 1 GB");
        Component ram = new Component(name: "ram: ADATA 2X4GB", price: 171.60m, details: "description: 4G DDR3");

        Component discSSD = new Component(name: "disc A-DATA 128GB SSD", price: 127.20m, details: "description: Multi-Level Cell (MLC) NAND Flash Memory, 2.5 inch");
        Component blower = new Component(name: "blower COOLERMASTER Blade Master 80", price: 16.80m);
        Component power = new Component(name: "PSU FD 750W INTEGRA BLACK", price: 157.20m, details: "description: Multi-Level Cell (MLC) NAND Flash Memory, 2.5 inch");


        Computer computer1 = new Computer(name: "Plami", boxPC: boxPC, motherboard: motherboard, hdd: hdd, procesor: processor, graficsCard: graficsCard, ram: ram);

        Computer computer2 = new Computer("Machine", boxPC, motherboard, hdd, processor, graficsCard, ram, discSSD, blower, power);

        Computer computer3 = new Computer("AnotherModel", boxPC, motherboard, hdd, processor, graficsCard, ram, discSSD);

        List<Computer> computers = new List<Computer>() { computer2, computer1, computer3, computer1 };

        computers = computers.OrderBy(computer => computer.Price).ToList();

        foreach (var computer in computers)
        {
            Console.WriteLine(computer.ToString());
            Console.WriteLine();
        }
    }
}

