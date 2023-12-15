using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class SheepParameter
{
    public Healthparameters<double> TimeToStand = new Healthparameters<double>()
    {
        Name = "TimeToStand",
        Current = 8,
        Standard = 11
    };
    public Healthparameters<double> NumberOfMilkProduction = new Healthparameters<double>()
    {   //bar hasb litr
        Name = "NumberOfMilkProduction",
        Current = 72,
        Standard = 86
    };
    public Healthparameters<double> NumberOfMeal = new Healthparameters<double>()
    {   //bar hasb tedad vade
        Name = "NumberOfMeal",
        Current = 3,
        Standard = 4
    };

    public Healthparameters<double> TimeToRelax = new Healthparameters<double>()
    {   //bar hasb clock
        Name = "TimeToRelax",
        Current = 4,
        Standard = 5
    };
    public Healthparameters<double> TimeToDeal = new Healthparameters<double>()
    {   //bar hasb clock
        Name = "TimeToDeal",
        Current = 8,
        Standard = 10
    };
    public DateOnly date = new DateOnly();
    public override string ToString()
    {
        var tcowparameter = $"Stand Time:{TimeToStand} TimeToDeal{TimeToDeal} TimeToRelax{TimeToRelax} NumberOfMilkProduction{NumberOfMilkProduction} NumberOfMeal{NumberOfMeal} {date}  ";
        return tcowparameter.ToString();

    }
}

