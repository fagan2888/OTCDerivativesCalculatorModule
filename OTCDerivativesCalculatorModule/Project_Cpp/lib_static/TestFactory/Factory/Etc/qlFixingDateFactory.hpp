#ifndef xmlFactory_qlfixingdatefactory_hpp
#define xmlFactory_qlfixingdatefactory_hpp

#include <ql/time/period.hpp>
#include <string>

using namespace QuantLib;

namespace XmlFactory {

	class qlFixingDateFactory {
		public:
			qlFixingDateFactory()
			{
				
			}

			QuantLib::Date date(const std::string& dateStr)
			{
				/*if (unit == "M")
					return QuantLib::Period(n,Months);*/
				return QuantLib::Date();
			}

			std::vector<QuantLib::Date> dates(const boost::shared_ptr<FpmlSerialized::CalculationPeriodDates>& calculationPeriodDates)
			{return std::vector<QuantLib::Date>();}
			
			QuantLib::Date date(const boost::shared_ptr<FpmlSerialized::AdjustableDate>& adjustableDate)
			{return QuantLib::Date();}

			std::vector<QuantLib::Date> dates(const boost::shared_ptr<FpmlSerialized::PaymentDates>& paymentDates)
			{return std::vector<QuantLib::Date>();}
			std::vector<QuantLib::Date> dates(const boost::shared_ptr<FpmlSerialized::ResetDates>& resetDates)
			{return std::vector<QuantLib::Date>();}

			
	};
}

#endif