using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing_Machines
{
    public class Transition
    {
        public int nextState;
        public char replacement;
        public char movement;
        public char readChar; 

        public Transition(int nextState, char replacement, char movement, char readChar)
        {
            this.nextState = nextState;
            this.replacement = replacement;
            this.movement = movement;
            this.readChar = readChar; 
        }
    }
}
