// ContractualTermsSupplement.hpp 
#ifndef FpmlSerialized_ContractualTermsSupplement_hpp
#define FpmlSerialized_ContractualTermsSupplement_hpp

#include <ISerialized.hpp>
#include <fpml-shared-5-4/ContractualSupplement.hpp>
#include <built_in_type/XsdTypeDate.hpp>

namespace FpmlSerialized {

class ContractualTermsSupplement : public ISerialized { 
   public: 
       ContractualTermsSupplement(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<ContractualSupplement> getType();
      std::string getTypeIDRef(){return typeIDRef_;}

       bool isPublicationDate(){return this->publicationDateIsNull_;}
       boost::shared_ptr<XsdTypeDate> getPublicationDate();
      std::string getPublicationDateIDRef(){return publicationDateIDRef_;}

   protected: 
       boost::shared_ptr<ContractualSupplement> type_;
       std::string typeIDRef_;
       bool typeIsNull_;
       boost::shared_ptr<XsdTypeDate> publicationDate_;
       std::string publicationDateIDRef_;
       bool publicationDateIsNull_;

};

} //namespaceFpmlSerialized end
#endif

