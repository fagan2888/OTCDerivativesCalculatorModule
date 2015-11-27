using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class ParameterSettingManager
    {
        public DateTime ReferenceDate_;

        public int SimulationNumber_;

        public Excel_instrumentViewModel Excel_InstrumentViewModel_;

        public ParameterSettingManager(DateTime refDate, Excel_instrumentViewModel e_instVM)
        {
            this.ReferenceDate_ = refDate;
            this.Excel_InstrumentViewModel_ = e_instVM;
            e_instVM.Excel_parameterViewModel_.ParameterSettingManager_ = this;

            this.UnderlyingParaSetting_ = new UnderlyingParaSetting(this);
            this.DiscountCurveParaSetting_ = new DiscountCurveParaSetting(this);

        }

        public UnderlyingParaSetting UnderlyingParaSetting_;
        public DiscountCurveParaSetting DiscountCurveParaSetting_;


        
    }
}
