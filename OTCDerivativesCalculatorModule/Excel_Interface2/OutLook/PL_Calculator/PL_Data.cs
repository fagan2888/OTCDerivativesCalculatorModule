using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class PL_Data 
    {
        private DateTime NowDate_;

        public string Item_code_;
        public string Item_name_;
        public string Trade_id_;
        public string Trade_date_;
        public string Maturiry_date_;

        public double Calc_value_;
        public double Unit_value_; // 단위금액 ex) 10000
        public double Notional_;
        public double Remain_notional_;
        public double Book_price_;
        public double Book_notional_;

        public double Eval_price_;
        public double Book_pl_;
        public double Total_eval_pl_;
        public double Trade_pl_;
        public double Daily_eval_pl_;
        public double Total_pl_;
        public double Etc_pl_;

        public PL_Data() { }

        public PL_Data(DateTime nowDate)
        {
            // TODO: Complete member initialization
            this.NowDate_ = nowDate;
        }

        //public void calculate(PL_Data prePL_Data,double nowPrice)
        //{
        //    this.calculate(prePL_Data, nowPrice, new List<TradePLEvent>());
        //}

        //public void calculate(PL_Data prePL_Data,double nowPrice, List<TradePLEvent> teList)
        //{
        //    this.CalcPrice_ = nowPrice;

        //    this.UnitPrice_ = prePL_Data.UnitPrice_;
        //    this.Notional_ = prePL_Data.Notional_;
        //    this.RemainNotional_ = prePL_Data.RemainNotional_;
        //    this.BookedPrice_ = prePL_Data.BookedPrice_;
        //    this.BookedNotional_ = prePL_Data.BookedNotional_;

        //    this.EvalPrice_ = (nowPrice / this.UnitPrice_) * this.RemainNotional_;
        //    this.TotalEvalFromBookValuePL_ = this.EvalPrice_ - this.RemainNotional_;

        //    foreach (TradePLEvent item in teList)
        //    {
        //        this.TradePL_ += item.tradePL();
        //    }

        //    // remainNotional이 증가하는 경우 생각
        //    this.DailyEvalPL_ = this.RemainNotional_ * (this.CalcPrice_ - prePL_Data.CalcPrice_) / this.UnitPrice_;
        //    this.TotalPL_ = this.DailyEvalPL_ + this.TradePL_;
        //}


        public void calculate(PL_Data prePL_Data, List<TradePLEvent> teList)
        {

            foreach (var item in teList)
            {
                item.calculate(this);
            }

            double eval_price = this.Remain_notional_ * (this.Calc_value_ / this.Unit_value_);

            this.Eval_price_ = eval_price;
            this.Total_eval_pl_ = eval_price - this.Book_notional_;
            this.Daily_eval_pl_ = this.Remain_notional_ * (this.Calc_value_ / this.Unit_value_ - prePL_Data.Calc_value_ / prePL_Data.Unit_value_);

            this.Total_pl_ = this.Total_eval_pl_ + this.Daily_eval_pl_ + this.Trade_pl_;

        }

        public void loadFromDataRow(System.Data.DataRow dataRow)
        {
            bool bookingTF = false;

            // date는 설정대 있고
            this.Item_code_ = dataRow["ITEM_CODE"].ToString();
            this.Item_name_ = dataRow["ITEM_NAME"].ToString();
            this.Trade_id_ = dataRow["TRADE_ID"].ToString();
            this.Notional_ = Convert.ToDouble(dataRow["NOTIONAL"]);
            this.Remain_notional_ = Convert.ToDouble(dataRow["REMAIN_NOTIONAL"]);
            //this.Type_ = item["TYPE"].ToString();
            this.Trade_date_ = dataRow["TRADE_DATE"].ToString();
            this.Maturiry_date_ = dataRow["MATURIRY_DATE"].ToString();

            if (this.NowDate_.ToString("yyyyMMdd") == this.Trade_date_)
                bookingTF = true;

            // 전일자가 있는 경우
            if (!bookingTF)
            {

                this.Book_price_ = Convert.ToDouble(dataRow["BOOK_PRICE"]);
                this.Book_notional_ = Convert.ToDouble(dataRow["BOOK_NOTIONAL"]);
                this.Eval_price_ = Convert.ToDouble(dataRow["EVAL_PRICE"]);
                this.Book_pl_ = Convert.ToDouble(dataRow["BOOK_PL"]);
                this.Total_eval_pl_ = Convert.ToDouble(dataRow["TOTAL_EVAL_PL"]);
                this.Daily_eval_pl_ = Convert.ToDouble(dataRow["DAILY_EVAL_PL"]);
                this.Trade_pl_ = Convert.ToDouble(dataRow["TRADE_PL"]);
                this.Total_pl_ = Convert.ToDouble(dataRow["TOTAL_PL"]);
                this.Etc_pl_ = Convert.ToDouble(dataRow["ETC_PL"]);
                this.Unit_value_ = Convert.ToDouble(dataRow["UNIT_VALUE"]);
                this.Calc_value_ = Convert.ToDouble(dataRow["CALC_VALUE"]);
            }
            //최초 Booking인 경우
            else
            {
                double calc_value = Convert.ToDouble(dataRow["CALC_VALUE"]);
                double unit_value = Convert.ToDouble(dataRow["UNIT_VALUE"]);

                this.Book_price_ = calc_value;
                this.Book_notional_ = this.Remain_notional_ * calc_value / this.Unit_value_;
                this.Eval_price_ = this.Book_notional_;
                //this.Book_pl_ = Convert.ToDouble(item["BOOK_PL"]);
                this.Total_eval_pl_ = 0.0;
                this.Daily_eval_pl_ = 0.0;
                this.Trade_pl_ = 0.0;
                this.Total_pl_ = 0.0;
                this.Etc_pl_ = 0.0;

            }
        }
    }
}
