using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block3
{
    //We changed the word class to enum
    //if we wanted to use this in another project, it would need to be public.
    internal enum ClassicMonsters
    {
        //No spaces, single words only, comma separated.
        Frankenstein, //0
        Cthulu, //1
        Dracula, //2
        Chupacabra, //etc
        Sasquatch,
        Zombie,
        Troll,
        Orc
    }
}
