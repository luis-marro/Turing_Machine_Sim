using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing_Machines
{
    /// <summary>
    /// Turing machine that writes the result of unary multiplication between two numbers 
    /// </summary>
    public class TuringMachineMult : TuringMachine
    {
        /// <summary>
        /// Constructor for mult turing machine. Defines the transitions. 
        /// </summary>
        public TuringMachineMult() : base(9)
        {
            // Fill the states with their transitions 
            Transition state0 = new Transition(1, 'x', 'R', '1'); 
            State q = new State(0, false, state0);
            allStates[0] = q; // save q0
            actual = allStates[0]; 
            Transition[] state1 = new Transition[]
            {
                new Transition(1, '1', 'R', '1'), new Transition(2, '*', 'R', '*')  
            };
            q = new State(1, false, state1);
            allStates[1] = q; // save state 1 
            state0 = new Transition(3, 'y', 'R', '1'); 
            q = new State(2, false, state0);
            allStates[2] = q; // save q2 
            state1 = new Transition[]
            {
                new Transition(3, '=', 'R', '='), new Transition(3, '1', 'R', '1'), new Transition(4, '1', 'L', 'B')   
            };
            q = new State(3, false, state1);
            allStates[3] = q; // save 3 
            state1 = new Transition[]
            {
                new Transition(4, '1', 'L', '1'), new Transition(4, '=', 'L', '='), new Transition(5, '1', 'R', 'y')   
            };
            q = new State(4, false, state1);
            allStates[4] = q; // save 4 
            state1 = new Transition[]
            {
                new Transition(3, 'y', 'R', '1'), new Transition(6, '=', 'L', '=')  
            };
            q = new State(5, false, state1);
            allStates[5] = q; // save q5 
            state1 = new Transition[]
            {
                new Transition(6, '1', 'L', '1'), new Transition(6, '*', 'L', '*'), new Transition(7, 'x', 'R', 'x')  
            };
            q = new State(6, false, state1);
            allStates[6] = q; // save q6
            state1 = new Transition[]
            {
                new Transition(1, 'x', 'R', '1'), new Transition(8, '*', 'L', '*')   
            };
            q = new State(7, false, state1);
            allStates[7] = q; // save 7

            allStates[8] = new State(8, true); 
        }
    }
}
