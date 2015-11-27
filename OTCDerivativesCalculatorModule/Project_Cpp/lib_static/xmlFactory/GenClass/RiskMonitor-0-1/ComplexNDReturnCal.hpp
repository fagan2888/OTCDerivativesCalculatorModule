// ComplexNDReturnCal.hpp 
#ifndef FpmlSerialized_ComplexNDReturnCal_hpp
#define FpmlSerialized_ComplexNDReturnCal_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/VariableCalList.hpp>
#include <RiskMonitor-0-1/OperatorND.hpp>

namespace FpmlSerialized {

class ComplexNDReturnCal : public ISerialized { 
   public: 
       ComplexNDReturnCal(TiXmlNode* xmlNode);

       bool isVariableCalList(){return this->variableCalListIsNull_;}
       boost::shared_ptr<VariableCalList> getVariableCalList();


       bool isOperatorND(){return this->operatorNDIsNull_;}
       boost::shared_ptr<OperatorND> getOperatorND();


   protected: 
       boost::shared_ptr<VariableCalList> variableCalList_;
       
       bool variableCalListIsNull_;
       boost::shared_ptr<OperatorND> operatorND_;
       
       bool operatorNDIsNull_;

};

} //namespaceFpmlSerialized end
#endif

