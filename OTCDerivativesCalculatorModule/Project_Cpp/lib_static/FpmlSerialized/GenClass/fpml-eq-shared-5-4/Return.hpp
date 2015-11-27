// Return.hpp 
#ifndef FpmlSerialized_Return_hpp
#define FpmlSerialized_Return_hpp

#include <ISerialized.hpp>
#include <fpml-enum-5-4/ReturnTypeEnum.hpp>
#include <fpml-eq-shared-5-4/DividendConditions.hpp>

namespace FpmlSerialized {

class Return : public ISerialized { 
   public: 
       Return(TiXmlNode* xmlNode);

       bool isReturnType(){return this->returnTypeIsNull_;}
       boost::shared_ptr<ReturnTypeEnum> getReturnType();
      std::string getReturnTypeIDRef(){return returnTypeIDRef_;}

       bool isDividendConditions(){return this->dividendConditionsIsNull_;}
       boost::shared_ptr<DividendConditions> getDividendConditions();
      std::string getDividendConditionsIDRef(){return dividendConditionsIDRef_;}

   protected: 
       boost::shared_ptr<ReturnTypeEnum> returnType_;
       std::string returnTypeIDRef_;
       bool returnTypeIsNull_;
       boost::shared_ptr<DividendConditions> dividendConditions_;
       std::string dividendConditionsIDRef_;
       bool dividendConditionsIsNull_;

};

} //namespaceFpmlSerialized end
#endif

