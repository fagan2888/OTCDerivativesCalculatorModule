#ifndef quantlib_Complex1DReturnCal_hpp
#define quantlib_Complex1DReturnCal_hpp

#include <src/Engine/MonteCarlo/returnCalculation/returnCalculation.hpp>
#include <src/Engine/MonteCarlo/variableCalculation.hpp>

namespace QuantLib {

	class Complex1DReturnCal : public ReturnCalculation
	{
		public:
			Complex1DReturnCal(const boost::shared_ptr<QuantLib::VariableCalculation>& variableCal,
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
			Size assetNum_;
			boost::shared_ptr<QuantLib::VariableCalculation> variableCal_;
	};

}

#endif