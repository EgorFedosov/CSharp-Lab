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

        abstract void Drive() { }

        virtual void Info() { };

    }
}