#ifndef xmlFactory_qlDateIntervalMakerFactory_hpp
#define xmlFactory_qlDateIntervalMakerFactory_hpp

#include <xmlFactory/util/xmlUtilHeader.hpp>
#include <map>
#include <ql/time/date.hpp>
#include <fpmlserialized/genclass/ahn-product-1-0/EventDates.hpp>
#include <fpmlserialized/genclass/ahn-product-1-0/EventDate.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/DateIntervalMaker.hpp>
#include <ql/time/period.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/SymbolManager/PathInformation.hpp>

using namespace QuantLib;

namespace XmlFactory {
	
	class qlDateIntervalMakerFactory {
	
		public:	 
			qlDateIntervalMakerFactory(){}
			
			void setSerialClass(const boost::shared_ptr<FpmlSerialized::EventDate>& serial_Class);
			void setSerialClass(const boost::shared_ptr<FpmlSerialized::EventDates>& serial_Class);
			

			boost::shared_ptr<QuantLib::DateIntervalMaker> getDIM();

			std::string getDateStr(const std::string& refStr);
			

		private:
			std::string factoryName_;
			std::map<std::string,Date> data_;
			Date refDate_;
			std::string dateID_;
			boost::shared_ptr<QuantLib::DateIntervalMaker> dim_;



	
	};

}

#endif
