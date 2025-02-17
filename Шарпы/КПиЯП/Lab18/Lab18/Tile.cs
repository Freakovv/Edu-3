[Serializable]
public class Tile
{
    private double size1;
    private double size2;
    private double pricePerSquareMeter;
    private double stockSquareMeters;

    public string Name { get; set; }

    public double Size1
    {
        get => size1;
        set
        {
            if (value <= 0) throw new ArgumentException("Размер 1 должен быть положительным.");
            size1 = value;
        }
    }

    public double Size2
    {
        get => size2;
        set
        {
            if (value <= 0) throw new ArgumentException("Размер 2 должен быть положительным.");
            size2 = value;
        }
    }

    public string Color { get; set; }

    public string Finish { get; set; } // Мат/глянец

    public double PricePerSquareMeter
    {
        get => pricePerSquareMeter;
        set
        {
            if (value <= 0) throw new ArgumentException("Цена должна быть положительной.");
            pricePerSquareMeter = value;
        }
    }

    public string Country { get; set; }

    public double StockSquareMeters
    {
        get => stockSquareMeters;
        set
        {
            if (value < 0) throw new ArgumentException("Запас не может быть отрицательным.");
            stockSquareMeters = value;
        }
    }

    public string TileCode { get; set; }

    public override string ToString()
    {
        return $"{Name} ({Size1}x{Size2}, {Color}, {Finish}, {Country}, {StockSquareMeters} м², {PricePerSquareMeter} руб/м²)";
    }

}