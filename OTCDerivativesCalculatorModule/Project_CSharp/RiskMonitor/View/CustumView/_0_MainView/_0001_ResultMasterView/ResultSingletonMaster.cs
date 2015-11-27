using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RiskMonitor
{
    public static class ResultSingletonMaster
    {
        private static ResultMasterViewModel resultMasterVM_ = new ResultMasterViewModel();
        private static DateTime referenceDate_ = new DateTime();

        public static Uri ResultUri_ = new Uri("D:\\Project File\\OTCDerivativesCalculatorModule\\Project_CSharp\\RiskMonitor\\XmlFile\\book\\mrogen_position\\result\\");

        public static ResultMasterViewModel resultMasterVM()
        {
            return resultMasterVM_;
        }

        public static ResultUriInfo CreateResultUriInfo(InstrumentWrapperVM item,DateTime referenceDate)
        {
            return CreateResultUriInfo(item.InstBaseVM_.ItemCode_, item.InstBaseVM_.ItemType_,referenceDate);
        }

        public static ResultUriInfo CreateResultUriInfo(FileInfo instFileInfo, DateTime referenceDate)
        {
            string fileName = instFileInfo.Name;
            string exeptExtensionfileName = fileName.Replace(".xml", "");

            string itemCode = exeptExtensionfileName.Substring(0, 11);
            string itemType = exeptExtensionfileName.Substring(13);

            Uri uri = new Uri(instFileInfo.FullName);

            ResultUriInfo resultUri = new ResultUriInfo(itemCode, itemType, uri);

            return resultUri;
        }

        public static ResultUriInfo CreateResultUriInfo(string itemCode, string itemType, DateTime referenceDate)
        {
            // 오면 데이터 베이스 뜯어서 존재하는지 보고 리거기서 fileName 받아서 리턴함.

            Uri uri = new Uri(ResultUri_.LocalPath + referenceDate.ToString("yyyyMMdd") + "_" + itemCode + "_" + itemType + ".xml");

            ResultUriInfo resultUri = new ResultUriInfo(itemCode, itemType, uri);

            return resultUri;
        }
    }
}
