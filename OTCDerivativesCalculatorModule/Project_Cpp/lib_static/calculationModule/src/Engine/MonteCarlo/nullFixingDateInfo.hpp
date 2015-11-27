#ifndef quantlib_nullfixingdateinfo_hpp
#define quantlib_nullfixingdateinfo_hpp

#include <ql/timegrid.hpp>
#include <ql/methods/montecarlo/multipath.hpp>
#include <ql/termstructures/yieldtermstructure.hpp>
#include <ql/time/date.hpp>
#include <valarray>
#include <src/Engine/MonteCarlo/PathGeneratorFactory.hpp>
#include <src/Engine/MonteCarlo/fixingDateInfo.hpp>

namespace QuantLib {

	class NullFixingDateInfo : public FixingDateInfo
	{
		public:
			NullFixingDateInfo();

			void initialize(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			Date fixingDate();
			Size fixingDatePosition();
			Real discount();
	};
}

#endif