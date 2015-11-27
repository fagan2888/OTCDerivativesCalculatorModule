using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Xml;
using XmlBuilder.Ctrl;
using XmlBuilder.Views.StructuredProduct.ViewModel;

namespace XmlBuilder.Views.StructuredProduct.ViewModel
{
    public class ReturnCtrlViewModel : IXmlBuild
    {

        public ReturnCtrlViewModel(FpmlSerializedCSharp.ReturnTran returnTran)
        {
            // TODO: Complete member initialization
            this.returnTran_ = returnTran;
            this.buildFromSerialClass();

        }

        private void buildFromSerialClass() 
        {
            this.variableModelList_ = new ObservableCollection<VariableModel>();

            this.variableModelList_.Add(new VariableModel(returnTran_.DenumerCalculation_));
            this.variableModelList_.Add(new VariableModel(returnTran_.NumerCalculation_));

        }

        private FpmlSerializedCSharp.ReturnTran returnTran_;

        #region VariableModelList_
        private ObservableCollection<VariableModel> variableModelList_;
        public ObservableCollection<VariableModel> VariableModelList_
        {
            get { return this.variableModelList_; }
            set
            {
                if (this.variableModelList_ != value)
                {
                    this.variableModelList_ = value;
                    this.NotifyPropertyChanged("VariableModelList_");
                }
            }
        }
        #endregion


        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void buildXml(XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("return");

                xmlWriter.WriteStartElement("numerCalculation");
                    variableModelList_[0].buildXml(xmlWriter);
                xmlWriter.WriteEndElement();
            
                xmlWriter.WriteStartElement("deNumerCalculation");
                    variableModelList_[0].buildXml(xmlWriter);
                xmlWriter.WriteEndElement();

            xmlWriter.WriteEndElement();

        }
    }
}
