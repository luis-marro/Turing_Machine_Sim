using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing_Machines
{
    /// <summary>
    /// Turing machine to copy a patter of abc's 
    /// </summary>
    public class TuringMachineCopy : TuringMachine
    {
        /// <summary>
        /// Machine's constructor, rules are defined here. More on them in the diagrams. 
        /// </summary>
        public TuringMachineCopy() : base(18)
        {
            // Fill the states with the transitions 
            Transition[] stateP = new Transition[]
            {
                new Transition(1, 'c', 'R', 'c'), new Transition(1, 'a', 'R', 'a'), new Transition(1, 'b', 'R', 'b'), 
            };
            State q = new State(0, false, stateP);
            allStates[0] = q; // save 0
            actual = q; 
            stateP = new Transition[]
            {
                new Transition(1, 'c', 'R', 'c'), new Transition(1, 'a', 'R', 'a'), new Transition(1, 'b', 'R', 'b'), 
                new Transition(2, 'y', 'L', 'B') 
            };
            q = new State(1, false, stateP);
            allStates[1] = q; // save 1 

            stateP = new Transition[]
            {
                new Transition(2, 'c', 'L', 'c'), new Transition(2, 'a', 'L', 'a'), new Transition(2, 'b', 'L', 'b'), 
                new Transition(3, 'B', 'R', 'B') 
            };
            q = new State(2, false, stateP);
            allStates[2] = q; // save q2

            stateP = new Transition[]
            {
                new Transition(4, 'c', 'R', 'c'), new Transition(4, 'a', 'R', 'a'), new Transition(4, 'b', 'R', 'b'),
            };
            q = new State(3, false, stateP);
            allStates[3] = q; // save 3 

            stateP = new Transition[]
            {
                new Transition(5, 'x', 'R', 'a'), new Transition(7, 'x', 'R', 'b'), new Transition(9, 'x', 'R', 'c'), 
                new Transition(11, 'y', 'L', 'y')
            };
            q = new State(4, false, stateP);
            allStates[4] = q;  // save 4

            stateP = new Transition[]
            {
                new Transition(5, 'c', 'R', 'c'), new Transition(5, 'a', 'R', 'a'), new Transition(5, 'b', 'R', 'b'), 
                new Transition(5, 'y', 'R', 'y'), new Transition(6, 'a', 'L', 'B')  
            };
            q = new State(5, false, stateP);
            allStates[5] = q; // save 5 
            
            stateP = new Transition[]
            {
                new Transition(6, 'c', 'L', 'c'), new Transition(6, 'a', 'L', 'a'), new Transition(6, 'b', 'L', 'b'),
                new Transition(6, 'y', 'L', 'y'), new Transition(6, 'a', 'R', 'x') 
            };
            q = new State(6, false, stateP);
            allStates[6] = q;  // save 6

            stateP = new Transition[]
            {
                new Transition(7, 'c', 'R', 'c'), new Transition(7, 'a', 'R', 'a'), new Transition(7, 'b', 'R', 'b'),
                new Transition(7, 'y', 'R', 'y'), new Transition(9, 'b', 'L', 'B')
            };
            q = new State(7, false, stateP);
            allStates[7] = q; // save 7

            stateP = new Transition[]
            {
                new Transition(8, 'c', 'L', 'c'), new Transition(8, 'a', 'L', 'a'), new Transition(8, 'b', 'L', 'b'),
                new Transition(8, 'y', 'L', 'y'), new Transition(4, 'b', 'R', 'x')
            };
            q = new State(8, false, stateP);
            allStates[8] = q; // save 8 

            stateP = new Transition[]
            {
                new Transition(9, 'c', 'R', 'c'), new Transition(9, 'a', 'R', 'a'), new Transition(9, 'b', 'R', 'b'),
                new Transition(9, 'y', 'R', 'y'), new Transition(10, 'c', 'L', 'B')
            };
            q = new State(9, false, stateP);
            allStates[9] = q; // save 9

            stateP = new Transition[]
            {
                new Transition(10, 'c', 'L', 'c'), new Transition(10, 'a', 'L', 'a'), new Transition(10, 'b', 'L', 'b'),
                new Transition(10, 'y', 'L', 'y'), new Transition(4, 'c', 'R', 'x')
            };
            q = new State(10, false, stateP); 
            allStates[10] = q; // save 10 

            stateP = new Transition[]
            {
                new Transition(11, 'a', 'L', 'a'), new Transition(11, 'b', 'L', 'b'), new Transition(11, 'c', 'L', 'c'),
                new Transition(12, 'B', 'R', 'B')  
            };
            q = new State(11, false, stateP);
            allStates[11] = q; // save 11

            stateP = new Transition[]
            {
                new Transition(13, 'a', 'R', 'a'), new Transition(14, 'b', 'R', 'b'), new Transition(15, 'c', 'R', 'c'), 
            };
            q = new State(12, false, stateP);
            allStates[12] = q; // save 12 

            stateP = new Transition[]
            {
                new Transition(13, 'a', 'R', 'a'), new Transition(13, 'b', 'R', 'b'), new Transition(13, 'c', 'R', 'a'), 
                new Transition(16, 'a', 'R', 'y') 
            };
            q = new State(13, false, stateP);
            allStates[13] = q; // save 13 

            stateP = new Transition[]
            {
                new Transition(14, 'a', 'R', 'a'), new Transition(14, 'b', 'R', 'b'), new Transition(14, 'c', 'R', 'a'), 
                new Transition(16, 'b', 'R', 'y') 
            };
            q = new State(14, false, stateP);
            allStates[14] = q; // save 14 

            stateP = new Transition[]
            {
                new Transition(15, 'a', 'R', 'a'), new Transition(15, 'b', 'R', 'b'), new Transition(15, 'c', 'R', 'a'),
                new Transition(16, 'c', 'R', 'y')  
            };
            q = new State(15, false, stateP);
            allStates[15] = q; // save 15

            stateP = new Transition[]
            {
                new Transition(16, 'a', 'R', 'a'), new Transition(16, 'b', 'R', 'b'), new Transition(16, 'c', 'R', 'a'),
                new Transition(17, 'B', 'L', 'B')  
            };
            q = new State(16, false, stateP);
            allStates[16] = q; // save 16

            q = new State(17, true);
            allStates[17] = q;
        }
    }
}
