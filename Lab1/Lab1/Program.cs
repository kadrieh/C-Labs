using System;

namespace Lab1
{
    abstract class ThreeDShape
    {
        public string type;
     
        public String Type()
        {
            return type;
        }
        public ThreeDShape(string type)
        {
            this.type = type;
        }

        public abstract double CalVolume();

        public override String ToString()
        {
            return "Shape: " + Type() + "\n";
        }
    }
}
