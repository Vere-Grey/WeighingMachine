using System;

class WeighingMachine
{
    private int precision;
    private double weight;
    private double tareAdjustment = 5;

    public WeighingMachine(int precision)
    {
        Precision = precision;
    }

    public int Precision
    {
        get => precision;
        set
        {
            if (value < 0) throw new ArgumentOutOfRangeException($"Precision cannot be negative {value}.");
            precision = value;
        }
    }

    public double Weight
    {
        get => weight;
        set
        {
            if (value < 0) throw new ArgumentOutOfRangeException($"Weight cannot be negative {value}.");
            weight = value;
        }
    }

    public string DisplayWeight => $"{(Weight - TareAdjustment).ToString($"f{Precision}")} kg";

    public double TareAdjustment
    {
        get => tareAdjustment;
        set => tareAdjustment = value;
    }
}
