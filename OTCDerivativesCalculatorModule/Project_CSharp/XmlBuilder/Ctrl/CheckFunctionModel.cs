using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using XmlBuilder.Views.StructuredProduct.View.CheckFunctionCtrl;


namespace XmlBuilder.Ctrl
{
    public class CheckFunctionModel
    {
        private FpmlSerializedCSharp.EventFunctionM item_;

        public CheckFunctionModel(FpmlSerializedCSharp.EventFunctionM item_)
        {
            // TODO: Complete member initialization
            this.item_ = item_;
        }

        private void buildFromSerialClass()
        {
            string efType = item_.choiceStr_efType;

            if (efType == "")
            {
                DownEventCheckCtrlModel decCM = new DownEventCheckCtrlModel(item_.DownEventCheck_);
            }
            else if (efType == "")
            {
                UpEventCheckCtrlModel uecCM = new UpEventCheckCtrlModel(item_.UpEventCheck_);
            }
            else if (efType == "")
            {
                UpDownEventCheckCtrlModel udecCM = new UpDownEventCheckCtrlModel(item_.UpdownEventCheck_);
            }
            else if (efType == "")
            {
                RangeEventCheckCtrlModel recCM = new RangeEventCheckCtrlModel(item_.RangeEventCheck_);
                //indexDetailCtrl_ = new RangeEventCheckCtrl(recCM);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        private UserControl indexDetailCtrl_;


        public StringBuilder buildXml()
        {
            throw new NotImplementedException();
        }
    }
}
