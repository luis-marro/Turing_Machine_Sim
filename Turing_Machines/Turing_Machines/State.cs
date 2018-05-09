using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing_Machines
{
    internal class State
    {
        public int name;
        public bool isAcceptance;
        public Dictionary<char, Transition> allTransitions;
        public Transition transition; 

        /// <summary>
        /// Builder to instantiate a state that has multiple transitions
        /// </summary>
        /// <param name="name"> state name, it is the name number </param>
        /// <param name="isAcceptance">The state should accept and string</param>
        /// <param name="machineTransitions">All the transitions a single state may have </param>
        public State(int name, bool isAcceptance, Transition[] machineTransitions)
        {
            this.name = name;
            this.isAcceptance = isAcceptance;
            allTransitions = new Dictionary<char, Transition>(); 

            // Fill the dictionary 
            for (int i = 0; i < machineTransitions.Length; i++)
            {
                allTransitions.Add(machineTransitions[i].readChar, machineTransitions[i]); 
            }
        }

        /// <summary>
        /// Builder to generate an state with a single transition, eliminates need to have a dictionary 
        /// </summary>
        /// <param name="name">State name as an int</param>
        /// <param name="isAcceptance">Whether the state represents acceptance of the string</param>
        /// <param name="machineTransitions">Single transition of the machine</param>
        public State(int name, bool isAcceptance, Transition machineTransitions)
        {
            this.name = name;
            this.isAcceptance = isAcceptance;
            transition = machineTransitions; 
        }

        /// <summary>
        /// Constructor for acceptance states with no transitions 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="isAcceptance"></param>
        public State(int name, bool isAcceptance)
        {
            this.name = name;
            this.isAcceptance = isAcceptance;
        }

        internal bool checkTransition(char symbol)
        {
            if (allTransitions == null && transition == null)
                return false; 
            else if (allTransitions == null && transition != null)
            {
                if (transition.readChar == symbol)
                    return true; 
            }
            else if (allTransitions != null)
            {
                if (allTransitions.ContainsKey(symbol))
                    return true; 
            }
            return false; 
        }

    }
}
