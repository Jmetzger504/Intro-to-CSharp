using System;

namespace Operators {

    class Robot {

        public String type;
        public int maxSpeed;

        public override bool Equals(object obj)
        {
            //Check type matches
            if(!(obj is Robot))
                return false;

            Robot otherRobot = (Robot) obj; //Explicitly cast object being compared to calling Robot as a Robot.

            //Check if the type and maxspeed of the calling Robot matches the type and maxspeed of the compared Robot.
            //i.e., check if their fields share the same values.
            if(this.type.Equals(otherRobot.type) && this.maxSpeed.Equals(otherRobot.maxSpeed))
                return true;
            else return false;
        }

    }

}