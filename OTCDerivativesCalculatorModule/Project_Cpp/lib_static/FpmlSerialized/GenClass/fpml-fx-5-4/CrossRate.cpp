// CrossRate.cpp 
#include "CrossRate.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

CrossRate::CrossRate(TiXmlNode* xmlNode)
: QuotedCurrencyPair(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //rateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* rateNode = xmlNode->FirstChildElement("rate");

   if(rateNode){rateIsNull_ = false;}
   else{rateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- rateNode , address : " << rateNode << std::endl;
   #endif
   if(rateNode)
   {
      if(rateNode->Attribute("href") || rateNode->Attribute("id"))
      {
          if(rateNode->Attribute("id"))
          {
             rateIDRef_ = rateNode->Attribute("id");
             rate_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(rateNode));
             rate_->setID(rateIDRef_);
             IDManager::instance().setID(rateIDRef_,rate_);
          }
          else if(rateNode->Attribute("href")) { rateIDRef_ = rateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { rate_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(rateNode));}
   }

   //spotRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* spotRateNode = xmlNode->FirstChildElement("spotRate");

   if(spotRateNode){spotRateIsNull_ = false;}
   else{spotRateIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- spotRateNode , address : " << spotRateNode << std::endl;
   #endif
   if(spotRateNode)
   {
      if(spotRateNode->Attribute("href") || spotRateNode->Attribute("id"))
      {
          if(spotRateNode->Attribute("id"))
          {
             spotRateIDRef_ = spotRateNode->Attribute("id");
             spotRate_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(spotRateNode));
             spotRate_->setID(spotRateIDRef_);
             IDManager::instance().setID(spotRateIDRef_,spotRate_);
          }
          else if(spotRateNode->Attribute("href")) { spotRateIDRef_ = spotRateNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { spotRate_ = boost::shared_ptr<PositiveDecimal>(new PositiveDecimal(spotRateNode));}
   }

   //forwardPointsNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* forwardPointsNode = xmlNode->FirstChildElement("forwardPoints");

   if(forwardPointsNode){forwardPointsIsNull_ = false;}
   else{forwardPointsIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- forwardPointsNode , address : " << forwardPointsNode << std::endl;
   #endif
   if(forwardPointsNode)
   {
      if(forwardPointsNode->Attribute("href") || forwardPointsNode->Attribute("id"))
      {
          if(forwardPointsNode->Attribute("id"))
          {
             forwardPointsIDRef_ = forwardPointsNode->Attribute("id");
             forwardPoints_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(forwardPointsNode));
             forwardPoints_->setID(forwardPointsIDRef_);
             IDManager::instance().setID(forwardPointsIDRef_,forwardPoints_);
          }
          else if(forwardPointsNode->Attribute("href")) { forwardPointsIDRef_ = forwardPointsNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { forwardPoints_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(forwardPointsNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<PositiveDecimal> CrossRate::getRate()
{
   if(!this->rateIsNull_){
        if(rateIDRef_ != ""){
             return boost::shared_static_cast<PositiveDecimal>(IDManager::instance().getID(rateIDRef_));
        }else{
             return this->rate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositiveDecimal>();
   }
}
boost::shared_ptr<PositiveDecimal> CrossRate::getSpotRate()
{
   if(!this->spotRateIsNull_){
        if(spotRateIDRef_ != ""){
             return boost::shared_static_cast<PositiveDecimal>(IDManager::instance().getID(spotRateIDRef_));
        }else{
             return this->spotRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PositiveDecimal>();
   }
}
boost::shared_ptr<XsdTypeDecimal> CrossRate::getForwardPoints()
{
   if(!this->forwardPointsIsNull_){
        if(forwardPointsIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(forwardPointsIDRef_));
        }else{
             return this->forwardPoints_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
}

