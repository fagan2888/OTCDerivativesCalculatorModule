// ReturnTranTime.hpp 
#ifndef FpmlSerialized_ReturnTranTime_hpp
#define FpmlSerialized_ReturnTranTime_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <ahn-product-1-0/UnderlyingIndex.hpp>
#include <ahn-product-1-0/VariableValue.hpp>

namespace FpmlSerialized {

class ReturnTranTime : public ISerialized { 
   public: 
       ReturnTranTime(TiXmlNode* xmlNode);

       bool isName(){return this->nameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getName();
      std::string getNameIDRef(){return nameIDRef_;}

       bool isReturnType(){return this->returnTypeIsNull_;}
       boost::shared_ptr<XsdTypeToken> getReturnType();
      std::string getReturnTypeIDRef(){return returnTypeIDRef_;}

       bool isUnderlyingIndexRef(){return this->underlyingIndexRefIsNull_;}
       boost::shared_ptr<UnderlyingIndex> getUnderlyingIndexRef();
      std::string getUnderlyingIndexRefIDRef(){return underlyingIndexRefIDRef_;}

       bool isSymbolName(){return this->symbolNameIsNull_;}
       boost::shared_ptr<XsdTypeToken> getSymbolName();
      std::string getSymbolNameIDRef(){return symbolNameIDRef_;}

       bool isNumerCalculation(){return this->numerCalculationIsNull_;}
       boost::shared_ptr<VariableValue> getNumerCalculation();
      std::string getNumerCalculationIDRef(){return numerCalculationIDRef_;}

       bool isDenumerCalculation(){return this->denumerCalculationIsNull_;}
       boost::shared_ptr<VariableValue> getDenumerCalculation();
      std::string getDenumerCalculationIDRef(){return denumerCalculationIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeToken> name_;
       std::string nameIDRef_;
       bool nameIsNull_;
       boost::shared_ptr<XsdTypeToken> returnType_;
       std::string returnTypeIDRef_;
       bool returnTypeIsNull_;
       boost::shared_ptr<UnderlyingIndex> underlyingIndexRef_;
       std::string underlyingIndexRefIDRef_;
       bool underlyingIndexRefIsNull_;
       boost::shared_ptr<XsdTypeToken> symbolName_;
       std::string symbolNameIDRef_;
       bool symbolNameIsNull_;
       boost::shared_ptr<VariableValue> numerCalculation_;
       std::string numerCalculationIDRef_;
       bool numerCalculationIsNull_;
       boost::shared_ptr<VariableValue> denumerCalculation_;
       std::string denumerCalculationIDRef_;
       bool denumerCalculationIsNull_;

};

} //namespaceFpmlSerialized end
#endif

