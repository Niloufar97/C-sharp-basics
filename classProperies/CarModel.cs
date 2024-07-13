namespace classProperies;

public class CarModel
{
    List<string> validColors = ["blue" , "red" , "green"]; 
    public string? Name { get; set; } = "";
    public string? Manufacturer;
    public string color = string.Empty;

    public CarModel(string name, string manu, string color)
    {
        Name = name;
        Manufacturer = manu;
        Color = color;
    }

    public string Color {
        get {
            return color;        
        }
        set
        {
            if (validColors.Contains(value))
            {
                color = value;
            }
            else
            {
                color = "Not defined";
            }
        }
    }
}

