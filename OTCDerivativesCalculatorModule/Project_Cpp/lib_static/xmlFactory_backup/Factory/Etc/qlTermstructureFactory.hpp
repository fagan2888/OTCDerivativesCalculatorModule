// Calculation.hpp 
#ifndef factory_termstructureFactory_hpp
#define factory_termstructureFactory_hpp

#include <ql/time/period.hpp>
#include <ql/time/daycounter.hpp>
#include <ql/time/calendar.hpp>
#include <ql/math/array.hpp>
#include <ql/termstructures/yieldtermstructure.hpp>
#include <ql/termstructures/defaulttermstructure.hpp>

using namespace QuantLib;
using namespace FpmlSerialized;
namespace XmlFactory {

	class qlTermstructureFactory {

		public:

			qlTermstructureFactory(std::vector<QuantLib::Period> tenor,
								   const DayCounter& dayCounter,
								   const Calendar& calendar)
			: tenor_(tenor), dayCounter_(dayCounter), calendar_(calendar)
			{
				tenorNum_ = tenor_.size();
			}

			boost::shared_ptr<DefaultProbabilityTermStructure> defaultTSXml()
			{
			
			}

			boost::shared_ptr<YieldTermStructure> yieldTs(const std::vector<Real>& data)
			{
				QL_REQUIRE(tenor_.size() == data.size(), "not equal data Num");
				boost::shared_ptr<YieldTermStructure> yts;
				return yts;
			}

			boost::shared_ptr<YieldTermStructure> yieldTs(const Array& data)
			{
				QL_REQUIRE(tenor_.size() == data.size(), "not equal data Num");
				boost::shared_ptr<YieldTermStructure> yts;
				return yts;
			}

			boost::shared_ptr<DefaultProbabilityTermStructure> defaultTs(const std::string& type_info,const std::vector<Real>& data)
			{
				//spot

				return boost::shared_ptr<DefaultProbabilityTermStructure>();

				//yield

				//cds
			}
			

		private:
			Size tenorNum_;
			std::vector<QuantLib::Period> tenor_;
			DayCounter dayCounter_;
			Calendar calendar_;

	};
}
#endif