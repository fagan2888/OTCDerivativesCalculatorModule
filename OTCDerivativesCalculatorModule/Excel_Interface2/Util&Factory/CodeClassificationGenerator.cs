using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class CodeClassificationGenerator
    {
        private Dictionary<string, string> codeMap_ = new Dictionary<string, string>();

        public CodeClassificationGenerator()
        { 
            // codeMap_ load
            this.loadCodeMap();
        }

        private void loadCodeMap()
        {
            this.codeMap_.Clear();

            //this.codeMap_.Add("111", "STEPDOWNKICUSTOM");
            //this.codeMap_.Add("222", "IRS");
            //this.codeMap_.Add("230", "CRS");
            //this.codeMap_.Add("333", "FIXEDBOND");
            //this.codeMap_.Add("111", "STEPDOWNKICUSTOM");
            //this.codeMap_.Add("111", "STEPDOWNKICUSTOM");
            //this.codeMap_.Add("111", "STEPDOWNKICUSTOM");
            //this.codeMap_.Add("111", "STEPDOWNKICUSTOM");

        }

        public static string CreateTradeID() 
        {
            string id = "tradeID_";

            // db를 떠서 최대값?

            id = id + Guid.NewGuid().ToString();

            return id;
        }

        public static string CreateItemCode(string classType)
        {
            string id = "itemCode_";
            string dateSerial = DateTime.Now.ToString("yyMMddHHmmfffffff");

            // db를 떠서 최대값?
            if (classType.ToUpper() == "STEPDOWNKICUSTOM")
            {
                id = id + "111_" + dateSerial;
            }
            else if (classType.ToUpper() == "IRS")
            {
                id = id + "222_" + dateSerial;
            }
            else if (classType.ToUpper() == "CRS")
            {
                id = id + "230_" + dateSerial;
            }
            else if (classType.ToUpper() == "FIXEDBOND")
            {
                id = id + "333_" + dateSerial;
            }
            else if (classType.ToUpper() == "VANILLAFLOATINGBOND")
            {
                id = id + "334_" + dateSerial;
            }
            else if (classType.ToUpper() == "STRUCTUREDBOND")
            {
                id = id + "340_" + dateSerial;
            }
            else if (classType.ToUpper() == "COMPOSITEOPTION")
            {
                id = id + "444_" + dateSerial;
            }
            else if (classType.ToUpper() == "MULTIASSETCOMPOSITEOPTION")
            {
                id = id + "450_" + dateSerial;
            }
            else if (classType.ToUpper() == "FXFORWARD")
            {
                id = id + "500_" + dateSerial;
            }
            else if (classType.ToUpper() == "FXSWAP")
            {
                id = id + "501_" + dateSerial;
            }
            else if (classType.ToUpper() == "STRUCTUREDSWAP")
            {
                id = id + "600_" + dateSerial;
            }
            else if (classType.ToUpper() == "CDS")
            {
                id = id + "601_" + dateSerial;
            }
            else if (classType.ToUpper() == "HIFIVE")
            {
                id = id + "700_" + dateSerial;
            }
            else if (classType.ToUpper() == "GENERAL")
            {
                id = id + "000_" + dateSerial;
            }

            else
            {
                id = id + "999_" + dateSerial;
            }

            return id;            
        }

        public static Excel_instrumentViewModel CreateInstrument(string itemCode)
        {
            string[] sp = itemCode.Split('_');

            string typeNum = sp[1];

            if (typeNum == "700")
            {
                Excel_instrumentViewModel e_ivm = new Excel_instrument_hifiveViewModel();
                return e_ivm;
            }
            else if (typeNum == "333")
            {
                Excel_instrumentViewModel e_ivm = new Excel_instrument_fixedBondViewModel();
                return e_ivm;
            }
            else if (typeNum == "340")
            {
                Excel_instrumentViewModel e_ivm = new Excel_instrument_structuredBondViewModel();
                return e_ivm;
            }
            else if (typeNum == "444")  
            {
                Excel_instrumentViewModel e_ivm = new Excel_instrument_compositeOptionViewModel();
                return e_ivm;
            }
            else if (typeNum == "450")
            {
                Excel_instrumentViewModel e_ivm = new Excel_instrument_multiAssetCompositeOptionViewModel();
                return e_ivm;
            
            }
            else if (typeNum == "600")
            {
                Excel_instrumentViewModel e_ivm = new Excel_instrument_structuredSwapViewModel();
                return e_ivm;
            }
            else if (typeNum == "700")
            {
                Excel_instrumentViewModel e_ivm = new Excel_instrument_hifiveViewModel();
                return e_ivm;
            }

            else
            {
                Excel_instrumentViewModel e_ivm = new Excel_instrument_generalViewModel();
                return e_ivm;
            }

        }
    }
}
