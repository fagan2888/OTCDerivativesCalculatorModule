using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel_Interface;
using System.Runtime.InteropServices;

namespace Ahn_OTCBookCOMLibrary
{
    [ClassInterface(ClassInterfaceType.AutoDual)]
    public class Book
    {
        private BookViewModel bvm_;
        private ErrLog log_;

        public Book(BookViewModel bvm)
        {
            // TODO: Complete member initialization
            this.bvm_ = bvm;

            this.log_ = new ErrLog();

        }

        public string booking_structuredBond(Instrument_structuredBond inst_structuredBond)
        {
            try
            {
                bvm_.booking(inst_structuredBond.InstVM_);
                this.bvm_.saveBookXml();

                return "booking complete , code : " + inst_structuredBond.InstVM_.Item_code_;
            }
            catch (Exception e)
            {
                return "booking fail : " + e.Message;
            }

        }

        public string booking_hifive(Instrument_hifive inst_hifive)
        {
            try
            {
                bvm_.booking(inst_hifive.InstVM_);
                this.bvm_.saveBookXml();

                return "booking complete , itemCode : " + inst_hifive.InstVM_.Item_code_ + " , bookName : " + bvm_.BookCode_;
            }
            catch (Exception e)
            {
                return "booking fail : " + e.Message;
            }
        }

        public string booking_structuredSwap(Instrument_swap inst_structuredSwap)
        {
            try
            {
                bvm_.booking(inst_structuredSwap.InstVM_);
                this.bvm_.saveBookXml();

                return "booking complete , code : " + inst_structuredSwap.InstVM_.Item_code_;
            }
            catch (Exception e)
            {
                return "booking fail : " + e.Message;
            }

        }

        public string remove_instrument(string itemCode)
        {
            try
            {
                bool removeSuccess = this.bvm_.removeInstrument(itemCode);

                if (removeSuccess)
                {
                    return itemCode + " is unbooked.";
                }
                else 
                {
                    throw new Exception("remove fail : " + itemCode);
                }
                
            }
            catch (Exception e)
            {
                return e.Message;
            }
            
        }

        public string instrumentList(string str,bool includeChildBook = false)
        {
            try
            {
                List<Excel_instrumentViewModel> e_instVMList = new List<Excel_instrumentViewModel>();

                if (includeChildBook)
                {
                    foreach (var item in bvm_.ChildBookList_)
                    {
                        item.getInstrument(e_instVMList);
                    }
                }

                foreach (var item in bvm_.InstrumentList_)
                {
                    e_instVMList.Add(item);
                }

                StringBuilder sb = new StringBuilder();

                foreach (var item in e_instVMList)
                {
                    sb.Append(item.MasterInformationViewModel_.Item_code_);
                    sb.Append("|");
                }
                
                return sb.ToString();
            }
            catch (Exception e)
            {
                return "booking fail : " + e.Message;
            }
        }

        public string[] instrumentList2(string str, bool includeChildBook = false)
        {
            List<string> instInfoList = new List<string>();

            try
            {
                List<Excel_instrumentViewModel> e_instVMList = new List<Excel_instrumentViewModel>();

                if (includeChildBook)
                {
                    foreach (var item in bvm_.ChildBookList_)
                    {
                        item.getInstrument(e_instVMList);
                    }
                }

                foreach (var item in bvm_.InstrumentList_)
                {
                    e_instVMList.Add(item);
                }

                StringBuilder sb = new StringBuilder();

                foreach (var item in e_instVMList)
                {
                    instInfoList.Add(item.MasterInformationViewModel_.Item_code_);
                }

                return instInfoList.ToArray();
            }
            catch (Exception e)
            {
                instInfoList.Add("booking fail : " + e.Message);

                return instInfoList.ToArray();
            }
        }

