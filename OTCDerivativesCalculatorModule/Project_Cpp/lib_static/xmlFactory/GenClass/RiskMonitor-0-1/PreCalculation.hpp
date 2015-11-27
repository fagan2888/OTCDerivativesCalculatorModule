// PreCalculation.hpp 
#ifndef FpmlSerialized_PreCalculation_hpp
#define FpmlSerialized_PreCalculation_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/VariableCalList.hpp>

namespace FpmlSerialized {

class PreCalculation : public ISerialized { 
   public: 
       PreCalculation(TiXmlNode* xmlNode);

       bool isVariableCalList(){return this->variableCalListIsNull_;}
       boost::shared_ptr<VariableCalList> getVariableCalList();


   protected: 
       boost::shared_ptr<VariableCalList> variableCalList_;
       
       bool variableCalListIsNull_;

};

} //namespaceFpmlSerialized end
#endif

