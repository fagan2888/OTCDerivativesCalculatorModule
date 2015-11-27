using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RiskMonitor
{

    // 포지션 검색기 형태로 VM 하나 만들어 놔야 할듯 여기다 할지 PositionMasterVM 에다가 할지 아직
    // 미결정 ㅡ.ㅡ 부왘 2013-11-15
    public static class PositionSingletonManger
    {
        //[ThreadStatic]
        //private static ObservableCollection<InstPositionWrapperVM> InstrumentList_ = new ObservableCollection<InstPositionWrapperVM>();

        public static Uri PositionUri_ = new Uri("D:\\Project File\\OTCDerivativesCalculatorModule\\Project_CSharp\\RiskMonitor\\XmlFile\\book\\mrogen_position\\");

        private static PositionMasterViewModel positionMasterVM_ = new PositionMasterViewModel();
        private static DateTime referenceDate_ = new DateTime();
        private static string positionName_;

        //public static ObservableCollection<InstPositionWrapperVM> instrumentList()
        //{
        //    return InstrumentList_;
        //}

        public static PositionMasterViewModel positionMasterVM()
        {
            return positionMasterVM_;
        }

        public static string positionName()
        {
            return positionName_;
        }

        public static void setPositionName(string positionName)
        {
            positionName_ = positionName;
        }

        public static DateTime referenceDate()
        {
            return referenceDate_;
        }

        public static void setReferenceDate(DateTime date)
        {
            referenceDate_ = date;
        }

        //public static void addInstrument(InstrumentBaseViewModel viewModel_)
        //{
        //    InstPositionWrapperVM wrapperVM = new InstPositionWrapperVM(viewModel_);

        //    PositionMasterLoader loader = positionMasterVM_.loader();

        //}

        //public static void loadPosition()
        //{ 
        //    // 환경 설정 파일 에서 로드함.
        //    // 하지만 지금은 그냥 로드
        //    string path = "D:\\Project File\\OTCDerivativesCalculatorModule\\Project_CSharp\\RiskMonitor\\XmlFile\\book\\mrogen_position\\";
        //    DirectoryInfo dir = new DirectoryInfo(path);

        //    FileInfo[] fileList = dir.GetFiles("*.xml");

        //    foreach (FileInfo item in fileList)
        //    {
        //        InstUriInfo instUri = CreateInstUriInfo(item);
        //        //ResultUriInfo resultUri = CreateResultUriInfo(item);
        //        //InstrumentBaseViewModel instBaseBM = InstrumentBaseViewModel.CreateInstBaseVM(instUri,resultUri);
        //        InstrumentBaseViewModel instBaseBM = InstrumentBaseViewModel.CreateInstBaseVM(instUri);
        //        InstPositionWrapperVM instPositionWrapperVM = new InstPositionWrapperVM(instBaseBM);

        //        InstrumentList_.Add(instPositionWrapperVM);
        //    }
        //}

        public static InstUriInfo CreateInstUriInfo(InstrumentWrapperVM item)
        {
            return CreateInstUriInfo(item.InstBaseVM_.ItemCode_, item.InstBaseVM_.ItemType_);
        }

        public static InstUriInfo CreateInstUriInfo(FileInfo instFileInfo)
        {
            string fileName = instFileInfo.Name;
            string exeptExtensionfileName = fileName.Replace(".xml", "");

            string itemCode = exeptExtensionfileName.Substring(0, 11);
            string itemType = exeptExtensionfileName.Substring(13);

            Uri uri = new Uri(instFileInfo.FullName);

            InstUriInfo instUri = new InstUriInfo(itemCode, itemType, uri);

            return instUri;
        }

        public static InstUriInfo CreateInstUriInfo(string itemCode, string itemType)
        {
            Uri uri = new Uri(PositionUri_.LocalPath + itemCode + "_" + itemType + ".xml");

            InstUriInfo instUri = new InstUriInfo(itemCode, itemType, uri);

            return instUri;
        }

        //////////////////////////////////////////////////////
        //// Observable interface
        //private static event Callback notifyObserversEvent;

        //public static void registerWith(Callback handler) { notifyObserversEvent += handler; }
        //public static void unregisterWith(Callback handler) { notifyObserversEvent -= handler; }
        //private static void notifyObservers()
        //{
        //    Callback handler = notifyObserversEvent;
        //    if (handler != null)
        //    {
        //        handler();
        //    }
        //}


        
    }
}
