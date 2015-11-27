// DerivativeFormula.cpp 
#include "DerivativeFormula.hpp"
#ifdef ConsolePrint
    #include <iostream>
#endif 

namespace FpmlSerialized {

DerivativeFormula::DerivativeFormula(TiXmlNode* xmlNode)
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
             term_ = boost::shared_ptr<FormulaTerm>(new FormulaTerm(termNode));
             term_->setID(termIDRef_);
             IDManager::instance().setID(termIDRef_,term_);
          }
          else if(termNode->Attribute("href")) { termIDRef_ = termNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { term_ = boost::shared_ptr<FormulaTerm>(new FormulaTerm(termNode));}
   }

   //denominatorTermNode ----------------------------------------------------------------------------------------------------------------------
   TiXmlElement* denominatorTermNode = xmlNode->FirstChildElement("denominatorTerm");

   if(denominatorTermNode){denominatorTermIsNull_ = false;}
   else{denominatorTermIsNull_ = true;}

   #ifdef ConsolePrint
      FileManager::instance().outFile_ << FileManager::instance().tap_.c_str() << "- denominatorTermNode , address : " << denominatorTermNode << std::endl;
   #endif
   if(denominatorTermNode)
   {
      if(denominatorTermNode->Attribute("href") || denominatorTermNode->Attribute("id"))
      {
          if(denominatorTermNode->Attribute("id"))
          {
             denominatorTermIDRef_ = denominatorTermNode->Attribute("id");
             denominatorTerm_ = boost::shared_ptr<DenominatorTerm>(new DenominatorTerm(denominatorTermNode));
             denominatorTerm_->setID(denominatorTermIDRef_);
             IDManager::instance().setID(denominatorTermIDRef_,denominatorTerm_);
          }
          else if(denominatorTermNode->Attribute("href")) { denominatorTermIDRef_ = denominatorTermNode->Attribute("href");}
          else { QL_FAIL("id or href error"); }
      }
      else { denominatorTerm_ = boost::shared_ptr<DenominatorTerm>(new DenominatorTerm(denominatorTermNode));}
   }

    #ifdef ConsolePrint
        FileManager::instance().tap_ = initialtap_;
    #endif 
}
boost::shared_ptr<FormulaTerm> DerivativeFormula::getTerm()
{
   if(!this->termIsNull_){
        if(termIDRef_ != ""){
             return boost::shared_static_cast<FormulaTerm>(IDManager::instance().getID(termIDRef_));
        }else{
             return this->term_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<FormulaTerm>();
   }
}
boost::shared_ptr<DenominatorTerm> DerivativeFormula::getDenominatorTerm()
{
   if(!this->denominatorTermIsNull_){
        if(denominatorTermIDRef_ != ""){
             return boost::shared_static_cast<DenominatorTerm>(IDManager::instance().getID(denominatorTermIDRef_));
        }else{
             return this->denominatorTerm_;
        }
   }else
   {
      QL_FAIL("null Ptr");
      return boost::shared_ptr<DenominatorTerm>();
   }
}
}

