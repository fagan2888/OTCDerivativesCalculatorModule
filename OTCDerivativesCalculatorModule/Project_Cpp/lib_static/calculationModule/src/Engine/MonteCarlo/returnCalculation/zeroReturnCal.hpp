#ifndef quantlib_ZeroReturnCal_hpp
#define quantlib_ZeroReturnCal_hpp

#include <src/Engine/MonteCarlo/returnCalculation/returnCalculation.hpp>

namespace QuantLib {

	class ZeroReturnCal : public ReturnCalculation
	{
		public:
			ZeroReturnCal();


			Real calSlice(const std::valarray<Real>& val);
			Real calSlice(const MultiPath& path,Size position); 
			std::vector<Date> fixingDates() const;

		protected:
			void initializeImpl(const TimeGrid& timeGrid,
								const boost::shared_ptr<YieldTermStructure>& discountCurve,
								const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			Real calculateImpl(const MultiPath& path,Size endPosition);
			//Real calculateImplEarlyEx(const MultiPath& path,Size endPosition);

	};

}

#endif