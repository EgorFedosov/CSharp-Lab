using System;

namespace Pet_3    
{
    enum Type { car, truck, airplane, train, ship }
    abstract class Transport
    {
        protected string name;
        protected bool isAvailable;
        protected int speed;
        protected Type type;

        public abstract void drive();

        public virtual void setValue(string name, bool isAvailable, int speed, Type type)
        {
            this.name = name;
            this.isAvailable = isAvailable;
            this.speed = speed;
            this.type = type;
            
        }
        public abstract void print();
    }
}