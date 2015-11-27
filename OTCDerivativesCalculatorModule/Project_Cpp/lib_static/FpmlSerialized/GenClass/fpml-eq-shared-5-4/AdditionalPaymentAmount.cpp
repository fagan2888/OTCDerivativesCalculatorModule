// AdditionalPaymentAmount.cpp 
#include "AdditionalPaymentAmount.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

AdditionalPaymentAmount::AdditionalPaymentAmount(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //paymentAmountNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* paymentAmountNode = xmlNode->FirstChildElement("paymentAmount");

   if(paymentAmountNode){paymentAmountIsNull_ = false;}
   else{paymentAmountIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- paymentAmountNode , address : " << paymentAmountNode << std::endl;
   #endif
   if(paymentAmountNode)
   {
      if(paymentAmountNode->Attribute("href") || paymentAmountNode->Attribute("id"))
      {
          if(paymentAmountNode->Attribute("id"))
          {
             paymentAmountIDRef_ = paymentAmountNode->Attribute("id");
             paymentAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(paymentAmountNode));
             paymentAmount_->setID(paymentAmountIDRef_);
             IDManager::instance().setID(paymentAmountIDRef_,paymentAmount_);
          }
          else if(paymentAmountNode->Attribute("href")) { paymentAmountIDRef_ = paymentAmountNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { paymentAmount_ = boost::shared_ptr<NonNegativeMoney>(new NonNegativeMoney(paymentAmountNode));}
   }

   //formulaNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* formulaNode = xmlNode->FirstChildElement("formula");

   if(formulaNode){formulaIsNull_ = false;}
   else{formulaIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- formulaNode , address : " << formulaNode << std::endl;
   #endif
   if(formulaNode)
   {
      if(formulaNode->Attribute("href") || formulaNode->Attribute("id"))
      {
          if(formulaNode->Attribute("id"))
          {
             formulaIDRef_ = formulaNode->Attribute("id");
             formula_ = boost::shared_ptr<Formula>(new Formula(formulaNode));
             formula_->setID(formulaIDRef_);
             IDManager::instance().setID(formulaIDRef_,formula_);
          }
          else if(formulaNode->Attribute("href")) { formulaIDRef_ = formulaNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { formula_ = boost::shared_ptr<Formula>(new Formula(formulaNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<NonNegativeMoney> AdditionalPaymentAmount::getPaymentAmount()
{
   if(!this->paymentAmountIsNull_){
        if(paymentAmountIDRef_ != ""){
             return boost::shared_static_cast<NonNegativeMoney>(IDManager::instance().getID(paymentAmountIDRef_));
        }else{
             return this->paymentAmount_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<NonNegativeMoney>();
   }
}
boost::shared_ptr<Formula> AdditionalPaymentAmount::getFormula()
{
   if(!this->formulaIsNull_){
        if(formulaIDRef_ != ""){
             return boost::shared_static_cast<Formula>(IDManager::instance().getID(formulaIDRef_));
        }else{
             return this->formula_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Formula>();
   }
}
}

