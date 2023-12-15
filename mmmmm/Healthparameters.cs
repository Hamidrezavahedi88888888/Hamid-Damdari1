using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



      public class Healthparameters<T>
    {
    public string Name { get; set; }
    public T Current { get; set; }
    public T Standard { get; set; }
    public override string ToString()
    {
        var thealth = $"{Name}+{Current}+{Standard}";
        return thealth.ToString() ;
        
    }

}

