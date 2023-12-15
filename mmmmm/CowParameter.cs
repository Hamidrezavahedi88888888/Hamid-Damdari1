using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;



    public  class CowParameter
    {
    public Healthparameters<double> TimeToStand = new Healthparameters<double>()
     {
        Name = "TimeToStand",
        Current = 6, 
        Standard = 10   
     };
    public Healthparameters<double> NumberOfMilkProduction = new Healthparameters<double>()
    {   //bar hasb litr
        Name = "NumberOfMilkProduction",
        Current = 200,
        Standard = 670
    };
    public Healthparameters<double> NumberOfMeal = new Healthparameters<double>()
    {   //bar hasb tedad vade
        Name = "NumberOfMeal",
        Current = 8,
        Standard = 10
    };

    public Healthparameters<double> TimeToRelax = new Healthparameters<double>()
    {   //bar hasb clock
        Name = "TimeToRelax",
        Current = 2,
        Standard = 4
    };
    public Healthparameters<double> TimeToDeal = new Healthparameters<double>()
    {   //bar hasb clock
        Name = "TimeToDeal",
        Current = 6,
        Standard = 9
    };
    public DateOnly date = new DateOnly();
    public override string ToString()
    {
        var tcowparameter = $"Stand Time:{TimeToStand} TimeToDeal{TimeToDeal} TimeToRelax{TimeToRelax} NumberOfMilkProduction{NumberOfMilkProduction} NumberOfMeal{NumberOfMeal} {date}  ";
        return tcowparameter.ToString();

    }
}

