#ifndef quantlib_fixingdateinfo_hpp
#define quantlib_fixingdateinfo_hpp

#include <ql/timegrid.hpp>
#include <ql/methods/montecarlo/multipath.hpp>
#include <ql/termstructures/yieldtermstructure.hpp>
#include <ql/time/date.hpp>
#include <valarray>
#include <src/Engine/MonteCarlo/PathGeneratorFactory.hpp>

namespace QuantLib {

	class FixingDateInfo 
	{
		public:
			virtual ~FixingDateInfo() { }

			FixingDateInfo(bool autoCallFixing,
						   const Date& autoCallFixingDate);

			virtual void initialize(const TimeGrid& timeGrid,
									const boost::shared_ptr<YieldTermStructure>& discountCurve,
									const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory) = 0;

			virtual Date fixingDate() = 0 ;
			virtual Size fixingDatePosition() = 0 ;
			virtual Real discount() = 0 ;

			Real discountAt(Size position) 
			{ 
				return this->discountArr_[position]; 
			}

		protected:
			std::vector<Real> discountArr_;
			bool autoCallFixing_;
			Date autoCallFixingDate_;
			Size autoCallDatePosition_;
			

	};
}

#endif