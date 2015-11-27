#ifndef quantlib_dateInformation_hpp
#define quantlib_dateInformation_hpp

#include <valarray>
#include <ql/types.hpp>
#include <ql/timegrid.hpp>
#include <ql/termstructures/yieldtermstructure.hpp>
#include <src/Engine/MonteCarlo/PathGeneratorFactory.hpp>
#include <src/util/DateHelper.hpp>
#include <ql/time/calendars/all.hpp>

namespace QuantLib {

	class DateInformation {
		public:
			

			virtual void initialize(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory) = 0;

			virtual std::valarray<Size> pastFixingDatePositions() = 0;
			virtual std::valarray<Size> fixingDatePositions() = 0;
			virtual std::vector<Date> fixingDates() const = 0;

	};

}

#endif