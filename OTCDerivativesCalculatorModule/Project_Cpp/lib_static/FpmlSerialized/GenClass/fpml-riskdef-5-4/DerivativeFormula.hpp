// DerivativeFormula.hpp 
#ifndef FpmlSerialized_DerivativeFormula_hpp
#define FpmlSerialized_DerivativeFormula_hpp

#include <ISerialized.hpp>
#include <fpml-riskdef-5-4/FormulaTerm.hpp>
#include <fpml-riskdef-5-4/DenominatorTerm.hpp>

namespace FpmlSerialized {

class DerivativeFormula : public ISerialized { 
   public: 
       DerivativeFormula(TiXmlNode* xmlNode);

       bool isTerm(){return this->termIsNull_;}
       boost::shared_ptr<FormulaTerm> getTerm();
      std::string getTermIDRef(){return termIDRef_;}

       bool isDenominatorTerm(){return this->denominatorTermIsNull_;}
       boost::shared_ptr<DenominatorTerm> getDenominatorTerm();
      std::string getDenominatorTermIDRef(){return denominatorTermIDRef_;}

   protected: 
       boost::shared_ptr<FormulaTerm> term_;
       std::string termIDRef_;
       bool termIsNull_;
       boost::shared_ptr<DenominatorTerm> denominatorTerm_;
       std::string denominatorTermIDRef_;
       bool denominatorTermIsNull_;

};

} //namespaceFpmlSerialized end
#endif

