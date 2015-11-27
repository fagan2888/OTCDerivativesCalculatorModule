#ifndef xmlFactory_IFactory_hpp
#define xmlFactory_IFactory_hpp

#include <tinyxml/tinyxml.h>

namespace XmlFactory {

	class IFactory {
	
		public:
			virtual void parseXml(TiXmlNode* xmlNode) = 0;

		protected:
			virtual void build() = 0;
	};

}


#endif