// Excel_greekResult.hpp 
#ifndef FpmlSerialized_Excel_greekResult_hpp
#define FpmlSerialized_Excel_greekResult_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Excel_greekUnderlying.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class Excel_greekResult : public ISerialized { 
   public: 
       Excel_greekResult(TiXmlNode* xmlNode);

       bool isExcel_greekUnderlying(){return this->excel_greekUnderlyingIsNull_;}
       std::vector<boost::shared_ptr<Excel_greekUnderlying>> getExcel_greekUnderlying();


       bool isTheta(){return this->thetaIsNull_;}
       boost::shared_ptr<XsdTypeToken> getTheta();


       bool isRho(){return this->rhoIsNull_;}
       boost::shared_ptr<XsdTypeToken> getRho();


   protected: 
       std::vector<boost::shared_ptr<Excel_greekUnderlying>> excel_greekUnderlying_;
       
       bool excel_greekUnderlyingIsNull_;
       boost::shared_ptr<XsdTypeToken> theta_;
       
       bool thetaIsNull_;
       boost::shared_ptr<XsdTypeToken> rho_;
       
       bool rhoIsNull_;

};

} //namespaceFpmlSerialized end
#endif

