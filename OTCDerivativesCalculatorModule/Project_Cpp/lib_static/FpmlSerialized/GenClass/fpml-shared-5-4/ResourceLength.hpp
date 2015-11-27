// ResourceLength.hpp 
#ifndef FpmlSerialized_ResourceLength_hpp
#define FpmlSerialized_ResourceLength_hpp

#include <ISerialized.hpp>
#include <fpml-enum-5-4/LengthUnitEnum.hpp>
#include <built_in_type/XsdTypeDecimal.hpp>

namespace FpmlSerialized {

class ResourceLength : public ISerialized { 
   public: 
       ResourceLength(TiXmlNode* xmlNode);

       bool isLengthUnit(){return this->lengthUnitIsNull_;}
       boost::shared_ptr<LengthUnitEnum> getLengthUnit();
      std::string getLengthUnitIDRef(){return lengthUnitIDRef_;}

       bool isLengthValue(){return this->lengthValueIsNull_;}
       boost::shared_ptr<XsdTypeDecimal> getLengthValue();
      std::string getLengthValueIDRef(){return lengthValueIDRef_;}

   protected: 
       boost::shared_ptr<LengthUnitEnum> lengthUnit_;
       std::string lengthUnitIDRef_;
       bool lengthUnitIsNull_;
       boost::shared_ptr<XsdTypeDecimal> lengthValue_;
       std::string lengthValueIDRef_;
       bool lengthValueIsNull_;

};

} //namespaceFpmlSerialized end
#endif