        public string get_instrumentInfo(InfoType infoType, bool includeChildBook = false)
        {
            try
            {
                List<Excel_instrumentViewModel> e_instVMList = new List<Excel_instrumentViewModel>();

                if (includeChildBook)
                {
                    foreach (var item in bvm_.ChildBookList_)
                    {
                        item.getInstrument(e_instVMList);
                    }
                }

                foreach (var item in bvm_.InstrumentList_)
                {
                    e_instVMList.Add(item);
                }

                StringBuilder sb = new StringBuilder();

                StringBuilder infoStr = new StringBuilder();

                string err = "";
                string errLoacation = "";

                foreach (var item in e_instVMList)
                {

                    try
                    {
                        item.loadBatchDetailContext();
                    }
                    catch (Exception e)
                    {
                        err = e.Message;
                        errLoacation = e.StackTrace;
                    }

                    infoStr.Append("itemCode=" + item.MasterInformationViewModel_.Item_code_ + ";");
                    infoStr.Append("type=" + item.MasterInformationViewModel_.Booking_type_ + ";");
                    infoStr.Append("name=" + item.MasterInformationViewModel_.Item_name_ + ";");
                    infoStr.Append("notional=" + item.Excel_interfaceViewModel_.Excel_issueInfoViewModel_.Notional_ + ";");
                    infoStr.Append("currency=" + item.Excel_interfaceViewModel_.Excel_issueInfoViewModel_.Currency_.CurrencyString_ + ";");
                    infoStr.Append("effective=" + StringConverter.xmlDateTimeToDateString(item.Excel_interfaceViewModel_.Excel_issueInfoViewModel_.EffectiveDate_) + ";");
                    infoStr.Append("maturity=" + StringConverter.xmlDateTimeToDateString(item.Excel_interfaceViewModel_.Excel_issueInfoViewModel_.MaturityDate_) + ";");

                    if (err != "")
                    {
                        infoStr.Append("error=" + err + ";");
                        infoStr.Append("errorTrace=" + errLoacation + ";");
                    }

                    sb.Append(this.infoParsing(infoStr.ToString(), infoType));

                    sb.Append("|");

                    infoStr.Clear();
                }

                return sb.ToString();
            }
            catch (Exception e)
            {
                return "booking fail : " + e.Message;
            }
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

        public string bookList()
        {
            try
            {
                List<BookViewModel> bvmList = new List<BookViewModel>();

                //if (includeChildBook)
                //{
                //    foreach (var item in bvm_.ChildBookList_)
                //    {
                //        item.getBookList(bvmList);
                //    }
                //}

                foreach (var item in bvm_.ChildBookList_)
                {
                    bvmList.Add(item);
                }

                StringBuilder sb = new StringBuilder();

                foreach (var item in bvmList)
                {
                    sb.Append(item.BookName_);
                    sb.Append("|");
                }

                return sb.ToString();
            }
            catch (Exception e)
            {
                return "booking fail : " + e.Message;
            }
        }

        public string[] bookListArr()
        {
            List<string> bookInfoList = new List<string>();

            try
            {
                List<BookViewModel> bvmList = new List<BookViewModel>();

                //if (includeChildBook)
                //{
                //    foreach (var item in bvm_.ChildBookList_)
                //    {
                //        item.getBookList(bvmList);
                //    }
                //}

                foreach (var item in bvm_.ChildBookList_)
                {
                    bvmList.Add(item);
                }

                StringBuilder sb = new StringBuilder();

                foreach (var item in bvmList)
                {
                    bookInfoList.Add(item.BookName_);
                }

                return bookInfoList.ToArray<string>();
            }
            catch (Exception e)
            {
                bookInfoList.Add("booking fail : " + e.Message);

                return bookInfoList.ToArray<string>();
            }
        }

        public string add_book(string bookCode, string bookName, string description)
        {
            try
            {
                this.bvm_.addBook(bookCode);
                this.bvm_.saveBookXml();

                return "book add complete";
            }
            catch (Exception e)
            {
                return "boook add fail." + e.Message;
                
            }
            
        }
        
        public void save_book()
        {
            try
            {
                this.bvm_.saveBookXml();

            }
            catch (Exception e)
            {
                throw e;

            }
        }

        public string get_error()
        {
            return this.log_.getErrList();
        }

        public string build_parameter(string itemCode ,DateTime refDate, ParameterBuildType pbt)
        {
            try
            {
                // load from master
                Excel_instrumentViewModel e_ivm = MasterInformationViewModel.loadInstrumentVM(itemCode);

                e_ivm.loadBatchDetailContext();

                // build
                e_ivm.buildParameterFromInstrument(refDate);
                
                e_ivm.Excel_parameterViewModel_.saveXml();

                return "para build OK : " + itemCode;
            }
            catch (Exception e)
            {
                return "para build fail : " + itemCode + " , " + e.Message;
            }
        }

        // batch를 위한 calculate임. // controller를 통해 도는게 아님
        public string calculate(string itemCode, DateTime refDate)
        {
            string result = "";

            try
            {
                // load from master
                Excel_instrumentViewModel e_ivm = MasterInformationViewModel.loadInstrumentVM(itemCode);

                e_ivm.loadBatchDetailContext();
                
                e_ivm.Excel_parameterViewModel_.ReferenceDate_ = refDate;

                e_ivm.loadParameterFromXml();

                

                e_ivm.calculate();

                result = e_ivm.Excel_parameterViewModel_.Excel_resultViewModel_.calcValue();

                return result;
            }
            catch (Exception e)
            {
                string errStr = "calculation fail : " + e.Message;

                return errStr;
            }
        }
    }
}
