// IndexTimeRef.hpp 
#ifndef FpmlSerialized_IndexTimeRef_hpp
#define FpmlSerialized_IndexTimeRef_hpp

#include <ISerialized.hpp>
#include <ahn-product-1-0/UnderlyingIndex.hpp>
#include <ahn-product-1-0/FixingDays.hpp>

namespace FpmlSerialized {

class IndexTimeRef : public ISerialized { 
   public: 
       IndexTimeRef(TiXmlNode* xmlNode);

       bool isUnderlyingIndexRef(){return this->underlyingIndexRefIsNull_;}
       boost::shared_ptr<UnderlyingIndex> getUnderlyingIndexRef();
      std::string getUnderlyingIndexRefIDRef(){return underlyingIndexRefIDRef_;}

       bool isFixingDays(){return this->fixingDaysIsNull_;}
       boost::shared_ptr<FixingDays> getFixingDays();
      std::string getFixingDaysIDRef(){return fixingDaysIDRef_;}

   protected: 
       boost::shared_ptr<UnderlyingIndex> underlyingIndexRef_;
       std::string underlyingIndexRefIDRef_;
       bool underlyingIndexRefIsNull_;
       boost::shared_ptr<FixingDays> fixingDays_;
       std::string fixingDaysIDRef_;
       bool fixingDaysIsNull_;

};

} //namespaceFpmlSerialized end
#endif

