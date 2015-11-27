// BookInformation.hpp 
#ifndef FpmlSerialized_BookInformation_hpp
#define FpmlSerialized_BookInformation_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/PathInfo.hpp>
#include <RiskMonitor-0-1/InstrumentList.hpp>

namespace FpmlSerialized {

class BookInformation : public ISerialized { 
   public: 
       BookInformation(TiXmlNode* xmlNode);

       bool isName(){return this->nameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getName();


       bool isPathInfo(){return this->pathInfoIsNull_;}
       boost::shared_ptr<PathInfo> getPathInfo();


       bool isInstrumentList(){return this->instrumentListIsNull_;}
       boost::shared_ptr<InstrumentList> getInstrumentList();


   protected: 
       boost::shared_ptr<XsdTypeToken> name_;
       
       bool nameIsNull_;
       boost::shared_ptr<PathInfo> pathInfo_;
       
       bool pathInfoIsNull_;
       boost::shared_ptr<InstrumentList> instrumentList_;
       
       bool instrumentListIsNull_;

};

} //namespaceFpmlSerialized end
#endif

