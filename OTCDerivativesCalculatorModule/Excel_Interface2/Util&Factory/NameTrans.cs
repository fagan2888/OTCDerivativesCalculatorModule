using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    public class NameTrans
    {
        public enum Langauage 
        {
            KOREAN,
            ENGLISH,

        };

        public static Langauage LangauageSetting = Langauage.KOREAN;

        #region Value_
        private string value_;
        public string Value_
        {
            get { return this.value_; }
            private set
            {
                if (this.value_ != value)
                {
                    this.value_ = value;
                }
            }
        }
        #endregion

        #region TransValue_
        private string transValue_;
        public string TransValue_
        {
            get 
            {
                return this.trans(); 
            }
            set
            {
                if (this.transValue_ != value)
                {
                    this.transValue_ = value;
                }
            }
        }
        #endregion

        public NameTrans(string value)
        {
            this.value_ = value;

            this.transValue_ = value;
        }

        public void changeTransLang(Langauage lang)
        { 
            //this.transValue_ = 
        }

        public string trans()
        {
            return this.transValue_;
        }


    }
}
