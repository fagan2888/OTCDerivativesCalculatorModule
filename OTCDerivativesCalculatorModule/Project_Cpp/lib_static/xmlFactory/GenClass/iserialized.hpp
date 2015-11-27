#ifndef FpmlSerialized_iserialized_hpp
#define FpmlSerialized_iserialized_hpp

#include <stdlib.h>
#include <tinyxml/tinyxml.h>
//#include <tinyXPath/xpath_static.h>
#include <vector>
#include <string>
#include <boost/shared_ptr.hpp>
#include <idmanager.hpp>
#include <filemanager.hpp>
#include <ql/errors.hpp>

namespace FpmlSerialized {

class ISerialized { 
	public:
		ISerialized(TiXmlNode* xmlNode) 
		{
			thisNode_ = xmlNode;
		}
		virtual ~ISerialized(){}
		virtual void descript() {}
		std::string getID(){return id_;}
		void setID(std::string id){id_=id;}
		TiXmlNode* getNode()
		{
			return thisNode_;
		}

	protected:
		std::string id_;
		TiXmlNode* thisNode_;
};

}
#endif