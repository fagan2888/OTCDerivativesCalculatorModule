#ifndef quantlib_CallPutCompositeReturnCal_hpp
#define quantlib_CallPutCompositeReturnCal_hpp

#include <src/Engine/MonteCarlo/returnCalculation/returnCalculation.hpp>
#include <src/Engine/MonteCarlo/returnCalculation/CallPut/OptionPayoffFunction.hpp>

namespace QuantLib {

	class CallPutCompositeReturnCal : public ReturnCalculation
	{
		public:
			CallPutCompositeReturnCal(const std::vector<Real>& weight,
									  const boost::shared_ptr<ReferenceCalculation>& refCal,
									  const std::vector<boost::shared_ptr<OptionPayoffFunction>>& optionPayoff,
									  const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList );

			Real calSlice(const std::valarray<Real>& val);
			Real calSlice(const MultiPath& path,Size position); 

			std::vector<Date> fixingDates() const;

		protected:
			void initializeImpl(const TimeGrid& timeGrid,
								const boost::shared_ptr<YieldTermStructure>& discountCurve,
								const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			Real calculateImpl(const MultiPath& path,Size endPosition);
			//Real calculateImplEarlyEx(const MultiPath& path.Size endPosition);

		private:
			Size payoffNum_;
			std::vector<Real> weight_;
			boost::shared_ptr<QuantLib::ReferenceCalculation> refCal_;
			std::vector<boost::shared_ptr<QuantLib::OptionPayoffFunction>> optionPayoff_;
	};

}

#endif