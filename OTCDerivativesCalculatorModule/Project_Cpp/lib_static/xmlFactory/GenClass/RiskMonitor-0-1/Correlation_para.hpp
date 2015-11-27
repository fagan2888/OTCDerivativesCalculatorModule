// Correlation_para.hpp 
#ifndef FpmlSerialized_Correlation_para_hpp
#define FpmlSerialized_Correlation_para_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>
#include <built_in_type/XsdTypeDouble.hpp>

namespace FpmlSerialized {

class Correlation_para : public ISerialized { 
   public: 
       Correlation_para(TiXmlNode* xmlNode);

       bool isFirst(){return this->firstIsNull_;}
       boost::shared_ptr<XsdTypeToken> getFirst();


       bool isSecond(){return this->secondIsNull_;}
       boost::shared_ptr<XsdTypeToken> getSecond();


       bool isValue(){return this->valueIsNull_;}
       boost::shared_ptr<XsdTypeDouble> getValue();


   protected: 
       boost::shared_ptr<XsdTypeToken> first_;
       
       bool firstIsNull_;
       boost::shared_ptr<XsdTypeToken> second_;
       
       bool secondIsNull_;
       boost::shared_ptr<XsdTypeDouble> value_;
       
       bool valueIsNull_;

};

} //namespaceFpmlSerialized end
#endif

