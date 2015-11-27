#ifndef quantlib_ReturnCalculationInfo_hpp
#define quantlib_ReturnCalculationInfo_hpp

#include <src/Engine/MonteCarlo/returnCalculation/returnCalculation.hpp>
#include <src/Engine/MonteCarlo/operator/operatorND.hpp>

namespace QuantLib {

	class ReturnCalculationInfo : public ReturnCalculation
	{
		public:
			ReturnCalculationInfo(const std::vector<boost::shared_ptr<QuantLib::ReturnCalculation>>& returnCalList,
								const boost::shared_ptr<QuantLib::OperatorND>& operatorND,
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
			std::vector<boost::shared_ptr<QuantLib::ReturnCalculation>> returnCalList_;
			boost::shared_ptr<QuantLib::OperatorND> operatorND_;
			std::valarray<Real> valueArr_;
	};

}

#endif