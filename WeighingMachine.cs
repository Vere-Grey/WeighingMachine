using System;

class WeighingMachine
{
    private readonly int precision;
    private double weight;

    public WeighingMachine(int precision) => this.Precision = precision;

    public int Precision
    {
        get => precision;
        private init
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

    public double TareAdjustment { get; set; } = 5;
}
