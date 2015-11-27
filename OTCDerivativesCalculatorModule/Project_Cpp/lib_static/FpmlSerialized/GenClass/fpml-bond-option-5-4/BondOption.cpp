// BondOption.cpp 
#include "BondOption.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

BondOption::BondOption(TiXmlNode* xmlNode)
: OptionBaseExtended(xmlNode)
{
    #ifdef ConsolePrint
        std::string initialtap_ = FileManager::instance().tap_;
        FileManager::instance().tap_.append("   ");
    #endif 
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
             strike_ = boost::shared_ptr<BondOptionStrike>(new BondOptionStrike(strikeNode));
             strike_->setID(strikeIDRef_);
             IDManager::instance().setID(strikeIDRef_,strike_);
          }
          else if(strikeNode->Attribute("href")) { strikeIDRef_ = strikeNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { strike_ = boost::shared_ptr<BondOptionStrike>(new BondOptionStrike(strikeNode));}
   }

   //bondNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* bondNode = xmlNode->FirstChildElement("bond");

   if(bondNode){bondIsNull_ = false;}
   else{bondIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- bondNode , address : " << bondNode << std::endl;
   #endif
   if(bondNode)
   {
      if(bondNode->Attribute("href") || bondNode->Attribute("id"))
      {
          if(bondNode->Attribute("id"))
          {
             bondIDRef_ = bondNode->Attribute("id");
             bond_ = boost::shared_ptr<Bond>(new Bond(bondNode));
             bond_->setID(bondIDRef_);
             IDManager::instance().setID(bondIDRef_,bond_);
          }
          else if(bondNode->Attribute("href")) { bondIDRef_ = bondNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { bond_ = boost::shared_ptr<Bond>(new Bond(bondNode));}
   }

   //convertibleBondNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* convertibleBondNode = xmlNode->FirstChildElement("convertibleBond");

   if(convertibleBondNode){convertibleBondIsNull_ = false;}
   else{convertibleBondIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- convertibleBondNode , address : " << convertibleBondNode << std::endl;
   #endif
   if(convertibleBondNode)
   {
      if(convertibleBondNode->Attribute("href") || convertibleBondNode->Attribute("id"))
      {
          if(convertibleBondNode->Attribute("id"))
          {
             convertibleBondIDRef_ = convertibleBondNode->Attribute("id");
             convertibleBond_ = boost::shared_ptr<ConvertibleBond>(new ConvertibleBond(convertibleBondNode));
             convertibleBond_->setID(convertibleBondIDRef_);
             IDManager::instance().setID(convertibleBondIDRef_,convertibleBond_);
          }
          else if(convertibleBondNode->Attribute("href")) { convertibleBondIDRef_ = convertibleBondNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { convertibleBond_ = boost::shared_ptr<ConvertibleBond>(new ConvertibleBond(convertibleBondNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<BondOptionStrike> BondOption::getStrike()
{
   if(!this->strikeIsNull_){
        if(strikeIDRef_ != ""){
             return boost::shared_static_cast<BondOptionStrike>(IDManager::instance().getID(strikeIDRef_));
        }else{
             return this->strike_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<BondOptionStrike>();
   }
}
boost::shared_ptr<Bond> BondOption::getBond()
{
   if(!this->bondIsNull_){
        if(bondIDRef_ != ""){
             return boost::shared_static_cast<Bond>(IDManager::instance().getID(bondIDRef_));
        }else{
             return this->bond_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<Bond>();
   }
}
boost::shared_ptr<ConvertibleBond> BondOption::getConvertibleBond()
{
   if(!this->convertibleBondIsNull_){
        if(convertibleBondIDRef_ != ""){
             return boost::shared_static_cast<ConvertibleBond>(IDManager::instance().getID(convertibleBondIDRef_));
        }else{
             return this->convertibleBond_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<ConvertibleBond>();
   }
}
}

