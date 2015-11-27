#ifndef xmlFactory_indexTransformationFactory_hpp
#define xmlFactory_indexTransformationFactory_hpp

#include <xmlFactory/Factory/Instrument/StructuredProduct/Factory/IFactory.hpp>
#include <xmlFactory/util/xmlUtilHeader.hpp>
#include <map>
#include <ql/time/date.hpp>

using namespace QuantLib;

namespace XmlFactory {
	
	class DateFactory : public IFactory {
	
		public:	 
			DateFactory();
			DateFactory(std::string factoryName);

			void parseXml(TiXmlNode* xmlNode);
			void build();
			
			bool isFactory(std::string fName);

			Date getDate();

			std::string getDateStr(std::string refStr);
			

		private:
			std::string factoryName_;
			std::map<std::string,Date> data_;
			Date refDate_;
			std::string dateID_;



	
	};

}

#endif
