// SwapPayoffInfoAnalytic.cpp 
#include "SwapPayoffInfoAnalytic.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

SwapPayoffInfoAnalytic::SwapPayoffInfoAnalytic(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //typeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* typeNode = xmlNode->FirstChildElement("type");

   if(typeNode){typeIsNull_ = false;}
   else{typeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- typeNode , address : " << typeNode << std::endl;
   #endif
   if(typeNode)
   {
       type_ = boost::shared_ptr<XsdTypeToken>(new XsdTypeToken(typeNode));
   }

   //interestRateSwapPayoff_ANode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* interestRateSwapPayoff_ANode = xmlNode->FirstChildElement("interestRateSwapPayoff_A");

   if(interestRateSwapPayoff_ANode){interestRateSwapPayoff_AIsNull_ = false;}
   else{interestRateSwapPayoff_AIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- interestRateSwapPayoff_ANode , address : " << interestRateSwapPayoff_ANode << std::endl;
   #endif
   if(interestRateSwapPayoff_ANode)
   {
       interestRateSwapPayoff_A_ = boost::shared_ptr<InterestRateSwapPayoff_A>(new InterestRateSwapPayoff_A(interestRateSwapPayoff_ANode));
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<XsdTypeToken> SwapPayoffInfoAnalytic::getType()
{
   if(!this->typeIsNull_){
        return this->type_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeToken>();
   }
}
boost::shared_ptr<InterestRateSwapPayoff_A> SwapPayoffInfoAnalytic::getInterestRateSwapPayoff_A()
{
   if(!this->interestRateSwapPayoff_AIsNull_){
        return this->interestRateSwapPayoff_A_;
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<InterestRateSwapPayoff_A>();
   }
}
}

