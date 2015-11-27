using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.IO;
using AvalonDock.Layout;

namespace RiskMonitor
{
    public abstract class InstrumentTemplate
    {
        public string Path_ { get; set; }
        public string Type_ { get; set; }
        public string ItemCode_ { get; set; }
        public FileInfo FileInfo_ { get; set; }

        public abstract LayoutDocument documentView();
        public abstract InstrumentBaseViewModel instrumentBaseVM();

        public abstract void saveFile();
    }
}
