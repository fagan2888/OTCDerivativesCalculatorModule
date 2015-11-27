// PassThrough.hpp 
#ifndef FpmlSerialized_PassThrough_hpp
#define FpmlSerialized_PassThrough_hpp

#include <ISerialized.hpp>
#include <fpml-option-shared-5-4/PassThroughItem.hpp>

namespace FpmlSerialized {

class PassThrough : public ISerialized { 
   public: 
       PassThrough(TiXmlNode* xmlNode);

       bool isPassThroughItem(){return this->passThroughItemIsNull_;}
       std::vector<boost::shared_ptr<PassThroughItem>> getPassThroughItem();
      std::string getPassThroughItemIDRef(){return passThroughItemIDRef_;}

   protected: 
       std::vector<boost::shared_ptr<PassThroughItem>> passThroughItem_;
       std::string passThroughItemIDRef_;
       bool passThroughItemIsNull_;

};

} //namespaceFpmlSerialized end
#endif

