using System;
using System.Resources;
using System.Text;

public class Battery
{
    private string type;
    private float hours;

    public Battery(string type) 
    {
        this.Type = type;
    }

    public Battery(string type, float hours) : this(type)
    {
        this.Hours = hours;
    }

    public string Type
    {
        get { return this.type; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("The type is invalid!");
            }
            this.type = value;
        }
    }

    public float Hours
    {
        get { return this.hours; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("The hours cannot be negative!");
            }
            this.hours = value;
        }
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        if (this.Type != null)
        {
            result.AppendLine("battery: " + this.Type);
        }
        if (this.Hours > 0)
        {
            result.AppendLine("battery life : " + this.Hours + "hours");
        }
        return result.ToString();
    }
}

public class Laptop
{
    private string model;
    private string manufacturer;
    private string processor;
    private string ram;
    private string hdd;
    private string graphicsCard;
    private Battery battery;
    private string screen;
    private decimal price;

    public Laptop(string model, decimal price)
    {
        this.Model = model;
        this.Price = price;
    }

    public Laptop(string model, decimal price, string manufacturer = null, string processor = null, string ram = null,
        string hdd = null, string graphicsCard = null, Battery battery = null, string screen = null)
        : this(model, price)
    {
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.Ram = ram;
        this.Hdd = hdd;
        this.GraphicsCard = graphicsCard;
        this.Battery = battery;
        this.Screen = screen;
    }
    public string Model
    {
        get { return this.model; }
        set
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Invalid model!");
            this.model = value;
        }
    }
    public string Manufacturer
    {
        get { return this.manufacturer; }
        set
        {
            if (value != null && value.Length < 1) throw new ArgumentException("Invalid manufacturer!");
            this.manufacturer = value;
        }
    }
    public string Processor
    {
        get { return this.processor; }
        set
        {
            if (value != null && value.Length < 1) throw new ArgumentException("Invalid processor!");
            this.processor = value;
        }
    }
    public string Ram
    {
        get { return this.ram; }
        set
        {
            if (value != null && value.Length < 1) throw new ArgumentException("Invalid RAM!");
            this.ram = value;
        }
    }
    public string Hdd
    {
        get { return this.hdd; }
        set
        {
            if (value != null && value.Length < 1) throw new ArgumentException("Invalid HDD!");
            this.hdd = value;
        }
    }
    public string GraphicsCard
    {
        get { return this.graphicsCard; }
        set
        {
            if (value != null && value.Length < 1) throw new ArgumentException("Invalid Graphics Card!");
            this.graphicsCard = value;
        }
    }
    public Battery Battery
    {
        get { return this.battery; }
        set { this.battery = value; }
    }
    public string Screen
    {
        get { return this.screen; }
        set
        {
            if (value != null && value.Length < 1) throw new ArgumentException("Invalid Screen!");
            this.screen = value;
        }
    }
    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (value < 0) throw new ArgumentNullException("Invalid price");
            this.price = value;
        }
    }
 public override string ToString()
    {
        StringBuilder laptopStr = new StringBuilder();
        laptopStr.AppendLine("model: " + this.Model);
        if (this.Manufacturer != null)
        {
            laptopStr.AppendLine("manufacturer: " + this.Manufacturer);
        }
        if (this.Processor != null)
        {
            laptopStr.AppendLine("processor: " + this.Processor);
        }
        if (this.Ram != null)
        {
            laptopStr.AppendLine("RAM: " + this.Ram);
        }
        if (this.Hdd != null)
        {
            laptopStr.AppendLine("HDD: " + this.Hdd);
        }
        if (this.Screen != null)
        {
            laptopStr.AppendLine("screen: " + this.Screen);
        }
        if (this.Battery != null)
        {
            laptopStr.Append(this.Battery.ToString());
        }
        laptopStr.AppendLine("price: " + this.Price + "lv.");

        return laptopStr.ToString();
    }
}

class LaptopShopClass
{
    static void Main()
    {
        Battery lion = new Battery("Li-Ion, 4-cells, 2550 mAh");
        Battery nicd = new Battery("Ni-Cd", (float)4.5);
        Laptop first = new Laptop("Lenovo Yoga 2 Pro", (decimal)869.88, "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", "8 GB", "128GB SSD", "Intel HD Graphics 4400", lion, "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display");
        Laptop second = new Laptop("Aspire E3-111-C5GL", (decimal)259.49);
        Laptop third = new Laptop("Acer some model", (decimal)1567.43, battery: nicd, processor: "3.2 GHz", ram: "16 GB");

        Console.WriteLine(first.ToString());
        Console.WriteLine();
        Console.WriteLine(second.ToString());
        Console.WriteLine();
        Console.WriteLine(third.ToString());
    }
}

