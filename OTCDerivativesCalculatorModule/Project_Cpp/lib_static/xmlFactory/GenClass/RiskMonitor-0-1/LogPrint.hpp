// LogPrint.hpp 
#ifndef FpmlSerialized_LogPrint_hpp
#define FpmlSerialized_LogPrint_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class LogPrint : public ISerialized { 
   public: 
       LogPrint(TiXmlNode* xmlNode);

       bool isGeneratedPathLog(){return this->generatedPathLogIsNull_;}
       boost::shared_ptr<XsdTypeToken> getGeneratedPathLog();
      std::string getGeneratedPathLogIDRef(){return generatedPathLogIDRef_;}

       bool isPayoffCalcLog(){return this->payoffCalcLogIsNull_;}
       boost::shared_ptr<XsdTypeToken> getPayoffCalcLog();
      std::string getPayoffCalcLogIDRef(){return payoffCalcLogIDRef_;}

   protected: 
       boost::shared_ptr<XsdTypeToken> generatedPathLog_;
       std::string generatedPathLogIDRef_;
       bool generatedPathLogIsNull_;
       boost::shared_ptr<XsdTypeToken> payoffCalcLog_;
       std::string payoffCalcLogIDRef_;
       bool payoffCalcLogIsNull_;

};

} //namespaceFpmlSerialized end
#endif

