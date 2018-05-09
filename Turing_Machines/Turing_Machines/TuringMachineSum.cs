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
    public class TuringMachineSum
    {
        // Array to store all the transitions 
        private State[] allStates; 
        // List to store all the movements 
        public List<char> headMovements; 
        // List to represent the tape 
        public List<char> tape;
        // List to store the state history
        public List<string> history; 
        // The machine's current state 
        private State actual; 

        /// <summary>
        /// Constructor for turing machine to perform unary sum. Check diagram for states information. 
        /// </summary>
        public TuringMachineSum()
        {
            tape = new List<char>();
            headMovements = new List<char>(); 
            allStates = new State[6];
            history = new List<string>(); 
            // fill the states with their transitions 
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

        /// <summary>
        /// Public method that evaluates the input to get sum result 
        /// </summary>
        /// <param name="symbols"></param>
        /// <returns></returns>
        public bool evaluateInput(char[] symbols)
        {
            // initialize the position and the tape 
            int position = 0; 
            tape.AddRange(symbols); 
            history.Add("q0");
            // infinite loop until the input is processed
            while (true)
            {
                // see if the actual state contains a transition with the current symbol. 
                if (allStates[actual.name].checkTransition(tape[position]))
                {
                    Transition temp; 
                    if (allStates[actual.name].allTransitions != null)
                        temp = allStates[actual.name].allTransitions[tape[position]];
                    else if (allStates[actual.name].transition != null)
                        temp = allStates[actual.name].transition; 
                    else 
                        temp = new Transition(5, '1', 'L', '1'); // unreachable case to avoid compilation errors
                    actual = allStates[temp.nextState];
                    history.Add("q" + actual.name.ToString());  
                    if (actual.isAcceptance)
                        return true;
                    tape[position] = temp.replacement;
                    if (temp.movement == 'R')
                    {
                        position++;
                        headMovements.Add('R');
                    }
                    if (temp.movement == 'L')
                    {
                        position--;
                        headMovements.Add('L'); 
                    }
                    // Check if a position should be added to tape for semi infinity chacarteristic
                    if (tape.Count == position)
                        tape.Add('B');
                }
                // The current state doesn't have a transition for the symbol, reject the input and exit 
                else
                    return false; 
            }
        }
    }
}
