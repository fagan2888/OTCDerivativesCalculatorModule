// StubCalculationPeriodAmount.cpp 
#include "StubCalculationPeriodAmount.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

StubCalculationPeriodAmount::StubCalculationPeriodAmount(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //calculationPeriodDatesReferenceNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* calculationPeriodDatesReferenceNode = xmlNode->FirstChildElement("calculationPeriodDatesReference");

   if(calculationPeriodDatesReferenceNode){calculationPeriodDatesReferenceIsNull_ = false;}
   else{calculationPeriodDatesReferenceIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationPeriodDatesReferenceNode , address : " << calculationPeriodDatesReferenceNode << std::endl;
   #endif
   if(calculationPeriodDatesReferenceNode)
   {
      if(calculationPeriodDatesReferenceNode->Attribute("href") || calculationPeriodDatesReferenceNode->Attribute("id"))
      {
          if(calculationPeriodDatesReferenceNode->Attribute("id"))
          {
             calculationPeriodDatesReferenceIDRef_ = calculationPeriodDatesReferenceNode->Attribute("id");
             calculationPeriodDatesReference_ = boost::shared_ptr<CalculationPeriodDatesReference>(new CalculationPeriodDatesReference(calculationPeriodDatesReferenceNode));
             calculationPeriodDatesReference_->setID(calculationPeriodDatesReferenceIDRef_);
             IDManager::instance().setID(calculationPeriodDatesReferenceIDRef_,calculationPeriodDatesReference_);
          }
          else if(calculationPeriodDatesReferenceNode->Attribute("href")) { calculationPeriodDatesReferenceIDRef_ = calculationPeriodDatesReferenceNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { calculationPeriodDatesReference_ = boost::shared_ptr<CalculationPeriodDatesReference>(new CalculationPeriodDatesReference(calculationPeriodDatesReferenceNode));}
   }

   //initialStubNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* initialStubNode = xmlNode->FirstChildElement("initialStub");

   if(initialStubNode){initialStubIsNull_ = false;}
   else{initialStubIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- initialStubNode , address : " << initialStubNode << std::endl;
   #endif
   if(initialStubNode)
   {
      if(initialStubNode->Attribute("href") || initialStubNode->Attribute("id"))
      {
          if(initialStubNode->Attribute("id"))
          {
             initialStubIDRef_ = initialStubNode->Attribute("id");
             initialStub_ = boost::shared_ptr<StubValue>(new StubValue(initialStubNode));
             initialStub_->setID(initialStubIDRef_);
             IDManager::instance().setID(initialStubIDRef_,initialStub_);
          }
          else if(initialStubNode->Attribute("href")) { initialStubIDRef_ = initialStubNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { initialStub_ = boost::shared_ptr<StubValue>(new StubValue(initialStubNode));}
   }

   //finalStubNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* finalStubNode = xmlNode->FirstChildElement("finalStub");

   if(finalStubNode){finalStubIsNull_ = false;}
   else{finalStubIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- finalStubNode , address : " << finalStubNode << std::endl;
   #endif
   if(finalStubNode)
   {
      if(finalStubNode->Attribute("href") || finalStubNode->Attribute("id"))
      {
          if(finalStubNode->Attribute("id"))
          {
             finalStubIDRef_ = finalStubNode->Attribute("id");
             finalStub_ = boost::shared_ptr<StubValue>(new StubValue(finalStubNode));
             finalStub_->setID(finalStubIDRef_);
             IDManager::instance().setID(finalStubIDRef_,finalStub_);
          }
          else if(finalStubNode->Attribute("href")) { finalStubIDRef_ = finalStubNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { finalStub_ = boost::shared_ptr<StubValue>(new StubValue(finalStubNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<CalculationPeriodDatesReference> StubCalculationPeriodAmount::getCalculationPeriodDatesReference()
{
   if(!this->calculationPeriodDatesReferenceIsNull_){
        if(calculationPeriodDatesReferenceIDRef_ != ""){
             return boost::shared_static_cast<CalculationPeriodDatesReference>(IDManager::instance().getID(calculationPeriodDatesReferenceIDRef_));
        }else{
             return this->calculationPeriodDatesReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<CalculationPeriodDatesReference>();
   }
}
boost::shared_ptr<StubValue> StubCalculationPeriodAmount::getInitialStub()
{
   if(!this->initialStubIsNull_){
        if(initialStubIDRef_ != ""){
             return boost::shared_static_cast<StubValue>(IDManager::instance().getID(initialStubIDRef_));
        }else{
             return this->initialStub_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<StubValue>();
   }
}
boost::shared_ptr<StubValue> StubCalculationPeriodAmount::getFinalStub()
{
   if(!this->finalStubIsNull_){
        if(finalStubIDRef_ != ""){
             return boost::shared_static_cast<StubValue>(IDManager::instance().getID(finalStubIDRef_));
        }else{
             return this->finalStub_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<StubValue>();
   }
}
}

