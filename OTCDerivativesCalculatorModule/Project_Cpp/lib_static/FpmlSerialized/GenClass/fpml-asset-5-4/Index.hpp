// Index.hpp 
#ifndef FpmlSerialized_Index_hpp
#define FpmlSerialized_Index_hpp

#include <fpml-asset-5-4/ExchangeTradedCalculatedPrice.hpp>
#include <fpml-asset-5-4/FutureId.hpp>

namespace FpmlSerialized {

class Index : public ExchangeTradedCalculatedPrice { 
   public: 
       Index(TiXmlNode* xmlNode);

       bool isFutureId(){return this->futureIdIsNull_;}
       boost::shared_ptr<FutureId> getFutureId();
      std::string getFutureIdIDRef(){return futureIdIDRef_;}

   protected: 
       boost::shared_ptr<FutureId> futureId_;
       std::string futureIdIDRef_;
       bool futureIdIsNull_;

};

} //namespaceFpmlSerialized end
#endif

