// InstrumentType.hpp 
#ifndef FpmlSerialized_InstrumentType_hpp
#define FpmlSerialized_InstrumentType_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class InstrumentType : public ISerialized { 
   public: 
       InstrumentType(TiXmlNode* xmlNode);

       bool isClassification(){return this->classificationIsNull_;}
       boost::shared_ptr<XsdTypeToken> getClassification();
      std::string getClassificationIDRef(){return classificationIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeToken> classification_;
       std::string classificationIDRef_;
       bool classificationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

