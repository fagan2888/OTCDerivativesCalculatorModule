using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Excel_Interface
{
    public class ProgramVariable
    {
        public static ParameterSettingManager CurrenctParameterSettingManager_;// = new ParameterSettingManager();

        public static PricingMethodSettingManager CurrenctPricingMethodSettingManager_;// = new PricingMethodSettingManager();

        //process여러개를 위해서라면 나중에 꺼낼때 클론으로 꺼냄.. 
        public static UnderlyingModelSetting UnderlyingModelSetting_;// = new UnderlyingModelSetting();

        public static void initialize_ComboStr()
        {
            ProgramVariable.initialize_CurrencyStringList();
            ProgramVariable.initialize_UnderlyingComboStringList();
            //ProgramVariable.initialize_UnderlyingDetailComboStringList();
            ProgramVariable.initialize_ContractComboStringList();
            ProgramVariable.initialize_ContractSubComboStringList();
            //Excel_underlyingModel_paraViewModel.initialize_UnderlyingModelComboStringList();
            //ProgramVariable.initialize_ContractDetailComboStringList();
        }

        public static DateTime ReferenceDate_ = DateTime.Now;
        
        public static string getReferenceDateStr() 
        {
            return ProgramVariable.ReferenceDate_.ToString("yyyyMMdd");
        }

        //public static List<string> CurrencyStringList_ = new List<string>();
        public static ObservableCollection<CurrencyViewModel> CurrencyStringList_ = new ObservableCollection<CurrencyViewModel>();
        public static ObservableCollection<UnderlyingComboViewModel> UnderlyingComboDisplayStrList_ = new ObservableCollection<UnderlyingComboViewModel>();
        //public static ObservableCollection<UnderlyingDetailComboViewModel> UnderlyingDetailComboDisplayStrList_ = new ObservableCollection<UnderlyingDetailComboViewModel>();
        public static ObservableCollection<ContractComboViewModel> ContractComboDisplayStrList_ = new ObservableCollection<ContractComboViewModel>();
        public static ObservableCollection<ContractSubComboViewModel> ContractSubComboDisplayStrList_ = new ObservableCollection<ContractSubComboViewModel>();

        

        //public static ObservableCollection<ContractDetailComboViewModel> ContractDetailComboDisplayStrList_ =  new ObservableCollection<ContractDetailComboViewModel>();

        public static void initialize_CurrencyStringList()
        {
            ProgramVariable.CurrencyStringList_ = new ObservableCollection<CurrencyViewModel>();

            ProgramVariable.CurrencyStringList_.Add(new CurrencyViewModel("KRW","KRW"));
            ProgramVariable.CurrencyStringList_.Add(new CurrencyViewModel("USD", "USD"));
            ProgramVariable.CurrencyStringList_.Add(new CurrencyViewModel("EUR","EUR"));
            ProgramVariable.CurrencyStringList_.Add(new CurrencyViewModel("CNH","CNH"));

            for (int i = 0; i < ProgramVariable.CurrencyStringList_.Count; i++)
            {
                ProgramVariable.CurrencyStringList_[i].SelectedIndex_ = i;
            }
        }

        public static void initialize_UnderlyingComboStringList()
        {
            ProgramVariable.UnderlyingComboDisplayStrList_ = new ObservableCollection<UnderlyingComboViewModel>();

            ProgramVariable.UnderlyingComboDisplayStrList_.Add(new UnderlyingComboViewModel("Foreign", "외환"));
            ProgramVariable.UnderlyingComboDisplayStrList_.Add(new UnderlyingComboViewModel("Equity","주식"));
            ProgramVariable.UnderlyingComboDisplayStrList_.Add(new UnderlyingComboViewModel("IR","이자율"));
            ProgramVariable.UnderlyingComboDisplayStrList_.Add(new UnderlyingComboViewModel("Credit", "신용"));
            ProgramVariable.UnderlyingComboDisplayStrList_.Add(new UnderlyingComboViewModel("Composite", "복합"));
            ProgramVariable.UnderlyingComboDisplayStrList_.Add(new UnderlyingComboViewModel("Index", "지수"));
            ProgramVariable.UnderlyingComboDisplayStrList_.Add(new UnderlyingComboViewModel("ETC", "기타"));

            for (int i = 0; i < ProgramVariable.UnderlyingComboDisplayStrList_.Count; i++)
            {
                ProgramVariable.UnderlyingComboDisplayStrList_[i].SelectedIndex_ = i;
            }
        }

        //public static void initialize_UnderlyingDetailComboStringList()
        //{
        //    ProgramVariable.CurrencyStringList_ = new ObservableCollection<CurrencyViewModel>();

        //    ProgramVariable.CurrencyStringList_.Add(new CurrencyViewModel("KRW"));
        //    ProgramVariable.CurrencyStringList_.Add(new CurrencyViewModel("USD"));
        //    ProgramVariable.CurrencyStringList_.Add(new CurrencyViewModel("EUR"));
        //    ProgramVariable.CurrencyStringList_.Add(new CurrencyViewModel("CNH"));
        //}

        public static void initialize_ContractComboStringList()
        {
            ProgramVariable.ContractComboDisplayStrList_ = new ObservableCollection<ContractComboViewModel>();

            ProgramVariable.ContractComboDisplayStrList_.Add(new ContractComboViewModel("OTCContract","OTC 계약"));
            ProgramVariable.ContractComboDisplayStrList_.Add(new ContractComboViewModel("Spot", "현물"));
            ProgramVariable.ContractComboDisplayStrList_.Add(new ContractComboViewModel("Security","증권"));
            ProgramVariable.ContractComboDisplayStrList_.Add(new ContractComboViewModel("Exchange", "거래소"));
            ProgramVariable.ContractComboDisplayStrList_.Add(new ContractComboViewModel("CCP","청산소"));
            ProgramVariable.ContractComboDisplayStrList_.Add(new ContractComboViewModel("ABCP","ABCP"));
            ProgramVariable.ContractComboDisplayStrList_.Add(new ContractComboViewModel("ELS", "ELS"));
            ProgramVariable.ContractComboDisplayStrList_.Add(new ContractComboViewModel("ELB", "ELB"));
            ProgramVariable.ContractComboDisplayStrList_.Add(new ContractComboViewModel("DLS", "DLS"));
            ProgramVariable.ContractComboDisplayStrList_.Add(new ContractComboViewModel("DLB", "DLB"));
            ProgramVariable.ContractComboDisplayStrList_.Add(new ContractComboViewModel("Fund", "Fund"));
            ProgramVariable.ContractComboDisplayStrList_.Add(new ContractComboViewModel("Deposite", "예금"));
            ProgramVariable.ContractComboDisplayStrList_.Add(new ContractComboViewModel("Trust", "신탁"));

            for (int i = 0; i < ProgramVariable.ContractComboDisplayStrList_.Count; i++)
            {
                ProgramVariable.ContractComboDisplayStrList_[i].SelectedIndex_ = i;
            }

        }

        public static void initialize_ContractSubComboStringList()
        {
            ProgramVariable.ContractSubComboDisplayStrList_ = new ObservableCollection<ContractSubComboViewModel>();

            ProgramVariable.ContractSubComboDisplayStrList_.Add(new ContractSubComboViewModel("Option","옵션"));
            ProgramVariable.ContractSubComboDisplayStrList_.Add(new ContractSubComboViewModel("Swap","스왑"));
            ProgramVariable.ContractSubComboDisplayStrList_.Add(new ContractSubComboViewModel("Forward","포워드"));
            ProgramVariable.ContractSubComboDisplayStrList_.Add(new ContractSubComboViewModel("Futures","선물"));
            ProgramVariable.ContractSubComboDisplayStrList_.Add(new ContractSubComboViewModel("Bond", "채권"));

            for (int i = 0; i < ProgramVariable.ContractSubComboDisplayStrList_.Count; i++)
            {
                ProgramVariable.ContractSubComboDisplayStrList_[i].SelectedIndex_ = i;
            }

        }



        //public static void initialize_ContractDetailComboStringList()
        //{
        //    ProgramVariable.CurrencyStringList_ = new ObservableCollection<CurrencyViewModel>();

        //    ProgramVariable.CurrencyStringList_.Add(new CurrencyViewModel("KRW"));
        //    ProgramVariable.CurrencyStringList_.Add(new CurrencyViewModel("USD"));
        //    ProgramVariable.CurrencyStringList_.Add(new CurrencyViewModel("EUR"));
        //    ProgramVariable.CurrencyStringList_.Add(new CurrencyViewModel("CNH"));
        //}
    }
}
