// DateRelativeToCalculationPeriodDates.cpp 
#include "DateRelativeToCalculationPeriodDates.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DateRelativeToCalculationPeriodDates::DateRelativeToCalculationPeriodDates(TiXmlNode* xmlNode)
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

   if(calculationPeriodDatesReferenceNode)
   {
      for(calculationPeriodDatesReferenceNode; calculationPeriodDatesReferenceNode; calculationPeriodDatesReferenceNode = calculationPeriodDatesReferenceNode->NextSiblingElement("calculationPeriodDatesReference")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationPeriodDatesReferenceNode , address : " << calculationPeriodDatesReferenceNode << std::endl;
          #endif
          if(calculationPeriodDatesReferenceNode->Attribute("href") || calculationPeriodDatesReferenceNode->Attribute("id"))
          {
              if(calculationPeriodDatesReferenceNode->Attribute("id"))
              {
                  calculationPeriodDatesReferenceIDRef_ = calculationPeriodDatesReferenceNode->Attribute("id");
                  calculationPeriodDatesReference_.push_back(boost::shared_ptr<CalculationPeriodDatesReference>(new CalculationPeriodDatesReference(calculationPeriodDatesReferenceNode)));
                  calculationPeriodDatesReference_.back()->setID(calculationPeriodDatesReferenceIDRef_);
                  IDManager::instance().setID(calculationPeriodDatesReferenceIDRef_, calculationPeriodDatesReference_.back());
              }
              else if(calculationPeriodDatesReferenceNode->Attribute("href")) { calculationPeriodDatesReferenceIDRef_ = calculationPeriodDatesReferenceNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { calculationPeriodDatesReference_.push_back(boost::shared_ptr<CalculationPeriodDatesReference>(new CalculationPeriodDatesReference(calculationPeriodDatesReferenceNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- calculationPeriodDatesReferenceNode , address : " << calculationPeriodDatesReferenceNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
std::vector<boost::shared_ptr<CalculationPeriodDatesReference>> DateRelativeToCalculationPeriodDates::getCalculationPeriodDatesReference()
{
   if(!this->calculationPeriodDatesReferenceIsNull_){
        if(calculationPeriodDatesReferenceIDRef_ != ""){
             return this->calculationPeriodDatesReference_;
        }else{
             return this->calculationPeriodDatesReference_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<CalculationPeriodDatesReference>>();
   }
}
}

