// Product.hpp 
#ifndef FpmlSerialized_Product_hpp
#define FpmlSerialized_Product_hpp

#include <ISerialized.hpp>

namespace FpmlSerialized {

class Product : public ISerialized { 
   public: 
       Product(TiXmlNode* xmlNode);

   protected: 

};

} //namespaceFpmlSerialized end
#endif

