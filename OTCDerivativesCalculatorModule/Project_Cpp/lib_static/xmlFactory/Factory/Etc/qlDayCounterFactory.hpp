#ifndef xmlFactory_qldaycounterfactory_hpp
#define xmlFactory_qldaycounterfactory_hpp

#include <boost/algorithm/string.hpp>

namespace XmlFactory {

	enum DayCounterType 
	{
		Act360 = 0
	};

	class qlDayCounterFactory {

		public:
			qlDayCounterFactory()
			{
			
			}

			//boost::shared_ptr<QuantLib::DayCounter> dayCounterPtr(const std::string& typeStr)
			//{
			//	DayCounterType type = this->dcType(typeStr);
			//	boost::shared_ptr<QuantLib::DayCounter> dayCounterPtr;

			//	switch (type) 
			//	{
			//		case Act360 :
			//			dayCounterPtr = boost::shared_ptr<QuantLib::DayCounter>(new QuantLib::Actual360());
			//			break;
			//		default:
			//			QL_FAIL("unknown type dayCounter");
			//			break;
			//	}

			//	return dayCounterPtr;
			//}

			QuantLib::DayCounter dayCounter(const std::string& typeStr)
			{
				//DayCounterType type = this->dcType(typeStr);
				QuantLib::DayCounter dayCounter;
					
				std::string upperStr =  boost::to_upper_copy(typeStr);

				if(upperStr=="ACT360")
				{
					dayCounter = QuantLib::Actual360();
				}
				else if(upperStr=="ACT365FIX")
				{
					dayCounter = QuantLib::Actual365Fixed();
				}
				//else if(typeStr=="Act/360")
				//{
				//	dayCounter = QuantLib::();
				//}
				else
				{
					dayCounter = QuantLib::Actual365Fixed();

					//QL_FAIL("unknown type dayCounter");
				}

				return dayCounter;
			}
	};

}
#endif