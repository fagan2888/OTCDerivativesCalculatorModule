using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel_Interface;
using System.Net.Mail;
using OpenPop.Common;
using OpenPop.Mime;
using OpenPop.Pop3;
using Ahn_OTCBookCOMLibrary;

namespace testConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            SettingInitializer setting = new SettingInitializer();
            setting.initialze(1);

            //calculation();

            //booking2();

            //mailSendTest();

            //mailReceiveTest();

            //testHifiveCalculation();

            //testStructuredBondCalculation();

            testStructuredSwapCalculation();

            //testStructuredSwap_ServerCalculation();

            //testScheduleInfo(1);

            //testScheduleInfo(1);

            //testUnderlying();
        }

        private static void testUnderlying()
        {
            Underlying u = new Underlying();


            string result = u.find_underlying("KR7005930003", InfoType.Header_Value);

            //result = u.get_whole_underlying(InfoType.Header_Value);
            //result = u.find_underlying("stock", InfoType.Header_Value);
            //result = u.get_quote(new DateTime(2014, 12, 10), "KR7005930003");

            Console.Write(result);
        }

        private static void testScheduleInfo(int ii)
        {
            string str = "type=autoCall_sch;eventDate=20160803;payoffDate=20160803;lowerTrigger=0.85;upperTrigger=2;underCalcType=Min;underlyings=KR7005930003,KR7066570003;constCoupon=0.136;";

            string vba_desc = str;

            StringBuilder sb = new StringBuilder();

            if (ii == 1)
            {
                string[] split = vba_desc.Split(';');

                foreach (var item in split)
                {
                    int equalCount = item.IndexOf('=');

                    if (item != "")
                    {
                        sb.Append(item.Substring(0, equalCount) + ";");
                    }

                }

            }
            else if (ii == 2)
            {
                string[] split = vba_desc.Split(';');

                foreach (var item in split)
                {
                    int equalCount = item.IndexOf('=');

                    if (item != "")
                    {

                        sb.Append(item.Substring(equalCount + 1, item.Length - (equalCount + 1)) + ";");
                    }

                }
            }
            else if (ii == 3)
            {
                sb.Append(vba_desc);
            }
            else
            {

            }
        }

        private static void testHifiveCalculation()
        {
            Excel_instrument_hifiveViewModel inst = new Excel_instrument_hifiveViewModel();
            DateTime refDate = new DateTime(2014,12,26);
            inst.calculate("testInst_1", refDate);
        }

        private static void testStructuredBondCalculation()
        {
            Excel_instrument_structuredBondViewModel inst = new Excel_instrument_structuredBondViewModel();
            DateTime refDate = new DateTime(2014, 12, 10);
            inst.calculate("testInst", refDate);
        }

        private static void testStructuredSwapCalculation()
        {
            Excel_instrument_structuredSwapViewModel inst = new Excel_instrument_structuredSwapViewModel();
            DateTime refDate = new DateTime(2014, 12, 10);
            inst.calculate("testInst", refDate);
        }

        private static void testStructuredSwap_ServerCalculation()
        {
            Excel_instrument_structuredSwapViewModel inst = new Excel_instrument_structuredSwapViewModel();
            DateTime refDate = new DateTime(2014, 12, 10);
            //inst.calculate("testInst", refDate);

            CalculationBatchController cbc = new CalculationBatchController();

            cbc.CalculationDate_ = refDate;
            cbc.enqueue_intrument("itemCode_600_14122910472470120");
            cbc.enqueue_intrument("itemCode_600_14123013416614082");
            cbc.enqueue_intrument("itemCode_600_14123013419733688");
            cbc.enqueue_intrument("itemCode_600_14123013413915072");
            cbc.enqueue_intrument("itemCode_600_14123013416785236");

            cbc.calculateStart();

        }

        private static void mailReceiveTest()
        {
            Pop3Client client = new Pop3Client();
            client.Connect("smart.ibks.com", 110, false);
            client.Authenticate("111104", "templar1");
            int count = client.GetMessageCount();
            Message message = client.GetMessage(count);
            Console.WriteLine(message.Headers.Subject);
        }

        private static void mailSendTest()
        {
          
            try
            {

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("mail.ibks.com");

                mail.From = new MailAddress("minikie@ibks.com");

                mail.To.Add("minikie@ibks.com");
                mail.Subject = "[OTC_Trade]#234JDIE3JIL2#";

                mail.Body = "This is for testing SMTP mail from AHN";

                string path = @"D:\OTC_Batch\";
                string fileName = "itemCode_340_14120316474143669.xml";
                Attachment att = new Attachment(path + fileName);

                mail.Attachments.Add(att);

                SmtpServer.Port = 25;
                SmtpServer.Credentials = new System.Net.NetworkCredential("minikie", "templar1");
                //SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);

            }
            catch (Exception e)
            {
                
            }
        }

        public static void booking()
        {
            DateTime refDate = DateTime.Now.AddDays(-1);

            RootBookViewModel root_bvm = new RootBookViewModel();

            RootBookViewModel.setRootBookReferenceDate(refDate);

            root_bvm.loadPosition();

            BookViewModel bvm = root_bvm.getBook("deltaHedgeBookCode");
            
            Make_instrument_structuredBond makeStructuredBond = new Make_instrument_structuredBond();
            
            DateTime eff = new DateTime(2014,10,11);
            DateTime mat = new DateTime(2015,10,11);
            double notional = 10000;
            string curr = "KRW";
            string daycount = "KOR";

            DateTime cpn1 = new DateTime(2015,1,11); double fixedRate = 0.03;
            DateTime cpn2 = new DateTime(2015,4,11);
            DateTime cpn3 = new DateTime(2015,7,11);
            DateTime cpn4 = new DateTime(2015,10,11);


            makeStructuredBond.makeIssueInfo(eff,mat,notional,curr,daycount);

            makeStructuredBond.addFixedCoupon(eff,cpn1,cpn1,fixedRate);
            makeStructuredBond.addFixedCoupon(cpn1,cpn2,cpn2,fixedRate);
            makeStructuredBond.addFixedCoupon(cpn2,cpn3,cpn3,fixedRate);
            makeStructuredBond.addFixedCoupon(cpn3,cpn4,cpn4,fixedRate);

            root_bvm.booking("deltaHedgeBookCode", makeStructuredBond.InstVM_);

            root_bvm.saveXml();

        }

        public static void booking2()
        {
            DateTime refDate = DateTime.Now.AddDays(-1);

            RootBookViewModel root_bvm = new RootBookViewModel();

            RootBookViewModel.setRootBookReferenceDate(refDate);

            root_bvm.loadPosition();

            BookViewModel bvm = root_bvm.getBook("deltaHedgeBookCode");

            Make_instrument_structuredBond makeStructuredBond = new Make_instrument_structuredBond();

            DateTime eff = new DateTime(2014, 10, 11);
            DateTime mat = new DateTime(2015, 10, 11);
            double notional = 10000;
            string curr = "KRW";
            string daycount = "KOR";

            DateTime cpn1 = new DateTime(2015, 1, 11);
            DateTime cpn2 = new DateTime(2015, 4, 11);
            DateTime cpn3 = new DateTime(2015, 7, 11);
            DateTime cpn4 = new DateTime(2015, 10, 11);

            makeStructuredBond.makeIssueInfo(eff, mat, notional, curr, daycount);

            List<double> lowerRngList = new List<double>(){ 0.0 , 0.6 };
            List<string> referenceUnderCodeList = new List<string>() { "CD91AAA", "SX5E" };
            List<double> upperRngList = new List<double>(){ 0.06 , 10.0 };

            double fixedAccRate = 0.055;

            makeStructuredBond.addSingleConditionDualRangAccrualFixedCoupon(eff, cpn1, cpn1, lowerRngList, referenceUnderCodeList, upperRngList, fixedAccRate);
            makeStructuredBond.addSingleConditionDualRangAccrualFixedCoupon(cpn1, cpn2, cpn2, lowerRngList, referenceUnderCodeList, upperRngList, fixedAccRate);
            makeStructuredBond.addSingleConditionDualRangAccrualFixedCoupon(cpn2, cpn3, cpn3, lowerRngList, referenceUnderCodeList, upperRngList, fixedAccRate);
            makeStructuredBond.addSingleConditionDualRangAccrualFixedCoupon(cpn3, cpn4, cpn4, lowerRngList, referenceUnderCodeList, upperRngList, fixedAccRate);

            root_bvm.booking("deltaHedgeBookCode", makeStructuredBond.InstVM_);

            root_bvm.saveXml();

        }

        public static void calculation()
        {
            DateTime refDate = DateTime.Now.AddDays(-1);

            RootBookViewModel root_bvm = new RootBookViewModel();

            RootBookViewModel.setRootBookReferenceDate(refDate);

            root_bvm.loadPosition();

            BookViewModel bvm = root_bvm.getBook("deltaHedgeBookCode");

            CalculationManagerViewModel cmvm = new CalculationManagerViewModel();

            cmvm.setBook(bvm);
            
            CalculationSetting setting = new CalculationSetting();
            setting.CalculateTypeEnum_ = CalculationSetting.CalculateTypeEnum.Parellel;

            cmvm.CalculationSetting_ = setting;

            cmvm.calculate(refDate);
        
        }

        public void booking(Excel_instrumentViewModel e_instVM)
        {
            ////w.Content = e_instVM.view(true);

            //e_instVM.linkEventPass();

            //    // master db에 박고
            //    // file 저장하고
            //e_instVM.bookingInstrument(); // db에 박음.

            //XMLFileLoader.SaveInstrument(e_instVM);

            //MasterInformationViewModel.WholeMasterPosition_.Add(e_instVM);
            //// 우선은 미분류로 보냄
            //// favoriteViewModel에 instrument List 에 더하고
            //this.rootFavoriteViewModel_.UnClassifiedFavoriteViewModel_.AddInstrument(e_instVM);

            //////이놈은 상품 xml 저장이 아니고 favor xml 저장
            //this.rootFavoriteViewModel_.saveXml();

            ////unclassified_fvm.InstrumentList_.Add(e_instVM);

            //// menu booking의 경우 refDate기준으로 임시 파라메터를 만들어줌.

            //e_instVM.buildParameterFromInstrument(ProgramVariable.ReferenceDate_);

            //XMLFileLoader.SaveParameter(e_instVM.Excel_parameterViewModel_);
            //XMLFileLoader.SaveHistoryData(e_instVM);
        }
    }
}
