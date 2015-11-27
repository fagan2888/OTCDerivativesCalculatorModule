using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{
    public class MROResultDataLoader : DataLoader
    {
        public MROResultDataLoader() 
        {
            //string historyResult;
        }

        public ObservableCollection<ResultModel> 
                        historyResults(DateTime initialDate, 
                                        DateTime lastDate, 
                                        string itemCode)
        {
            //query file load
            FileStream query = File.OpenRead(QueryPathList_["History"]);
            //query builder 사용

            StringBuilder sb = new StringBuilder();

            ObservableCollection<ResultModel> rm = new ObservableCollection<ResultModel>();

            return rm;
        }

        
    }
}
