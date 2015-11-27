using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class PositionBookingInfoVM
    {
        public string Itemcode_ { get; set; }
        public string Krcode_ { get; set; }
        public string Teamcode_ { get; set; }
        public string Fundcode_ { get; set; }
        public string BookID_ { get; set; }
        public string ExcelType_ { get; set; }
        public string ProductType_ { get; set; }
        public string GroupID_ { get; set; }
        public string GroupState_ { get; set; }
        public string Itemname_ { get; set; }
        public string ShortName_ { get; set; }
        public string IssueDate_ { get; set; }
        public string MaturityDat_ { get; set; }
        public string Underlying_ { get; set; }
        public string CounterPart_ { get; set; }
        public string ContractTyp_ { get; set; }
        public string Notional_ { get; set; }
        public string Currency_ { get; set; }
        public string BookedOrder_ { get; set; }
        public string BookingStat_ { get; set; }
        public string BookingDate_ { get; set; }

        public PositionBookingInfoVM(string itemcode, 
                                    string krcode, 
                                    string teamcode, 
                                    string fundcode, 
                                    string bookID, 
                                    string excelType, 
                                    string productType, 
                                    string groupID, 
                                    string groupState, 
                                    string itemname, 
                                    string shortName, 
                                    string issueDate, 
                                    string maturityDate, 
                                    string underlying, 
                                    string counterParty, 
                                    string contractType, 
                                    string notional, 
                                    string currency, 
                                    string bookedOrder, 
                                    string bookingState, 
                                    string bookingDate)
        {
            // TODO: Complete member initialization
            this.Itemcode_ = itemcode;
            this.Krcode_ = krcode;
            this.Teamcode_ = teamcode;
            this.Fundcode_ = fundcode;
            this.BookID_ = bookID;
            this.ExcelType_ = excelType;
            this.ProductType_ = productType;
            this.GroupID_ = groupID;
            this.GroupState_ = groupState;
            this.Itemname_ = itemname;
            this.ShortName_ = shortName;
            this.IssueDate_ = issueDate;
            this.MaturityDat_ = maturityDate;
            this.Underlying_ = underlying;
            this.CounterPart_ = counterParty;
            this.ContractTyp_ = contractType;
            this.Notional_ = notional;
            this.Currency_ = currency;
            this.BookedOrder_ = bookedOrder;
            this.BookingStat_ = bookingState;
            this.BookingDate_ = bookingDate;


        }
    }
}
