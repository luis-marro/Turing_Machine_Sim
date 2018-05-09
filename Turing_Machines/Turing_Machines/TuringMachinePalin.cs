using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Turing_Machines
{
    /// <summary>
    /// Turing machine that tells if a word made up of abc is a palindrome 
    /// </summary>
    public class TuringMachinePalin : TuringMachine
    {
        public TuringMachinePalin() : base(10)
        {
            Transition[] stateM = new Transition[]
            {
                new Transition(1, 'x', 'R', 'a'), new Transition(2, 'x', 'R', 'b'), new Transition(3, 'x', 'R', 'c')   
            };
            State q = new State(0, true, stateM);
            allStates[0] = q;
            actual = q; 
            stateM = new Transition[]
            {
                new Transition(1, 'a', 'R', 'a'), new Transition(1, 'b', 'R', 'b'), new Transition(1, 'c', 'R', 'c'),
                new Transition(4, 'B', 'L', 'B'), new Transition(4, 'x', 'L', 'x')  
            };
            q = new State(1, false, stateM);
            allStates[1] = q; // saved 1 
            stateM = new Transition[]
            {
                new Transition(2, 'a', 'R', 'a'), new Transition(2, 'b', 'R', 'b'), new Transition(2, 'c', 'R', 'c'),
                new Transition(5, 'B', 'L', 'B'), new Transition(5, 'x', 'L', 'x')
            };
            q = new State(2, false, stateM);
            allStates[2] = q; // saved 2
            stateM = new Transition[]
            {
                new Transition(3, 'a', 'R', 'a'), new Transition(3, 'b', 'R', 'b'), new Transition(3, 'c', 'R', 'c'),
                new Transition(6, 'B', 'L', 'B'), new Transition(6, 'x', 'L', 'x')
            };
            q = new State(3, false, stateM); 
            allStates[3] = q; // saved 3 
            stateM = new Transition[]
            {
                new Transition(8, 'x', 'L', 'a'), new Transition(0, 'x', 'L', 'x')
            }; 
            q = new State(4, false, stateM);
            allStates[4] = q; // save q4 
            stateM = new Transition[]
            {
                new Transition(9, 'x', 'L', 'b'), new Transition(0, 'x', 'L', 'x')
            };
            q = new State(5, false, stateM);
            allStates[5] = q; // save q5 
            stateM = new Transition[]
            {
                new Transition(7, 'x', 'L', 'c'), new Transition(0, 'x', 'L', 'x')
            };
            q = new State(6, false, stateM);
            allStates[6] = q; // save q6 

            stateM = new Transition[]
            {
                new Transition(7, 'a', 'L', 'a'), new Transition(7, 'b', 'L', 'b'), new Transition(7, 'c', 'L', 'c'), 
                new Transition(0, 'x', 'R', 'x'),  
            };

            q = new State(7, false, stateM);
            allStates[7] = q; // save q7 

            stateM = new Transition[]
            {
                new Transition(8, 'a', 'L', 'a'), new Transition(8, 'b', 'L', 'b'), new Transition(8, 'c', 'L', 'c'),
                new Transition(0, 'x', 'R', 'x'),
            };

            q = new State(8, false, stateM);
            allStates[8] = q; // save 8

            stateM = new Transition[]
            {
                new Transition(9, 'a', 'L', 'a'), new Transition(9, 'b', 'L', 'b'), new Transition(9, 'c', 'L', 'c'),
                new Transition(0, 'x', 'R', 'x'),
            };

            q = new State(9, false, stateM);
            allStates[9] = q; // save 9






        }
    }
}
