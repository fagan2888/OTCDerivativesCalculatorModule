using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public static class OutputLogViewModel
    {

        public static ObservableCollection<IOutput> OutputList_ 
        { get; set; }

        public static void addResult(IOutput output)
        {
            //OutputList_.Add(output);
            OutputList_.Insert(0, output);
            //outputEvent(output);
        }

        //private static event OutputAdd outputEvent;
        //public delegate void OutputAdd(IOutput output);

        //public static void registerLogView(OutputAdd output) { outputEvent += output; }


        public static void addResult(string str)
        {
            IOutput output = new MessageOutput(str);
            OutputList_.Insert(0, output);
            //outputEvent(output);
        }

        public static void clear()
        {
            OutputList_.Clear();
        }

        public static void initialize() 
        {
            OutputList_ = new ObservableCollection<IOutput>();
        }

        




    }
}
