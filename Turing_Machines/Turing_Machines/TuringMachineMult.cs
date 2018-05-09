using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing_Machines
{
    public class TuringMachineMult : TuringMachine
    {
        public TuringMachineMult() : base(9)
        {
            // Fill the states with their transitions 
            Transition state0 = new Transition(1, 'x', 'R', '1'); 
            State q = new State(0, false, state0);
            allStates[0] = q; 

        }
    }
}
