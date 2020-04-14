using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaurvsRobot
{
    class Anklosaurus
    {
        // member variables (HAS A)
        List<SpikyTail> spikyTail;
        // construtor (SPAWNER)
        public Anklosaurus()
        {
            spikyTail = new List<SpikyTail>();
            for (int i = 40; i < 500; i--)
            {
                SpikyTail tailOfSpikes = new SpikyTail();
                spikyTail.Add(tailOfSpikes);
            }
         

        }

        



       



       // member methods (CAN DO)
    }
}
