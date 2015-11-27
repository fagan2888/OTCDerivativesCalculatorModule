using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class Excel_parameterLoader
    {
        public static Excel_parameterViewModel Load(string type)
        {
            if (type.ToUpper() == "STEPDOWNKI" || 
                type.ToUpper() == "STEPDOWNKICUSTOM" ||
                type.ToUpper() == "MULTIASSETCOMPOSITEOPTION" ||
                type.ToUpper() == "STRUCTUREDBOND")
            {
                return new Excel_standardParaViewModel();
            }
            else if (type.ToUpper() == "HIFIVE")
            {
                return new Excel_standardHifiveParaViewModel();
            }
            else if (type.ToUpper() == "CDS")
            {
                return new Excel_standardCreditParaViewModel();
            }
            else if (type.ToUpper() == "IRS" ||
                     type.ToUpper() == "STRUCTUREDSWAP")
            {
                return new Excel_standardSwapParaViewModel();
            }

            else if (type.ToUpper() == "COMPOSITEOPTION")
            {
                return new Excel_singleAssetCompositeOptionStandParaWithEngineViewModel();
            }
            else
            {
                return new Excel_generalParaViewModel();
            }
        }

        public static Excel_parameterViewModel Load(string type, string tradeID)
        {
            Excel_parameterViewModel e_pvm = new Excel_generalParaViewModel();

            return e_pvm;
        }

    }

}
