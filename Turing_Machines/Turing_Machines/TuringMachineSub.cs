﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing_Machines
{
    /// <summary>
    /// Implements Turing Machine for unary substraction. 
    /// </summary>
    public class TuringMachineSub : TuringMachine
    {

        /// <summary>
        /// Constructor for Unary substraction turing machine, check diagrams for information. 
        /// Initializes all the transitions and states values. 
        /// </summary>
        public TuringMachineSub() : base(10)
        {

            // Fill the states with their transitions 
            Transition state0 = new Transition(1, 'x', 'R', '1');
            State q = new State(0, false, state0);
            allStates[0] = q;
            Transition[] state1 = new Transition[]
            {
                new Transition(1, '1', 'R', '1'), new Transition(1, '-', 'R', '-'), new Transition(1, '=', 'R', '='),
                new Transition(2, '1', 'L', 'B')
            };
            q = new State(1, false, state1);
            allStates[1] = q;  // means q1 
            // Reuse q for all the others 
            state1 = new Transition[]
            {
                new Transition(2, '1', 'L', '1'), new Transition(2, '-', 'L', '-'), new Transition(2, '=', 'L', '='),
                new Transition(3, 'x', 'R', 'x') 
            };
            q = new State(2, false, state1); // means q2 
            allStates[2] = q; 
            state1 = new Transition[]
            {
                new Transition(1, 'x', 'R', '1'), new Transition(4, '-', 'R', '-')  
            };
            q = new State(3, false, state1); // means q3 
            allStates[3] = q; 
            // for q4 
            state0 = new Transition(5, 'x', 'R', '1');
            q = new State(4, false, state0);
            allStates[4] = q; 
            // for q5 
            state1 = new Transition[]
            {
                new Transition(5, '1', 'R', '1'), new Transition(5, '=', 'R', '='), new Transition(6, 'B', 'L', 'B')   
            };
            q = new State(5, false, state1);
            allStates[5] = q; 
            // for q6 
            state0 = new Transition(7, 'B', 'L', '1'); 
            q = new State(6, false, state0);
            allStates[6] = q; 
            // for q7 
            state1 = new Transition[]
            {
                new Transition(7, '1', 'L', '1'), new Transition(7, '=', 'L', '='), new Transition(8, 'x', 'R', 'x')   
            };
            q = new State(7, false, state1);
            allStates[7] = q; 
            // for q 8
            state1 = new Transition[]
            {
                new Transition(5, 'x', 'R', '1'), new Transition(9, '=', 'L', '=')  
            };
            q = new State(8, false, state1);
            allStates[8] = q; 
            // for q9
            allStates[9] = new State(9, true);

            actual = allStates[0]; 
        }

        
    }
}
