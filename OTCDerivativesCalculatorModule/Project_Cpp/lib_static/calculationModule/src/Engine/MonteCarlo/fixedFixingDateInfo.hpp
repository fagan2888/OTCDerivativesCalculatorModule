#ifndef quantlib_fixedfixingdateinfo_hpp
#define quantlib_fixedfixingdateinfo_hpp

#include <ql/timegrid.hpp>
#include <ql/methods/montecarlo/multipath.hpp>
#include <ql/termstructures/yieldtermstructure.hpp>
#include <ql/time/date.hpp>
#include <valarray>
#include <src/Engine/MonteCarlo/PathGeneratorFactory.hpp>
#include <src/Engine/MonteCarlo/fixingDateInfo.hpp>

namespace QuantLib {

	class FixedFixingDateInfo : public FixingDateInfo
	{
		public:
			FixedFixingDateInfo(const Date& fixingDate,
								
								bool autoCallFixing,
								const Date& autoCallFixingDate);

			void initialize(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			Date fixingDate();
			Size fixingDatePosition();
			Real discount();

		private:
			Date fixingDate_;
			
			Size fixingDatePosition_;
			Real fixedDiscountValue_;
	};
}

#endif