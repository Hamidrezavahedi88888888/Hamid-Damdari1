using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class Cow:IComparable, IEnumerable 
{
    public DateOnly BirthDate { get; init; }
    static readonly int Maxlife = 25;
    static int GetMaxlife() => Maxlife;
    public List<AEnviroment> enviroments;
    public static string Name;
    public List<CowParameter> cowparameters;
    int IComparable.CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}   

