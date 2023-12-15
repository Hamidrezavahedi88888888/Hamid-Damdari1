using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class AEnviroment
    {
    public Healthparameters<int> TDS = new Healthparameters<int>()
    {
        Name ="TDS",Current = 1380, Standard = 1402   
    };
    public Healthparameters<int> Density = new Healthparameters<int>()
    {
        Name = "Density",  Current = 14,  Standard = 15
    };
    public Healthparameters<int> Oxygen = new Healthparameters<int>()
    {
        Name = "Oxygen",Current = 35,Standard = 32 
    };
    public Healthparameters<int> AQI = new Healthparameters<int>()
    {
        Name = "Air Quality Index",Current = 80,Standard = 60   
    };
    public Healthparameters<int> Db = new Healthparameters<int>()
    {
        Name = "Db", Current = 60, Standard = 65  
    };
    public Healthparameters<int> Temp = new Healthparameters<int>()
    {
        //bar hasb c0
        Name = "Temp",Current = 28,Standard = 25
    };
    public DateOnly date = new DateOnly();
}

