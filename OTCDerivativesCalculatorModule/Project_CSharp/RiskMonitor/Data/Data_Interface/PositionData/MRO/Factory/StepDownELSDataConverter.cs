using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Xml;

namespace RiskMonitor
{
    public class StepDownELSDataConverter
    {
        StepDownELSDataConverter() 
        {
        
        }

        void buildFromSympony(string[] els) 
        {
            
        }

        //List<Instrument> buildFromMRO()
        //{
        //    ResultDataLoader loader = new ResultDataLoader();

        //    DataSet dataSet = loader.load();

        //    //check table interface
            
        //    DataTable ELSListTable = dataSet.Tables["ELSList"];

        //    DataTable GreekTable = dataSet.Tables["GreekTable"];

        //    List<Instrument> elsInstruments = new List<Instrument>();

        //    foreach (DataRow dr in ELSListTable.Rows)
        //    {
        //        string code = dr["KR_CODE"].ToString();

        //        DataRow[] underlyingData = GreekTable.Select(code);
                
        //        List<ELSUnderlyingStock> underlyings = new List<ELSUnderlyingStock>();

        //        foreach (var item in underlyingData)
        //        {
        //            //분리형일때 같은 기초자산일 때 더하는 코드 필요
        //            //underlyings.Add(new UnderlyingStock(item["NAME"],
        //            //                        item["CURRENT_PRICE"],
        //            //                        item["BASE_PRICE"],
        //            //                        item["DIVIDEND"],
        //            //                        item["SUB_CODE"],
        //            //                        item["DELTA"],
        //            //                        item["GAMMA"],
        //            //                        item["VEGA"]));

        //        }

        //        //elsInstruments.Add(new Instrument(dr["KR_CODE"],
        //        //                                dr["ITEM_NAME"],
        //        //                                dr["NOTIONAL"],
        //        //                                underlyings,
        //        //                                dr["PRICE"]));

                    
        //    }

        //    return elsInstruments;
        //}

        

        void buildFromMenual() 
        {
        
        }

        //EquiryLinkedSecurity.ELSStepDown elsStepDown_ { get; set; }

        //CustomProduct.StructuredProduct structuredProductForm { get; set; }
        
        

    }
}
