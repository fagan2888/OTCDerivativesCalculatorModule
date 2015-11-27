// VariableValue.hpp 
#ifndef FpmlSerialized_VariableValue_hpp
#define FpmlSerialized_VariableValue_hpp

#include <ISerialized.hpp>
#include <ahn-product-1-0/IndexRef.hpp>
#include <ahn-product-1-0/IndexTimeRef.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <built_in_type/XsdTypeDouble.hpp>

namespace FpmlSerialized {

class VariableValue : public ISerialized { 
   public: 
       VariableValue(TiXmlNode* xmlNode);

       bool isIndexRef(){return this->indexRefIsNull_;}
       boost::shared_ptr<IndexRef> getIndexRef();
      std::string getIndexRefIDRef(){return indexRefIDRef_;}

       bool isIndexTimeRef(){return this->indexTimeRefIsNull_;}
       boost::shared_ptr<IndexTimeRef> getIndexTimeRef();
      std::string getIndexTimeRefIDRef(){return indexTimeRefIDRef_;}

       bool isSymbolName(){return this->symbolNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getSymbolName();
      std::string getSymbolNameIDRef(){return symbolNameIDRef_;}

       bool isConstValue(){return this->constValueIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getConstValue();
      std::string getConstValueIDRef(){return constValueIDRef_;}

       std::string getChoiceStr_paraType(){
           std::string str;
           int count = 0;
           if(!indexRefIsNull_){
                count += 1;
                str = "indexRef" ;
           }
           if(!indexTimeRefIsNull_){
                count += 1;
                str = "indexTimeRef" ;
           }
           if(!symbolNameIsNull_){
                count += 1;
                str = "symbolName" ;
           }
           if(!constValueIsNull_){
                count += 1;
                str = "constValue" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_paraType_ = str ;
           return choiceStr_paraType_;
       }
   protected: 
         boost::shared_ptr<IndexRef> indexRef_;     //choice
       std::string indexRefIDRef_;
       bool indexRefIsNull_;
         boost::shared_ptr<IndexTimeRef> indexTimeRef_;     //choice
       std::string indexTimeRefIDRef_;
       bool indexTimeRefIsNull_;
         boost::shared_ptr<XsdTypeToken> symbolName_;     //choice
       std::string symbolNameIDRef_;
       bool symbolNameIsNull_;
         boost::shared_ptr<XsdTypeDouble> constValue_;     //choice
       std::string constValueIDRef_;
       bool constValueIsNull_;

       //choiceStr 
       std::string choiceStr_paraType_;

};

} //namespaceFpmlSerialized end
#endif

