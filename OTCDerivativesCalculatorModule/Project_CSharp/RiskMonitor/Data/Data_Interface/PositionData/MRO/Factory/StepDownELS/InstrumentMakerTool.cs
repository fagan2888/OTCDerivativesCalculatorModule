using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace RiskMonitor
{


    public class InstrumentMakerTool
    {


        //under 에 코드랑 종목명이랑 받음
        public static string ELSStepDown(string code,
                                  string InstName,
                                  long notional,
                                  List<ELSUnderlyingStock> unders,
                                  DateTime effectiveDate,
                                  DateTime maturityDate, // 돈들어오는 날
                                  int maturityYear,
                                  List<DateTime> redemptionDate,
                                  List<double> redemptionTrigger,
                                  double rebateRate,
                                  int averageDays,
                                  List<double> KIs,
                                  List<double> cpns)
        {
            string dateOutFormat = "yyyy-MM-dd";

            //string paraInfo = engine_.buildParametorXmlData();
            StringBuilder sb = new StringBuilder();
            XmlWriterSettings setting = new XmlWriterSettings();

            setting.Indent = true;
            //setting.Encoding = Encoding.UTF8;

            XmlWriter xmlWriter = XmlWriter.Create(sb, setting);

            xmlWriter.WriteProcessingInstruction("xml", "version='1.0' encoding='UTF-8'");

            xmlWriter.WriteStartElement("instrument");
                xmlWriter.WriteAttributeString("Type", "StepDown");
            //xmlWriter.WriteEndAttribute();
                xmlWriter.WriteStartElement("instPositionInfo");
                    xmlWriter.WriteElementString("krCode", code);
                    xmlWriter.WriteElementString("instName", InstName);
                    xmlWriter.WriteElementString("instCode", code);
                    xmlWriter.WriteElementString("instType", "StepDown");
                    //xmlWriter.WriteElementString("bookedDate", this.bookedDate_);
                    //xmlWriter.WriteElementString("unBookedDate", this.unBookedDate_);
                    //xmlWriter.WriteElementString("maturityDate", this.maturityDate_);
                    //xmlWriter.WriteElementString("fileName", this.fileName_);
                    //xmlWriter.WriteElementString("positionName", this.positionName_);
                    //xmlWriter.WriteElementString("counterParty", this.counterParty_);
                    xmlWriter.WriteElementString("notional", Convert.ToString(notional));
                    //xmlWriter.WriteElementString("currency", this.currency_);
                    //xmlWriter.WriteElementString("fundCode", this.fundCode_);
                    //xmlWriter.WriteElementString("fundName", this.fundName_);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("header");
                    xmlWriter.WriteElementString("productName", InstName);
                    xmlWriter.WriteElementString("krCode", code);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("instrumentInfo");
                    xmlWriter.WriteElementString("type", "standardInstrument");
                    xmlWriter.WriteStartElement("standardInstrument");

                        xmlWriter.WriteStartElement("issueInformation");
                            xmlWriter.WriteElementString("type", "noteInfo");
                            xmlWriter.WriteStartElement("noteInfo");
                                xmlWriter.WriteElementString("tradeDate", effectiveDate.ToString(dateOutFormat));
                                xmlWriter.WriteElementString("effectiveDate", effectiveDate.ToString(dateOutFormat));
                                xmlWriter.WriteElementString("maturityDate", maturityDate.ToString(dateOutFormat));
                                xmlWriter.WriteElementString("notional", Convert.ToString(notional));
                                xmlWriter.WriteElementString("premium", "0");
                            xmlWriter.WriteEndElement();

                        xmlWriter.WriteEndElement();

                        xmlWriter.WriteStartElement("underlyingInformation");
                            xmlWriter.WriteElementString("type", "indexUnderInfo");
                            xmlWriter.WriteStartElement("indexUnderInfo");

                            int count = 0;

                            foreach (var item in unders)
                            {
                                xmlWriter.WriteStartElement("index");
                                    xmlWriter.WriteElementString("type", "stockIndex");
                                    xmlWriter.WriteStartElement("stockIndex");
                                        xmlWriter.WriteElementString("krCode", item.Name_);
                                        xmlWriter.WriteElementString("name", item.Name_);
                                    //effectiveDate의 현재가격 // 없으면 100 으로 고정.
                                        xmlWriter.WriteElementString("basePrice", Convert.ToString(item.BasePrice_));
                                    xmlWriter.WriteEndElement();

                                xmlWriter.WriteEndElement();

                                count += 1;
                            }

                            xmlWriter.WriteEndElement();
                        xmlWriter.WriteEndElement();


                        xmlWriter.WriteStartElement("payoffInfo");
                            xmlWriter.WriteElementString("type", "stepDownKI");
                            xmlWriter.WriteStartElement("stepDownKI");

                                xmlWriter.WriteStartElement("kiEventInfo");
                                    xmlWriter.WriteElementString("type", "constKiTrigger");
                                    xmlWriter.WriteStartElement("constKiTrigger");

                                        xmlWriter.WriteElementString("pastKI", "false");

                                        for (int i = 0; i < unders.Count; i++)
                                        {
                                            xmlWriter.WriteElementString("value", Convert.ToString(KIs[i] / 100));
                                        }

                                    xmlWriter.WriteEndElement();
                                xmlWriter.WriteEndElement();

                                xmlWriter.WriteStartElement("nonKiEventInfo");
                                    xmlWriter.WriteElementString("type", "constNonKiTrigger");
                                    xmlWriter.WriteStartElement("constNonKiTrigger");
                                        xmlWriter.WriteElementString("return", Convert.ToString(rebateRate));
                                    xmlWriter.WriteEndElement();
                                xmlWriter.WriteEndElement();
            
                                //int redemCount = (12 * maturityYear) / redemTenorMonth;
                                int redemCount = redemptionDate.Count;

                                xmlWriter.WriteStartElement("redemptionInfo");
                                    xmlWriter.WriteElementString("type", "autoCallRedem");

                                    xmlWriter.WriteStartElement("autoCallRedem");

                                    for (int i = 0; i < redemCount; i++)
                                    {
                                        xmlWriter.WriteStartElement("eventTrigger");
                                            xmlWriter.WriteElementString("type", "autoCallConstReturnTrigger");
                                            xmlWriter.WriteStartElement("autoCallConstReturnTrigger");
                                                xmlWriter.WriteElementString("dateOrder", Convert.ToString(i));
                                                xmlWriter.WriteElementString("date", redemptionDate[i].ToString(dateOutFormat));
                                                xmlWriter.WriteElementString("trigger", Convert.ToString(redemptionTrigger[i] / 100));
                                                xmlWriter.WriteElementString("return", Convert.ToString(cpns[i] / 100));
                                                xmlWriter.WriteElementString("averageDays", Convert.ToString(averageDays));
                                            xmlWriter.WriteEndElement();
                                        xmlWriter.WriteEndElement();

                                    }

                                    xmlWriter.WriteEndElement();
                                xmlWriter.WriteEndElement();

                            xmlWriter.WriteEndElement(); //stepDownKI End

                        xmlWriter.WriteEndElement(); //payoffInfo End
                    xmlWriter.WriteEndElement(); //standardInstrument End
                xmlWriter.WriteEndElement(); //instrumentInfo End

            xmlWriter.WriteEndElement(); //instrument End

            xmlWriter.Close();

            return sb.ToString();
        }

        //    public static string ELSStepDown(string InstName,
        //                              long notional,
        //                              List<ELSUnderlyingStock> unders,
        //                              DateTime effectiveDate,
        //                              int maturityYear,
        //                              int redemTenorMonth,
        //                              List<double> redemptionTrigger,
        //                              int averageDays,
        //                              List<double> KIs,
        //                              double cpnYear) 
        //    {

        //        //string paraInfo = engine_.buildParametorXmlData();
        //        StringBuilder sb = new StringBuilder();
        //        XmlWriterSettings setting = new XmlWriterSettings();
        //        setting.Indent = true;

        //        XmlWriter xmlWriter = XmlWriter.Create(sb,setting);

        //        xmlWriter.WriteStartElement("instrument");

        //            xmlWriter.WriteStartElement("issueInformation");
        //                xmlWriter.WriteElementString("productName", InstName);
        //                xmlWriter.WriteElementString("productType", "StepDown");
        //                xmlWriter.WriteElementString("krCode", "KR000000TEST");
        //                xmlWriter.WriteElementString("tradeDate", effectiveDate.ToShortTimeString());
        //                xmlWriter.WriteElementString("effectiveDate", effectiveDate.ToShortTimeString());
        //                xmlWriter.WriteElementString("maturityDate", effectiveDate.AddYears(maturityYear).ToShortTimeString());
        //                xmlWriter.WriteElementString("notional", Convert.ToString(notional));
        //                xmlWriter.WriteElementString("premium", "0");
        //            xmlWriter.WriteEndElement();

        //            xmlWriter.WriteStartElement("ELSStepDownRedemptions");
        //                xmlWriter.WriteStartElement("underlyingInformation");

        //                int count = 0;        

        //                foreach (var item in unders)
        //                {
        //                    xmlWriter.WriteStartElement("underlying");
        //                        xmlWriter.WriteElementString("krCode", "KR0TESTUnder" + Convert.ToString(count));
        //                        xmlWriter.WriteElementString("name", item.Name_);
        //                        //effectiveDate의 현재가격 // 없으면 100 으로 고정.
        //                        xmlWriter.WriteElementString("basePrice", "100");
        //                    xmlWriter.WriteEndElement();

        //                    count += 1;
        //                }

        //                xmlWriter.WriteEndElement();

        //                xmlWriter.WriteStartElement("kiTrigger");
        //                    xmlWriter.WriteElementString("pastKI", "false");

        //                    for (int i = 0; i < unders.Count; i++)
        //                    {
        //                        xmlWriter.WriteElementString("value", Convert.ToString(KIs[i]));
        //                    }

        //                    int redemCount = ( 12 * maturityYear ) / redemTenorMonth;

        //                xmlWriter.WriteEndElement();


        //                xmlWriter.WriteStartElement("nonkiTrigger");
        //                    xmlWriter.WriteElementString("return", Convert.ToString(cpnYear * maturityYear) );
        //                xmlWriter.WriteEndElement();

        //                for (int i = 0; i < redemCount ; i++)
        //                {
        //                    xmlWriter.WriteStartElement("autoCallTrigger");
        //                        xmlWriter.WriteElementString("dateOrder", Convert.ToString(i));
        //                        xmlWriter.WriteElementString("date", effectiveDate.AddMonths(redemTenorMonth).ToShortTimeString());
        //                        xmlWriter.WriteElementString("trigger", Convert.ToString(redemptionTrigger[i]));
        //                        xmlWriter.WriteElementString("return", Convert.ToString( cpnYear * (redemTenorMonth / 12) * i));
        //                        xmlWriter.WriteElementString("averageDays", Convert.ToString(averageDays));
        //                    xmlWriter.WriteEndElement();
        //                }

        //            xmlWriter.WriteEndElement(); //ELSStepDownRedemptions End


        //        xmlWriter.WriteEndElement(); //instrument End

        //        xmlWriter.Close();

        //        return sb.ToString();
        //    }
        //}
    }
}
