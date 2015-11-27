using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace Excel_Interface
{
    public class Excel_generalParaViewModel : Excel_parameterViewModel
    {
        public Excel_generalParaViewModel()
        {
            this.Excel_resultViewModel_ = new Excel_resultViewModel();

            //this.view_ = new Excel_generalParaView();
            //this.view_.DataContext = this;
        }

        public override void instrumentEventObserver(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public override void masterEventObserver(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public override void buildXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }

        public override void buildPricingXml(System.Xml.XmlWriter xmlWriter)
        {
            throw new NotImplementedException();
        }

        public override void setFromXml(System.Xml.XmlNode node)
        {
            throw new NotImplementedException();
        }

        public override void setFromSerial(FpmlSerializedCSharp.ISerialized serial_Class)
        {
            throw new NotImplementedException();
        }

        public override System.Windows.Controls.Control view()
        {
            Control v = new Excel_generalParaView();

            v.DataContext = this;

            return v;
        }

        public override void dicountCurveEventObserver(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }



        public override void loadMarketData(DateTime referenceDate)
        {
            
        }

        public override void buildParaSetting(ParameterSettingManager paraSettingManager)
        {
            throw new NotImplementedException();
        }
    }
}
