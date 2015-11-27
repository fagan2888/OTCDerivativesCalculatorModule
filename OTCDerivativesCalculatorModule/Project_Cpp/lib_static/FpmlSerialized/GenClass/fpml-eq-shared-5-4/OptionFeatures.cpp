// OptionFeatures.cpp 
#include "OptionFeatures.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

OptionFeatures::OptionFeatures(TiXmlNode* xmlNode)
: ISerialized(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
   //asianNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* asianNode = xmlNode->FirstChildElement("asian");

   if(asianNode){asianIsNull_ = false;}
   else{asianIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- asianNode , address : " << asianNode << std::endl;
   #endif
   if(asianNode)
   {
      if(asianNode->Attribute("href") || asianNode->Attribute("id"))
      {
          if(asianNode->Attribute("id"))
          {
             asianIDRef_ = asianNode->Attribute("id");
             asian_ = boost::shared_ptr<Asian>(new Asian(asianNode));
             asian_->setID(asianIDRef_);
             IDManager::instance().setID(asianIDRef_,asian_);
          }
          else if(asianNode->Attribute("href")) { asianIDRef_ = asianNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { asian_ = boost::shared_ptr<Asian>(new Asian(asianNode));}
   }

   //barrierNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* barrierNode = xmlNode->FirstChildElement("barrier");

   if(barrierNode){barrierIsNull_ = false;}
   else{barrierIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- barrierNode , address : " << barrierNode << std::endl;
   #endif
   if(barrierNode)
   {
      if(barrierNode->Attribute("href") || barrierNode->Attribute("id"))
      {
          if(barrierNode->Attribute("id"))
          {
             barrierIDRef_ = barrierNode->Attribute("id");
             barrier_ = boost::shared_ptr<Barrier>(new Barrier(barrierNode));
             barrier_->setID(barrierIDRef_);
             IDManager::instance().setID(barrierIDRef_,barrier_);
          }
          else if(barrierNode->Attribute("href")) { barrierIDRef_ = barrierNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { barrier_ = boost::shared_ptr<Barrier>(new Barrier(barrierNode));}
   }

   //knockNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* knockNode = xmlNode->FirstChildElement("knock");

   if(knockNode){knockIsNull_ = false;}
   else{knockIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- knockNode , address : " << knockNode << std::endl;
   #endif
   if(knockNode)
   {
      if(knockNode->Attribute("href") || knockNode->Attribute("id"))
      {
          if(knockNode->Attribute("id"))
          {
             knockIDRef_ = knockNode->Attribute("id");
             knock_ = boost::shared_ptr<Knock>(new Knock(knockNode));
             knock_->setID(knockIDRef_);
             IDManager::instance().setID(knockIDRef_,knock_);
          }
          else if(knockNode->Attribute("href")) { knockIDRef_ = knockNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { knock_ = boost::shared_ptr<Knock>(new Knock(knockNode));}
   }

   //passThroughNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* passThroughNode = xmlNode->FirstChildElement("passThrough");

   if(passThroughNode){passThroughIsNull_ = false;}
   else{passThroughIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- passThroughNode , address : " << passThroughNode << std::endl;
   #endif
   if(passThroughNode)
   {
      if(passThroughNode->Attribute("href") || passThroughNode->Attribute("id"))
      {
          if(passThroughNode->Attribute("id"))
          {
             passThroughIDRef_ = passThroughNode->Attribute("id");
             passThrough_ = boost::shared_ptr<PassThrough>(new PassThrough(passThroughNode));
             passThrough_->setID(passThroughIDRef_);
             IDManager::instance().setID(passThroughIDRef_,passThrough_);
          }
          else if(passThroughNode->Attribute("href")) { passThroughIDRef_ = passThroughNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { passThrough_ = boost::shared_ptr<PassThrough>(new PassThrough(passThroughNode));}
   }

   //dividendAdjustmentNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* dividendAdjustmentNode = xmlNode->FirstChildElement("dividendAdjustment");

   if(dividendAdjustmentNode){dividendAdjustmentIsNull_ = false;}
   else{dividendAdjustmentIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- dividendAdjustmentNode , address : " << dividendAdjustmentNode << std::endl;
   #endif
   if(dividendAdjustmentNode)
   {
      if(dividendAdjustmentNode->Attribute("href") || dividendAdjustmentNode->Attribute("id"))
      {
          if(dividendAdjustmentNode->Attribute("id"))
          {
             dividendAdjustmentIDRef_ = dividendAdjustmentNode->Attribute("id");
             dividendAdjustment_ = boost::shared_ptr<DividendAdjustment>(new DividendAdjustment(dividendAdjustmentNode));
             dividendAdjustment_->setID(dividendAdjustmentIDRef_);
             IDManager::instance().setID(dividendAdjustmentIDRef_,dividendAdjustment_);
          }
          else if(dividendAdjustmentNode->Attribute("href")) { dividendAdjustmentIDRef_ = dividendAdjustmentNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { dividendAdjustment_ = boost::shared_ptr<DividendAdjustment>(new DividendAdjustment(dividendAdjustmentNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<Asian> OptionFeatures::getAsian()
{
   if(!this->asianIsNull_){
        if(asianIDRef_ != ""){
             return boost::shared_static_cast<Asian>(IDManager::instance().getID(asianIDRef_));
        }else{
             return this->asian_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Asian>();
   }
}
boost::shared_ptr<Barrier> OptionFeatures::getBarrier()
{
   if(!this->barrierIsNull_){
        if(barrierIDRef_ != ""){
             return boost::shared_static_cast<Barrier>(IDManager::instance().getID(barrierIDRef_));
        }else{
             return this->barrier_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Barrier>();
   }
}
boost::shared_ptr<Knock> OptionFeatures::getKnock()
{
   if(!this->knockIsNull_){
        if(knockIDRef_ != ""){
             return boost::shared_static_cast<Knock>(IDManager::instance().getID(knockIDRef_));
        }else{
             return this->knock_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Knock>();
   }
}
boost::shared_ptr<PassThrough> OptionFeatures::getPassThrough()
{
   if(!this->passThroughIsNull_){
        if(passThroughIDRef_ != ""){
             return boost::shared_static_cast<PassThrough>(IDManager::instance().getID(passThroughIDRef_));
        }else{
             return this->passThrough_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<PassThrough>();
   }
}
boost::shared_ptr<DividendAdjustment> OptionFeatures::getDividendAdjustment()
{
   if(!this->dividendAdjustmentIsNull_){
        if(dividendAdjustmentIDRef_ != ""){
             return boost::shared_static_cast<DividendAdjustment>(IDManager::instance().getID(dividendAdjustmentIDRef_));
        }else{
             return this->dividendAdjustment_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DividendAdjustment>();
   }
}
}

