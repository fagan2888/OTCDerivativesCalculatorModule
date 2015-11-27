using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using XmlBuilder.Ctrl;
using XmlBuilder.Views.StructuredProduct.ViewModel;
using System.Xml;

namespace XmlBuilder.Views.StructuredProduct.ViewModel
{
    public class MinimumViewModel : IXmlBuild
    {
        public MinimumViewModel(FpmlSerializedCSharp.MinimumTran serial_mt)
        {
            this.serial_mt_ = serial_mt;
            this.buildFromSerialClass();
        }

        private void buildFromSerialClass()
        {
            this.variableModelList_ = new ObservableCollection<VariableModel>();

            foreach (FpmlSerializedCSharp.VariableValue item in serial_mt_.Variable_)
            {
                this.variableModelList_.Add(new VariableModel(item));
            }
        }

        public void buildXml(XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("minimum");

            foreach (VariableModel item in this.variableModelList_)
            {
                xmlWriter.WriteStartElement("variable");
                    item.buildXml(xmlWriter);
                xmlWriter.WriteEndElement();
            }

            xmlWriter.WriteEndElement();

        }

        public FpmlSerializedCSharp.MinimumTran serial_mt_ { get; set; }

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
    }
}
