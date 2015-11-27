// AverPayoff.hpp 
#ifndef FpmlSerialized_AverPayoff_hpp
#define FpmlSerialized_AverPayoff_hpp

#include <ISerialized.hpp>
#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class AverPayoff : public ISerialized { 
   public: 
       AverPayoff(TiXmlNode* xmlNode);

       bool isDate(){return this->dateIsNull_;}
       std::vector<boost::shared_ptr<XsdTypeDate>> getDate();
      std::string getDateIDRef(){return dateIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<XsdTypeDate>> date_;
       std::string dateIDRef_;
       bool dateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

