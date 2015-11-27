using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QLNet;

namespace RiskMonitor
{
    public class PathPayoff
    {
        public virtual string name() { throw new NotImplementedException(); }
        public virtual string description() { throw new NotImplementedException(); }

        public virtual double value(IPath path)
        {
            throw new NotImplementedException();
        }
    }

    public abstract class PathMultiPayoff 
    {
        public abstract string name();
        public abstract string description();
        public abstract double value(MultiPath path);
        public abstract void showView();
        public abstract double payoffValue();
    }

    //public class ConstPayoff : PathMultiPayoff 
    //{
    //    private double constValue_;

    //    public ConstPayoff(double constValue) 
    //    {
    //        this.constValue_ = constValue;
    //    }

    //    public override string name()
    //    {
    //        return "Const Payoff";
    //    }

    //    public override string description()
    //    {
    //        return "description";
    //    }

    //    public double value(MultiPath path)
    //    {
    //        return constValue_;
    //    }




    //    public override void showView()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public override double payoffValue()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}   
}
