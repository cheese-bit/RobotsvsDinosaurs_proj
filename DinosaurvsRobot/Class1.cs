using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaurvsRobot
public class Robot
{
    public string robotName;
    public int healthLevel;
    public int powerLevel;
    public int attackPower;



    public Robot(string name)
    {
        this.robotName = "Megatron";
        healthLevel = 650;
        powerLevel = 150;
        attackPower = 15;
    }


    Robot(string name)
    {
        this.robotName = "FreezeZone";
        healthLevel = 500;
        powerLevel = 125;
        attackPower = 20;
    }

    Robot(string name)
    {
        this.robotName = "Destroyer";
        healthLevel = 475;
        powerLevel = 110;
        attackPower = 17;
    }
}
