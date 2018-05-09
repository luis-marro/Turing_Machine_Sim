using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing_Machines
{
    /// <summary>
    /// Turing machine that writes the sum of two unary represented numbers 
    /// </summary>
    public class TuringMachineSum : TuringMachine
    {

        /// <summary>
        /// Constructor for turing machine to perform unary sum. Check diagram for states information. 
        /// </summary>
        public TuringMachineSum() : base(6)
        {
            Transition state0 = new Transition(1, 'x', 'R', '1');  
            State q0 = new State(0, false, state0);
            allStates[0] = q0; 
            // q1 state 
            Transition[] state1 = new Transition[] {new Transition(1, '1', 'R', '1'), new Transition(1, '+', 'R', '+'),
                new Transition(1, '=', 'R', '='), new Transition(2, '1', 'L', 'B')}; 
            State q1 = new State(1, false, state1); 
            // q2 state 
            Transition[] state2 = new Transition[]
            {
                new Transition(2, '1', 'L', '1'), new Transition(2, '+', 'L', '+'), 
                new Transition(4, '=', 'L', '='), new Transition(3, 'x', 'R', 'x'),  
            };
            State q2 = new State(2, false, state2);
            // q3 state 
            Transition[] state3 = new Transition[]
            {
                new Transition(1, 'x', 'R', '1'), new Transition(0, '+', 'R', '+'),   
            };
            State q3 = new State(3, false, state3);
            // q4 state 
            Transition[] stata4 = new Transition[]
            {
                new Transition(2, '1', 'L', '1'), new Transition(5, 'x', 'R', 'x'), 
            };
            State q4 = new State(4, false, stata4); 
            // q5 state 
            State q5 = new State(5, true); 

            // add the states 
            allStates[0] = q0;
            allStates[1] = q1;
            allStates[2] = q2;
            allStates[3] = q3;
            allStates[4] = q4;
            allStates[5] = q5;

            actual = q0; 
        }


    }
}
