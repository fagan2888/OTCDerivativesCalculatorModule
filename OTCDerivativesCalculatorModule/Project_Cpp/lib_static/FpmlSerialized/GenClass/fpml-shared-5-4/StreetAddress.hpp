// StreetAddress.hpp 
#ifndef FpmlSerialized_StreetAddress_hpp
#define FpmlSerialized_StreetAddress_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeString.hpp>

namespace FpmlSerialized {

class StreetAddress : public ISerialized { 
   public: 
       StreetAddress(TiXmlNode* xmlNode);

       bool isStreetLine(){return this->streetLineIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeString>> getStreetLine();
      std::string getStreetLineIDRef(){return streetLineIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<XsdTypeString>> streetLine_;
       std::string streetLineIDRef_;
       bool streetLineIsNull_;

};

} //namespaceFpmlSerialized end
#endif

