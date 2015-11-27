// PortfolioReferenceBase.hpp 
#ifndef FpmlSerialized_PortfolioReferenceBase_hpp
#define FpmlSerialized_PortfolioReferenceBase_hpp

#include <ISerialized.hpp>
#include <fpml-doc-5-4/PortfolioName.hpp>

namespace FpmlSerialized {

class PortfolioReferenceBase : public ISerialized { 
   public: 
       PortfolioReferenceBase(TiXmlNode* xmlNode);

       bool isPortfolioName(){return this->portfolioNameIsNull_;}
       boost::shared_ptr<PortfolioName> getPortfolioName();
      std::string getPortfolioNameIDRef(){return portfolioNameIDRef_;}

   protected: 
       boost::shared_ptr<PortfolioName> portfolioName_;
       std::string portfolioNameIDRef_;
       bool portfolioNameIsNull_;

};

} //namespaceFpmlSerialized end
#endif

