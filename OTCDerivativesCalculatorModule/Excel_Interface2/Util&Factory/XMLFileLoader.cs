using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace Excel_Interface
{
    public class XMLFileLoader
    {
        private static string path_ = @"D:\OTC_Batch\";

        public static XmlDocument LoadParameter(string itemCode, DateTime referenceDate)
        {
            string referDateStr_yyyyMMdd = referenceDate.ToString("yyyyMMdd");

            XmlDocument xmlDoc = new XmlDocument();
            
            try
            {
                string fullPath = path_ + referDateStr_yyyyMMdd + "\\" + itemCode + "_" + referDateStr_yyyyMMdd + ".xml";
                xmlDoc.Load(fullPath);
            }
            catch (Exception )
            {
                OutputLogViewModel.addResult("referenceDate : " + referDateStr_yyyyMMdd + " parameter Xml does not Found!");
                xmlDoc = null;

                throw new Exception("parameter file does not exist : " + itemCode + " " + referDateStr_yyyyMMdd);
            }

            return xmlDoc;
        }

        public static XmlDocument LoadInstrument(string itemCode)
        {
            XmlDocument xmlDoc = new XmlDocument();

            try
            {
                string fullPath = path_ + itemCode + ".xml";

                xmlDoc.Load(fullPath);
            }
            catch (Exception)
            {
                OutputLogViewModel.addResult("Instrument Xml does not Found!");

                throw new Exception("instrument file does not exist : " + itemCode );
            }

            return xmlDoc;
        }

        public static XmlDocument SaveInstrument(string itemCode,string instXml)
        {
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.LoadXml(instXml);

            //20140522_50507A3610S0_StepDownKI
            try
            {
                //xmlDoc.Save(path_ + itemCode + ".xml");
                xmlDoc.Save(path_ + itemCode + ".xml");
            }
            catch (Exception)
            {
                OutputLogViewModel.addResult("Instrument Xml save fail!");
            }

            return xmlDoc;
        }

        public static void SaveParameter(string itemCode, string instXml , DateTime referenceDate )
        { 
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.LoadXml(instXml);

            string refDateStr = referenceDate.ToString("yyyyMMdd");

            bool exists = System.IO.Directory.Exists(path_ + refDateStr);

            if (!exists)
            {
                System.IO.Directory.CreateDirectory(path_ + refDateStr);
            }

            try
            {
                xmlDoc.Save(path_ +  refDateStr + "\\" + itemCode + "_" + refDateStr + ".xml");

            }
            catch (Exception)
            {
                OutputLogViewModel.addResult("parameter Xml save fail!");
            }

        }

        public static void SaveParameter(Excel_parameterViewModel e_paraVM)
        {
            string parameterXmlStr = e_paraVM.paraXml();

            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.LoadXml(parameterXmlStr);

            string itemCode = e_paraVM.ItemCode_;
            string refDateStr = e_paraVM.ReferenceDate_.ToString("yyyyMMdd");

            bool exists = System.IO.Directory.Exists(path_ + refDateStr);

            if (!exists)
            {
                System.IO.Directory.CreateDirectory(path_ + refDateStr);
            }


            try
            {
                xmlDoc.Save(path_ + refDateStr + "\\" + itemCode + "_" + refDateStr + ".xml");
            }
            catch (Exception )
            {
                OutputLogViewModel.addResult("parameter Xml save fail!");
            }

        }

        public static void SaveHistoryData(Excel_instrumentViewModel e_inst)
        {
            Excel_parameterViewModel e_paraVM = e_inst.Excel_parameterViewModel_;

            //DateTime tradeDate = e_inst.MasterInformationViewModel_.Trade_date_;

            DateTime effectiveDate = e_inst.Excel_interfaceViewModel_.Excel_issueInfoViewModel_.EffectiveDate_;

            //string historyUnderStr = e_paraVM.historyUnderData(effectiveDate);
            string historyUnderStr = e_inst.Excel_interfaceViewModel_.Excel_underlyingCalcInfoViewModel_.historyUnderData(effectiveDate, e_paraVM.ReferenceDate_);

            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.LoadXml(historyUnderStr);

            string itemCode = e_paraVM.ItemCode_;
            string refDateStr = e_paraVM.ReferenceDate_.ToString("yyyyMMdd");

            bool exists = System.IO.Directory.Exists(path_ + refDateStr);

            if (!exists)
            {
                System.IO.Directory.CreateDirectory(path_ + refDateStr);
            }


            try
            {
                xmlDoc.Save(path_ + refDateStr + "\\" + itemCode + "_" + refDateStr + "_historyData.xml");
            }
            catch (Exception )
            {
                OutputLogViewModel.addResult("history Xml save fail!");
            }

        }

        public static void SaveInstrument(Excel_instrumentViewModel e_instVM)
        {
            //positionDB.booking(this.viewModel_)
            string productXmlStr = e_instVM.Excel_interfaceViewModel_.productXml();

            //이놈은 나중에 다른 배치로 돌거임..
            //string parameterXmlStr = this.viewModel_.Excel_parameterViewModel_.paraXml();

            // < date , value > //
            //string underHistDataStr = this.viewModel_.Excel_parameterViewModel_.historyUnderData();

            // 현재 program foler로 저장됨

            //System.IO.File.WriteAllText("testProductInfo.xml", productXmlStr);

            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.LoadXml(productXmlStr);

            string itemCode = e_instVM.MasterInformationViewModel_.Item_code_;

            try
            {
                xmlDoc.Save(path_ + itemCode + ".xml");
            }
            catch (Exception)
            {
                OutputLogViewModel.addResult("Instrument Xml save fail!");
            }

        }

        public static bool isFileExist(string itemCode, DateTime referenceDate)
        {
            string referDateStr_yyyyMMdd = referenceDate.ToString("yyyyMMdd");
            
            bool existFlag = false;

            try
            {
                string fullPath = path_ + referDateStr_yyyyMMdd + "\\" + itemCode + "_" + referDateStr_yyyyMMdd + ".xml";
                existFlag = File.Exists(fullPath);
            }
            catch (Exception)
            {
                return false;

            }

            return existFlag;
        }


    }
}
