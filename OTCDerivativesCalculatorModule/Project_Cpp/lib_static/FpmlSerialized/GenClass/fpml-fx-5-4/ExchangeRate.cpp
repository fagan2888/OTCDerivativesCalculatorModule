// ExchangeRate.cpp 
#include "ExchangeRate.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

ExchangeRate::ExchangeRate(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //quotedCurrencyPairNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* quotedCurrencyPairNode = xmlNode->FirstChildElement("quotedCurrencyPair");

   if(quotedCurrencyPairNode){quotedCurrencyPairIsNull_ = false;}
   else{quotedCurrencyPairIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- quotedCurrencyPairNode , address : " << quotedCurrencyPairNode << std::endl;
   #endif
   if(quotedCurrencyPairNode)
   {
      if(quotedCurrencyPairNode->Attribute("href") || quotedCurrencyPairNode->Attribute("id"))
      {
          if(quotedCurrencyPairNode->Attribute("id"))
          {
             quotedCurrencyPairIDRef_ = quotedCurrencyPairNode->Attribute("id");
             quotedCurrencyPair_ = boost::shared_ptr<QuotedCurrencyPair>(new QuotedCurrencyPair(quotedCurrencyPairNode));
             quotedCurrencyPair_->setID(quotedCurrencyPairIDRef_);
             IDManager::instance().setID(quotedCurrencyPairIDRef_,quotedCurrencyPair_);
          }
          else if(quotedCurrencyPairNode->Attribute("href")) { quotedCurrencyPairIDRef_ = quotedCurrencyPairNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { quotedCurrencyPair_ = boost::shared_ptr<QuotedCurrencyPair>(new QuotedCurrencyPair(quotedCurrencyPairNode));}
   }

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

   //pointValueNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* pointValueNode = xmlNode->FirstChildElement("pointValue");

   if(pointValueNode){pointValueIsNull_ = false;}
   else{pointValueIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- pointValueNode , address : " << pointValueNode << std::endl;
   #endif
   if(pointValueNode)
   {
      if(pointValueNode->Attribute("href") || pointValueNode->Attribute("id"))
      {
          if(pointValueNode->Attribute("id"))
          {
             pointValueIDRef_ = pointValueNode->Attribute("id");
             pointValue_ = boost::shared_ptr<PointValue>(new PointValue(pointValueNode));
             pointValue_->setID(pointValueIDRef_);
             IDManager::instance().setID(pointValueIDRef_,pointValue_);
          }
          else if(pointValueNode->Attribute("href")) { pointValueIDRef_ = pointValueNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { pointValue_ = boost::shared_ptr<PointValue>(new PointValue(pointValueNode));}
   }

   //crossRateNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* crossRateNode = xmlNode->FirstChildElement("crossRate");

   if(crossRateNode){crossRateIsNull_ = false;}
   else{crossRateIsNull_ = true;}

   if(crossRateNode)
   {
      for(crossRateNode; crossRateNode; crossRateNode = crossRateNode->NextSiblingElement("crossRate")){
          #ifdef ConsolePrint
              FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- crossRateNode , address : " << crossRateNode << std::endl;
          #endif
          if(crossRateNode->Attribute("href") || crossRateNode->Attribute("id"))
          {
              if(crossRateNode->Attribute("id"))
              {
                  crossRateIDRef_ = crossRateNode->Attribute("id");
                  crossRate_.push_back(boost::shared_ptr<CrossRate>(new CrossRate(crossRateNode)));
                  crossRate_.back()->setID(crossRateIDRef_);
                  IDManager::instance().setID(crossRateIDRef_, crossRate_.back());
              }
              else if(crossRateNode->Attribute("href")) { crossRateIDRef_ = crossRateNode->Attribute("href");}
              else { QL_FAIL("id or href error"); }
          }
          else { crossRate_.push_back(boost::shared_ptr<CrossRate>(new CrossRate(crossRateNode)));}
      }
   }
   else {
       #ifdef ConsolePrint
           FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- crossRateNode , address : " << crossRateNode << std::endl;
       #endif
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<QuotedCurrencyPair> ExchangeRate::getQuotedCurrencyPair()
{
   if(!this->quotedCurrencyPairIsNull_){
        if(quotedCurrencyPairIDRef_ != ""){
             return boost::shared_static_cast<QuotedCurrencyPair>(IDManager::instance().getID(quotedCurrencyPairIDRef_));
        }else{
             return this->quotedCurrencyPair_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<QuotedCurrencyPair>();
   }
}
boost::shared_ptr<PositiveDecimal> ExchangeRate::getRate()
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
boost::shared_ptr<PositiveDecimal> ExchangeRate::getSpotRate()
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
boost::shared_ptr<XsdTypeDecimal> ExchangeRate::getForwardPoints()
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
boost::shared_ptr<PointValue> ExchangeRate::getPointValue()
{
   if(!this->pointValueIsNull_){
        if(pointValueIDRef_ != ""){
             return boost::shared_static_cast<PointValue>(IDManager::instance().getID(pointValueIDRef_));
        }else{
             return this->pointValue_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PointValue>();
   }
}
std::vector<boost::shared_ptr<CrossRate>> ExchangeRate::getCrossRate()
{
   if(!this->crossRateIsNull_){
        if(crossRateIDRef_ != ""){
             return this->crossRate_;
        }else{
             return this->crossRate_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return std::vector<boost::shared_ptr<CrossRate>>();
   }
}
}

