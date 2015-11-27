//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using Excel_Interface;
//using System.Runtime.InteropServices;
//using System.Net.Mail;
//using OpenPop.Common;
//using OpenPop.Mime;
//using OpenPop.Pop3;

//namespace Ahn_OTCBookCOMLibrary
//{
//    [ClassInterface(ClassInterfaceType.AutoDual)]
//    public class TradeManager
//    {

//        //private Dictionary<string,Message> receivedMessages_;
//        private List<Message> receivedMessages_;
//        private MailAddress myMailAddress_;

//        public TradeManager()
//        {
//            this.myMailAddress_ = new MailAddress("minikie@ibks.com");
//            this.receivedMessages_ = new List<Message>();
//        }

//        public string send(Instrument_hifive inst, string receiver)
//        {
//            try
//            {

//                return "set complete";
//            }
//            catch (Exception e)
//            {
//                return "add fail : " + e.Message;
//            }
//        }

//        public string sendToEmail(Instrument_hifive inst, string email)
//        {
//            try
//            {

//                MailMessage mail = new MailMessage();
//                SmtpClient SmtpServer = new SmtpClient("mail.ibks.com");

//                mail.From = this.myMailAddress_;
//                mail.To.Add(email);
//                mail.Subject = "[OTC_TradeMsg]";

//                mail.Body = "This is for testing SMTP mail from AHN";

//                string path = @"D:\OTC_Batch\";
//                string fileName = "itemCode_340_14120316474143669.xml";
//                Attachment att = new Attachment( path + fileName );

//                mail.Attachments.Add(att);

//                SmtpServer.Port = 25;
//                SmtpServer.Credentials = new System.Net.NetworkCredential("minikie", "templar1");
//                //SmtpServer.EnableSsl = true;

//                SmtpServer.Send(mail);

//                return "send complete";
//            }
//            catch (Exception e)
//            {
//                return "send fail : " + e.Message;
//            }
//        }

//        public string receive()
//        {
//            try
//            {
//                Pop3Client client = new Pop3Client();
//                client.Connect("smart.ibks.com", 110, false);
//                client.Authenticate("111104", "templar1");
//                int count = client.GetMessageCount();

//                for (int i = 1; i < count+1; i++)
//                {
//                    Message message = client.GetMessage(count);

//                    if (message.Headers.Subject.Substring(0,13) == "[OTC_TradeMsg]")
//                    {
//                        this.receivedMessages_.Add(message);
//                    }
//                    //if ( message.Headers
//                }
                
//                //Console.WriteLine(message.Headers.Subject);

//                return "receive complete";
//            }
//            catch (Exception e)
//            {
//                return "receive fail : " + e.Message;
//            }
//        }

//        public string get_received_instruments()
//        {
//            try
//            {

//                return "set complete";
//            }
//            catch (Exception e)
//            {
//                return "add fail : " + e.Message;
//            }
//        }

//        public string get_instruments(string itemName)
//        {
//            try
//            {

//                return "set complete";
//            }
//            catch (Exception e)
//            {
//                return "add fail : " + e.Message;
//            }
//        }


//    }
//}
