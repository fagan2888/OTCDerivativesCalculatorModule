// PayoffCalcLog.hpp 
#ifndef FpmlSerialized_PayoffCalcLog_hpp
#define FpmlSerialized_PayoffCalcLog_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeToken.hpp>

namespace FpmlSerialized {

class PayoffCalcLog : public ISerialized { 
   public: 
       PayoffCalcLog(TiXmlNode* xmlNode);

       bool isPathDate(){return this->pathDateIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeToken>> getPathDate();
      std::string getPathDateIDRef(){return pathDateIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<XsdTypeToken>> pathDate_;
       std::string pathDateIDRef_;
       bool pathDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

