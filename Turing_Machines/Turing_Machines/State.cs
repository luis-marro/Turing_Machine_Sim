using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing_Machines
{
    class State
    {
        public byte name;
        public bool isAcceptance;

        public State(byte name, bool isAcceptance)
        {
            this.name = name;
            this.isAcceptance = isAcceptance; 
            // TODO EVERYTHING!! :') 
        }
    }
}
