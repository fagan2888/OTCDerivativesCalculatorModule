// Metal.hpp 
#ifndef FpmlSerialized_Metal_hpp
#define FpmlSerialized_Metal_hpp

#include <ISerialized.hpp>
#include <fpml-com-5-4/Material.hpp>
#include <fpml-com-5-4/CommodityMetalShape.hpp>
#include <fpml-com-5-4/CommodityMetalBrand.hpp>
#include <fpml-com-5-4/CommodityMetalGrade.hpp>

namespace FpmlSerialized {

class Metal : public ISerialized { 
   public: 
       Metal(TiXmlNode* xmlNode);

       bool isMaterial(){return this->materialIsNull_;}
       boost::shared_ptr<Material> getMaterial();
      std::string getMaterialIDRef(){return materialIDRef_;}

       bool isShape(){return this->shapeIsNull_;}
       std::vector<boost::shared_ptr<CommodityMetalShape>> getShape();
      std::string getShapeIDRef(){return shapeIDRef_;}

       bool isBrand(){return this->brandIsNull_;}
       std::vector<boost::shared_ptr<CommodityMetalBrand>> getBrand();
      std::string getBrandIDRef(){return brandIDRef_;}

       bool isGrade(){return this->gradeIsNull_;}
       std::vector<boost::shared_ptr<CommodityMetalGrade>> getGrade();
      std::string getGradeIDRef(){return gradeIDRef_;}

   protected: 
       boost::shared_ptr<Material> material_;
       std::string materialIDRef_;
       bool materialIsNull_;
       std::vector<boost::shared_ptr<CommodityMetalShape>> shape_;
       std::string shapeIDRef_;
       bool shapeIsNull_;
       std::vector<boost::shared_ptr<CommodityMetalBrand>> brand_;
       std::string brandIDRef_;
       bool brandIsNull_;
       std::vector<boost::shared_ptr<CommodityMetalGrade>> grade_;
       std::string gradeIDRef_;
       bool gradeIsNull_;

};

} //namespaceFpmlSerialized end
#endif

