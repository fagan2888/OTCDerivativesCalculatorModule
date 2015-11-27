// CreditDefaultSwapInstrument.hpp 
#ifndef FpmlSerialized_CreditDefaultSwapInstrument_hpp
#define FpmlSerialized_CreditDefaultSwapInstrument_hpp

#include <RiskMonitor-0-1/Instrument.hpp>
#include <RiskMonitor-0-1/CreditDefaultSwap.hpp>

namespace FpmlSerialized {

class CreditDefaultSwapInstrument : public Instrument { 
   public: 
       CreditDefaultSwapInstrument(TiXmlNode* xmlNode);

       bool isCreditDefaultSwap(){return this->creditDefaultSwapIsNull_;}
       boost::shared_ptr<CreditDefaultSwap> getCreditDefaultSwap();


   protected: 
       boost::shared_ptr<CreditDefaultSwap> creditDefaultSwap_;
       
       bool creditDefaultSwapIsNull_;

};

} //namespaceFpmlSerialized end
#endif

