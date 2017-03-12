using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVInterface
{
    public interface IEmployee
    {
        //cannot have fields 
        //just signature of properties
        //setting a rule or contract to be followed for implementations

        String ID
        {
            get;set;
        }
        String FirstName
        {
            get;set;
        }
        // cannot have implementation
        //cannot have modifies public 
        //etc all are assumed public 
        //cannot have virtual

        String Update();
        String Add();
        String Delete();
        String Search();
        String CalculateWage();
    }
}
