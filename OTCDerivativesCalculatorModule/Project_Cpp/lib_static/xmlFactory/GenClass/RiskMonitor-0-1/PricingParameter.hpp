// PricingParameter.hpp 
#ifndef FpmlSerialized_PricingParameter_hpp
#define FpmlSerialized_PricingParameter_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <RiskMonitor-0-1/Method.hpp>

namespace FpmlSerialized {

class PricingParameter : public ISerialized { 
   public: 
       PricingParameter(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getType();


       bool isMethod(){return this->methodIsNull_;}
       boost::shared_ptr<Method> getMethod();


   protected: 
       boost::shared_ptr<XsdTypeToken> type_;
       
       bool typeIsNull_;
       boost::shared_ptr<Method> method_;
       
       bool methodIsNull_;

};

} //namespaceFpmlSerialized end
#endif

