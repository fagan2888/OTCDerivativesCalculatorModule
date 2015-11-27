#ifndef xmlFactory_qldaycounterfactory_hpp
#define xmlFactory_qldaycounterfactory_hpp

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

			boost::shared_ptr<QuantLib::DayCounter> dayCounter(const std::string& typeStr)
			{
				DayCounterType type = this->dcType(typeStr);
				boost::shared_ptr<QuantLib::DayCounter> dayCounterPtr;

				switch (type) 
				{
					case Act360 :
						dayCounterPtr = boost::shared_ptr<QuantLib::DayCounter>(new QuantLib::Actual360());
						break;
					default:
						QL_FAIL("unknown type dayCounter");
						break;
				}

				return dayCounterPtr;
			}
		private:
			DayCounterType dcType(const std::string& typeStr)
			{
				if(typeStr=="Act/360")
				{
					return Act360;	
				}
				else
				{
					QL_FAIL("unknown type dayCounter string");
				}
			}


		
	};

}
#endif