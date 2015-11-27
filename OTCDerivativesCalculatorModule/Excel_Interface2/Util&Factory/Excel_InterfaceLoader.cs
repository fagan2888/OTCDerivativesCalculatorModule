using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class Excel_InterfaceLoader
    {
        // 빈거 떨굼
        public static Excel_interfaceViewModel Load(string type)
        {
            if (type.ToUpper() == "STEPDOWNKI" || type.ToUpper() == "STEPDOWNKICUSTOM")
            {
                return new Excel_stepDownKICustomViewModel();
            }
            else if (type.ToUpper() == "COMPOSITEOPTION" ||
                     type.ToUpper() == "EXCEL_COMPOSITEOPTION")
            {
                return new Excel_compositeOptionViewModel();
            }
            else if (type.ToUpper() == "MULTIASSETCOMPOSITEOPTION" ||
                     type.ToUpper() == "EXCEL_MULTIASSETCOMPOSITEOPTION")
            {
                return new Excel_multiAssetCompositeOptionViewModel();
            }
            else if (type.ToUpper() == "FIXEDBOND" ||
                     type.ToUpper() == "EXCEL_FIXEDBOND")
            {
                return new Excel_fixedBondViewModel();
            }
            else if (type.ToUpper() == "VANILLAFLOATINGBOND" ||
                     type.ToUpper() == "EXCEL_VANILLAFLOATINGBOND")
            {
                return new Excel_vanillaFloatingBondViewModel();
            }
            else if (type.ToUpper() == "STRUCTUREDBOND" ||
                     type.ToUpper() == "EXCEL_STRUCTUREDSWAP")
            {
                return new Excel_structuredBondViewModel();
            }
            else if (type.ToUpper() == "FXFORWARD" ||
                     type.ToUpper() == "EXCEL_FXFORWARD")
            {
                return new Excel_fxForwardViewModel();
            }
            else if (type.ToUpper() == "FXSWAP" ||
                     type.ToUpper() == "EXCEL_FXSWAP")
            {
                return new Excel_fxForwardViewModel();
            }
            else if (type.ToUpper() == "FXSPOT" ||
                     type.ToUpper() == "EXCEL_FXSPOT")
            {
                return new Excel_fxSpotViewModel();
            }
            else if (type.ToUpper() == "HIFIVE" ||
                     type.ToUpper() == "EXCEL_HIFIVE")
            {
                return new Excel_hifiveViewModel();
            }
            else if (type.ToUpper() == "STRUCTUREDSWAP" ||
                     type.ToUpper() == "EXCEL_STRUCTUREDSWAP")
            {
                return new Excel_structuredSwapViewModel();
            }
            else if (type.ToUpper() == "CDS" ||
                     type.ToUpper() == "EXCEL_CDS")
            {
                return new Excel_cdsViewModel();
            }
            else if (type.ToUpper() == "IRS" ||
                     type.ToUpper() == "EXCEL_IRS")
            {
                return new Excel_irsViewModel();
            }
            else if (type.ToUpper() == "CRS" ||
                     type.ToUpper() == "EXCEL_CRS")
            {
                return new Excel_crsViewModel();
            }
                
            else 
            {
                throw new NotImplementedException();
                //return new Excel_generalViewModel();
            }
            
        }

        public static Excel_interfaceViewModel Load(string type, string tradeID)
        {
            Excel_interfaceViewModel e_ifvm = new Excel_generalViewModel();

            return e_ifvm;
        }
    }
}
