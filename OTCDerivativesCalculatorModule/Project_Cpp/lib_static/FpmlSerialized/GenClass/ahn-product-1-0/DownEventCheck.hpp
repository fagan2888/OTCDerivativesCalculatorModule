// DownEventCheck.hpp 
#ifndef FpmlSerialized_DownEventCheck_hpp
#define FpmlSerialized_DownEventCheck_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDouble.hpp>
#include <built_in_type/XsdTypeBoolean.hpp>

namespace FpmlSerialized {

class DownEventCheck : public ISerialized { 
   public: 
       DownEventCheck(TiXmlNode* xmlNode);

       bool isCheckValue(){return this->checkValueIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getCheckValue();
      std::string getCheckValueIDRef(){return checkValueIDRef_;}

       bool isEquality(){return this->equalityIsNull_;}
       boost::shared_ptr<XsdTypeBoolean> getEquality();
      std::string getEqualityIDRef(){return equalityIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeDouble> checkValue_;
       std::string checkValueIDRef_;
       bool checkValueIsNull_;
       boost::shared_ptr<XsdTypeBoolean> equality_;
       std::string equalityIDRef_;
       bool equalityIsNull_;

};

} //namespaceFpmlSerialized end
#endif

