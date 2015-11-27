using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace ExcelInterface
{
    public abstract class EventTriggerXL
    {
        #region ReferenceCalFactory_
        protected ReferenceCalFactory referenceCalFactory_;
        public ReferenceCalFactory ReferenceCalFactory_
        {
            get { return this.referenceCalFactory_; }
            set
            {
                if (this.referenceCalFactory_ != value)
                {
                    this.referenceCalFactory_ = value;
                }
            }
        }
        #endregion

        public abstract void buildVM();
        public abstract void buildXml(XmlWriter xmlWriter);

        //public void setAutoCallable(string[] array)
        //{

        //}

    }
}
