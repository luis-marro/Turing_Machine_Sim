using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Turing_Machines
{
    public class TuringMachine
    {
        // Array to store all the transitions 
        protected State[] allStates;
        // List to store all the movements 
        public List<char> headMovements;
        // List to represent the tape 
        public List<char> tape;
        // List to store the state history
        public List<string> history;
        // The machine's current state 
        protected State actual;

        public TuringMachine(int size)
        {
            tape = new List<char>();
            headMovements = new List<char>();
            allStates = new State[size];
            history = new List<string>();
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
