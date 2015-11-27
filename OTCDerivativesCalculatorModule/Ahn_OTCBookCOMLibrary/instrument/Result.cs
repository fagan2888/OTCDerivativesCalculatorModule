using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel_Interface;
using System.Runtime.InteropServices;

namespace Ahn_OTCBookCOMLibrary
{

    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class Result
    {
        private string value_;
        [ComVisible(false)]
        private Excel_resultViewModel ResultVM_;

        public Result()
        {
            this.value_ = "0.0";
        }

        public Result(Excel_resultViewModel excel_resultViewModel)
        {
            
            // TODO: Complete member initialization
            this.value_ = "0.0";
            this.ResultVM_ = excel_resultViewModel;
        }

        public string get_value()
        {
            return this.value_;
        }

        private string infoParsing(string str, InfoType infoType)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                if (infoType == InfoType.Header)
                {
                    string[] split = str.Split(';');

                    foreach (var item in split)
                    {
                        int equalCount = item.IndexOf('=');

                        if (item != "")
                        {
                            sb.Append(item.Substring(0, equalCount) + ";");
                        }

                    }

                }
                else if (infoType == InfoType.Value)
                {
                    string[] split = str.Split(';');

                    foreach (var item in split)
                    {
                        int equalCount = item.IndexOf('=');

                        if (item != "")
                        {

                            sb.Append(item.Substring(equalCount + 1, item.Length - (equalCount + 1)) + ";");
                        }

                    }
                }
                else if (infoType == InfoType.Header_Value)
                {
                    sb.Append(str);
                }
                else
                {

                }

                return sb.ToString();

            }
            catch (Exception e)
            {
                return "add fail : " + e.Message;
            }
        }

        public int get_underlyingGreekResultNum()
        {
            try
            {
                int count = this.ResultVM_.Excel_greekResultViewModel_.Excel_greekUnderlyingViewModel_.Count;

                return count;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int get_cashFlowResultNum()
        {
            try
            {
                int count = this.ResultVM_.Excel_cashFlowsResultViewModel_.Excel_cashFlowResultViewModel_.Count;

                return count;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int get_valueResultNum()
        {
            try
            {
                int count = this.ResultVM_.Excel_valueResultViewModel_.Excel_valueSideResultViewModel_.Count;

                return count;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public string get_valueInfo(ResultSide side, InfoType infoType)
        {
            try
            {
                string vba_desc = "";

                if (side == ResultSide.Pay)
                {
                    vba_desc = ResultVM_.vba_description(1);
                }
                else if (side == ResultSide.Receive)
                {
                    vba_desc = ResultVM_.vba_description(2);
                }
                else
                {
                    vba_desc = ResultVM_.vba_description(0);
                }

                return this.infoParsing(vba_desc, infoType);
            }
            catch (Exception e)
            {
                return "not implemented : " + e.Message;
            }
        }

        public string get_underlyingGreekInfo(int underCount, InfoType infoType)
        {
            try
            {
                string vba_desc = ResultVM_.Excel_greekResultViewModel_.Excel_greekUnderlyingViewModel_[underCount].vba_description();

                return this.infoParsing(vba_desc, infoType);
            }
            catch (Exception e)
            {
                return "not implemented : " + e.Message;
            }
        }

        public string get_underlyingGreekPositionInfo(int underCount, InfoType infoType)
        {
            try
            {
                string vba_desc = ResultVM_.Excel_greekResultViewModel_.Excel_greekUnderlyingViewModel_[underCount].vba_description_greekPositionCalc(ResultVM_.Notional_);

                return this.infoParsing(vba_desc, infoType);
            }
            catch (Exception e)
            {
                return "not implemented : " + e.Message;
            }
        }

        public string get_cashFlowInfo(int cashFlowCount, InfoType infoType)
        {
            try
            {
                string vba_desc = ResultVM_.Excel_cashFlowsResultViewModel_.Excel_cashFlowResultViewModel_[cashFlowCount].vba_description();

                return this.infoParsing(vba_desc, infoType);
            }
            catch (Exception e)
            {
                return "not implemented : " + e.Message;
            }
        }

        public void load_result(string itemCode,DateTime refDate)
        {
            //try
            //{

            //    ResultVM_.loadResult(itemCode, refDate);

            //    Excel_instrumentViewModel e_i_hvm = MasterInformationViewModel.loadInstrumentVM(itemCode);

            //    //this.InstVM_ = new Excel_instrument_hifiveViewModel();
            //    this.InstVM_ = e_i_hvm as Excel_instrument_structuredSwapViewModel;

            //    if (this.InstVM_ == null)
            //        throw new Exception("instrument is not structuredSwap type");

            //    this.InstVM_.loadInterfaceVMFromXml(XMLFileLoader.LoadInstrument(itemCode));

            //    this.swapInterfaceVM_ = this.InstVM_.Excel_interfaceViewModel_ as Excel_structuredSwapViewModel;

            //    this.ErrLog_.add("load complete");
            //}
            //catch (Exception e)
            //{
            //    this.ErrLog_.add("load err : " + e.Message);
            //}
        }
    }
}
