using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RiskMonitor
{
    public class VolatilityManager
    {
        public VolatilityManager(string vendor)
        {
            try
            {
                this.StockDataLoader_ = StockDataLoader.CreateLoader(vendor);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private StockDataLoader StockDataLoader_;

        public List<DateTime> CalculationReferenceDates_ { get; set; }
        
        public DateTime StartDate_ { get; set; }
        public DateTime EndDate_ { get; set; }

        public Dictionary<string,List<double>> ResultLIst_ { get; set;}
        
        // < Stock_ItemCode , Cal_Method >
        public Dictionary<string, string> StockMethodMap_ { get; set; }

        public void calculateAll()
        {
            foreach (var item in StockMethodMap_)
            {
                this.calculate(item.Key);
            }
        }

        public void calculate(string itemCode)
        {
            string method = StockMethodMap_[itemCode];
            VolCalculator calculator = VolCalculator.CreateCalculator(method);
            calculator.ValueList_ = StockDataLoader_.loadHistory(itemCode,this.StartDate_,this.EndDate_);
        }

    }
}
