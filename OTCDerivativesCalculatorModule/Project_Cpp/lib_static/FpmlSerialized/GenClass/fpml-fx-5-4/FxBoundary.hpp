// FxBoundary.hpp 
#ifndef FpmlSerialized_FxBoundary_hpp
#define FpmlSerialized_FxBoundary_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class FxBoundary : public ISerialized { 
   public: 
       FxBoundary(TiXmlNode* xmlNode);

       bool isInclusive(){return this->inclusiveIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getInclusive();
      std::string getInclusiveIDRef(){return inclusiveIDRef_;}

       bool isExclusive(){return this->exclusiveIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getExclusive();
      std::string getExclusiveIDRef(){return exclusiveIDRef_;}

       std::string getChoiceStr_0(){
           std::string str;
           int count = 0;
           if(!inclusiveIsNull_){
                count += 1;
                str = "inclusive" ;
           }
           if(!exclusiveIsNull_){
                count += 1;
                str = "exclusive" ;
           }
           QL_REQUIRE(count == 1 , "too many choice" << count);
           choiceStr_0_ = str ;
           return choiceStr_0_;
       }
   protected: 
         boost::shared_ptr<XsdTypeBoolean> inclusive_;     //choice
       std::string inclusiveIDRef_;
       bool inclusiveIsNull_;
         boost::shared_ptr<XsdTypeBoolean> exclusive_;     //choice
       std::string exclusiveIDRef_;
       bool exclusiveIsNull_;

       //choiceStr 
       std::string choiceStr_0_;

};

} //namespaceFpmlSerialized end
#endif

