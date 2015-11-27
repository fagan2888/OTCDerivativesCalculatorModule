// EventFunctionM.hpp 
#ifndef FpmlSerialized_EventFunctionM_hpp
#define FpmlSerialized_EventFunctionM_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <ahn-product-1-0/UpEventCheck.hpp>
#include <ahn-product-1-0/DownEventCheck.hpp>
#include <ahn-product-1-0/UpDownEventCheck.hpp>
#include <ahn-product-1-0/RangeEventCheck.hpp>

namespace FpmlSerialized {

class EventFunctionM : public ISerialized { 
   public: 
       EventFunctionM(TiXmlNode* xmlNode);

       bool isName(){return this->nameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getName();
      std::string getNameIDRef(){return nameIDRef_;}

       bool isIndexSymbol(){return this->indexSymbolIsNull_;}
       boost::shared_ptr<XsdTypeToken> getIndexSymbol();
      std::string getIndexSymbolIDRef(){return indexSymbolIDRef_;}

       bool isUpEventCheck(){return this->upEventCheckIsNull_;}
       boost::shared_ptr<UpEventCheck> getUpEventCheck();
      std::string getUpEventCheckIDRef(){return upEventCheckIDRef_;}

       bool isDownEventCheck(){return this->downEventCheckIsNull_;}
       boost::shared_ptr<DownEventCheck> getDownEventCheck();
      std::string getDownEventCheckIDRef(){return downEventCheckIDRef_;}

       bool isUpdownEventCheck(){return this->updownEventCheckIsNull_;}
       boost::shared_ptr<UpDownEventCheck> getUpdownEventCheck();
      std::string getUpdownEventCheckIDRef(){return updownEventCheckIDRef_;}

       bool isRangeEventCheck(){return this->rangeEventCheckIsNull_;}
       boost::shared_ptr<RangeEventCheck> getRangeEventCheck();
      std::string getRangeEventCheckIDRef(){return rangeEventCheckIDRef_;}

       std::string getChoiceStr_efType(){
           std::string str;
           int count = 0;
           if(!upEventCheckIsNull_){
                count += 1;
                str = "upEventCheck" ;
           }
           if(!downEventCheckIsNull_){
                count += 1;
                str = "downEventCheck" ;
           }
           if(!updownEventCheckIsNull_){
                count += 1;
                str = "updownEventCheck" ;
           }
           if(!rangeEventCheckIsNull_){
                count += 1;
                str = "rangeEventCheck" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_efType_ = str ;
           return choiceStr_efType_;
       }
   protected: 
       boost::shared_ptr<XsdTypeToken> name_;
       std::string nameIDRef_;
       bool nameIsNull_;
       boost::shared_ptr<XsdTypeToken> indexSymbol_;
       std::string indexSymbolIDRef_;
       bool indexSymbolIsNull_;
         boost::shared_ptr<UpEventCheck> upEventCheck_;     //choice
       std::string upEventCheckIDRef_;
       bool upEventCheckIsNull_;
         boost::shared_ptr<DownEventCheck> downEventCheck_;     //choice
       std::string downEventCheckIDRef_;
       bool downEventCheckIsNull_;
         boost::shared_ptr<UpDownEventCheck> updownEventCheck_;     //choice
       std::string updownEventCheckIDRef_;
       bool updownEventCheckIsNull_;
         boost::shared_ptr<RangeEventCheck> rangeEventCheck_;     //choice
       std::string rangeEventCheckIDRef_;
       bool rangeEventCheckIsNull_;

       //choiceStr 
       std::string choiceStr_efType_;

};

} //namespaceFpmlSerialized end
#endif

