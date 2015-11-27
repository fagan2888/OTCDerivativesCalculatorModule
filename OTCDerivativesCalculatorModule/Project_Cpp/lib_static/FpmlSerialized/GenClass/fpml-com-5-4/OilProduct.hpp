// OilProduct.hpp 
#ifndef FpmlSerialized_OilProduct_hpp
#define FpmlSerialized_OilProduct_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/OilProductType.hpp>
#include <fpml-com-5-4/CommodityProductGrade.hpp>

namespace FpmlSerialized {

class OilProduct : public ISerialized { 
   public: 
       OilProduct(TiXmlNode* xmlNode);

       bool isType(){return this->typeIsNull_;}
       boost::shared_ptr<OilProductType> getType();
      std::string getTypeIDRef(){return typeIDRef_;}

       bool isGrade(){return this->gradeIsNull_;}
       boost::shared_ptr<CommodityProductGrade> getGrade();
      std::string getGradeIDRef(){return gradeIDRef_;}

   protected: 
       boost::shared_ptr<OilProductType> type_;
       std::string typeIDRef_;
       bool typeIsNull_;
       boost::shared_ptr<CommodityProductGrade> grade_;
       std::string gradeIDRef_;
       bool gradeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

