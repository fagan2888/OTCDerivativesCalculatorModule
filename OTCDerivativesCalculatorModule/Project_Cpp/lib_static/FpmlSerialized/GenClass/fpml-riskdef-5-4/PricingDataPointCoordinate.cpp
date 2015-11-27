// PricingDataPointCoordinate.cpp 
#include "PricingDataPointCoordinate.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

PricingDataPointCoordinate::PricingDataPointCoordinate(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //termNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* termNode = xmlNode->FirstChildElement("term");

   if(termNode){termIsNull_ = false;}
   else{termIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- termNode , address : " << termNode << std::endl;
   #endif
   if(termNode)
   {
      if(termNode->Attribute("href") || termNode->Attribute("id"))
      {
          if(termNode->Attribute("id"))
          {
             termIDRef_ = termNode->Attribute("id");
             term_ = boost::shared_ptr<TimeDimension>(new TimeDimension(termNode));
             term_->setID(termIDRef_);
             IDManager::instance().setID(termIDRef_,term_);
          }
          else if(termNode->Attribute("href")) { termIDRef_ = termNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { term_ = boost::shared_ptr<TimeDimension>(new TimeDimension(termNode));}
   }

   //expirationNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* expirationNode = xmlNode->FirstChildElement("expiration");

   if(expirationNode){expirationIsNull_ = false;}
   else{expirationIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- expirationNode , address : " << expirationNode << std::endl;
   #endif
   if(expirationNode)
   {
      if(expirationNode->Attribute("href") || expirationNode->Attribute("id"))
      {
          if(expirationNode->Attribute("id"))
          {
             expirationIDRef_ = expirationNode->Attribute("id");
             expiration_ = boost::shared_ptr<TimeDimension>(new TimeDimension(expirationNode));
             expiration_->setID(expirationIDRef_);
             IDManager::instance().setID(expirationIDRef_,expiration_);
          }
          else if(expirationNode->Attribute("href")) { expirationIDRef_ = expirationNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { expiration_ = boost::shared_ptr<TimeDimension>(new TimeDimension(expirationNode));}
   }

   //strikeNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* strikeNode = xmlNode->FirstChildElement("strike");

   if(strikeNode){strikeIsNull_ = false;}
   else{strikeIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- strikeNode , address : " << strikeNode << std::endl;
   #endif
   if(strikeNode)
   {
      if(strikeNode->Attribute("href") || strikeNode->Attribute("id"))
      {
          if(strikeNode->Attribute("id"))
          {
             strikeIDRef_ = strikeNode->Attribute("id");
             strike_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(strikeNode));
             strike_->setID(strikeIDRef_);
             IDManager::instance().setID(strikeIDRef_,strike_);
          }
          else if(strikeNode->Attribute("href")) { strikeIDRef_ = strikeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { strike_ = boost::shared_ptr<XsdTypeDecimal>(new XsdTypeDecimal(strikeNode));}
   }

   //genericNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* genericNode = xmlNode->FirstChildElement("generic");

   if(genericNode){genericIsNull_ = false;}
   else{genericIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- genericNode , address : " << genericNode << std::endl;
   #endif
   if(genericNode)
   {
      if(genericNode->Attribute("href") || genericNode->Attribute("id"))
      {
          if(genericNode->Attribute("id"))
          {
             genericIDRef_ = genericNode->Attribute("id");
             generic_ = boost::shared_ptr<GenericDimension>(new GenericDimension(genericNode));
             generic_->setID(genericIDRef_);
             IDManager::instance().setID(genericIDRef_,generic_);
          }
          else if(genericNode->Attribute("href")) { genericIDRef_ = genericNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { generic_ = boost::shared_ptr<GenericDimension>(new GenericDimension(genericNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<TimeDimension> PricingDataPointCoordinate::getTerm()
{
   if(!this->termIsNull_){
        if(termIDRef_ != ""){
             return boost::shared_static_cast<TimeDimension>(IDManager::instance().getID(termIDRef_));
        }else{
             return this->term_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TimeDimension>();
   }
}
boost::shared_ptr<TimeDimension> PricingDataPointCoordinate::getExpiration()
{
   if(!this->expirationIsNull_){
        if(expirationIDRef_ != ""){
             return boost::shared_static_cast<TimeDimension>(IDManager::instance().getID(expirationIDRef_));
        }else{
             return this->expiration_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<TimeDimension>();
   }
}
boost::shared_ptr<XsdTypeDecimal> PricingDataPointCoordinate::getStrike()
{
   if(!this->strikeIsNull_){
        if(strikeIDRef_ != ""){
             return boost::shared_static_cast<XsdTypeDecimal>(IDManager::instance().getID(strikeIDRef_));
        }else{
             return this->strike_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<XsdTypeDecimal>();
   }
}
boost::shared_ptr<GenericDimension> PricingDataPointCoordinate::getGeneric()
{
   if(!this->genericIsNull_){
        if(genericIDRef_ != ""){
             return boost::shared_static_cast<GenericDimension>(IDManager::instance().getID(genericIDRef_));
        }else{
             return this->generic_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<GenericDimension>();
   }
}
}

