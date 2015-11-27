#ifndef quantlib_dailyReturnReferenceCal_hpp
#define quantlib_dailyReturnReferenceCal_hpp

#include <src/Engine/MonteCarlo/referenceCalculation/referenceCalculation.hpp>

namespace QuantLib {

	class DailyReturnReferenceCal : public ReferenceCalculation
	{
		public:
			DailyReturnReferenceCal(const boost::shared_ptr<FixingDateInfo>& fixingDateInfo,
									const std::string& code,
									const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

			Real calSlice(const MultiPath& path,Size position);
			Real calSlice(const std::valarray<Real>& val);
			std::vector<Date> fixingDates() const;

		protected:
			void initializeImpl(const TimeGrid& timeGrid,
								const boost::shared_ptr<YieldTermStructure>& discountCurve,
								const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			Real calculateImpl(const MultiPath& path,Size endPosition);

		private:
			boost::shared_ptr<FixingDateInfo> fixingDateInfo_;
			Size assetPosition_;
			std::string code_;

	};

}

#endif