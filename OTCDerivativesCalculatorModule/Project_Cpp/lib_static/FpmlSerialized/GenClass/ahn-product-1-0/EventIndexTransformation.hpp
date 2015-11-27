// EventIndexTransformation.hpp 
#ifndef FpmlSerialized_EventIndexTransformation_hpp
#define FpmlSerialized_EventIndexTransformation_hpp

#include <ISerialized.hpp>
#include <ahn-product-1-0/IndexCalculation.hpp>

namespace FpmlSerialized {

class EventIndexTransformation : public ISerialized { 
   public: 
       EventIndexTransformation(TiXmlNode* xmlNode);

       bool isIndexCalculation(){return this->indexCalculationIsNull_;}
       std::vector<boost::shared_ptr<IndexCalculation>> getIndexCalculation();
      std::string getIndexCalculationIDRef(){return indexCalculationIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<IndexCalculation>> indexCalculation_;
       std::string indexCalculationIDRef_;
       bool indexCalculationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

