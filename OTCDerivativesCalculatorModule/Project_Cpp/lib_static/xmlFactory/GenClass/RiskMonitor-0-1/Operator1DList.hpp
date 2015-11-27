// Operator1DList.hpp 
#ifndef FpmlSerialized_Operator1DList_hpp
#define FpmlSerialized_Operator1DList_hpp

#include <ISerialized.hpp>
#include <RiskMonitor-0-1/Operator1D.hpp>

namespace FpmlSerialized {

class Operator1DList : public ISerialized { 
   public: 
       Operator1DList(TiXmlNode* xmlNode);

       bool isOperator1D(){return this->operator1DIsNull_;}
       std::vector<boost::shared_ptr<Operator1D>> getOperator1D();


   protected: 
       std::vector<boost::shared_ptr<Operator1D>> operator1D_;
       
       bool operator1DIsNull_;

};

} //namespaceFpmlSerialized end
#endif

