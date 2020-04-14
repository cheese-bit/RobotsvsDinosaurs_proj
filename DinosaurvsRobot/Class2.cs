using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaurvsRobot
{
    public class Dinosaur
    {
        public string robotName;
        public int healthLevel;
        public int powerLevel;
        public int attackPower;



        public Dinosaur(string name)
        {
            this.robotName = "TRex";
            healthLevel = 750;
            powerLevel = 200;
            attackPower = 20;
        }


        public Dinosaur(string name)
        {
            this.robotName = "Triceritops";
            healthLevel = 530;
            powerLevel = 225;
            attackPower = 20;
        }

        public Dinosaur(string name)
        {
            this.robotName = "Anklosaurus";
            healthLevel = 375;
            powerLevel = 100;
            attackPower = 15;
        }
    }

    {
    }
}
