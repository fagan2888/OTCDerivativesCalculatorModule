#ifndef quantlib_stopLossReturnCal_hpp
#define quantlib_stopLossReturnCal_hpp

#include <src/Engine/MonteCarlo/returnCalculation/returnCalculation.hpp>


namespace QuantLib {

	class StopLossReturnCal : public ReturnCalculation
	{
		public:
			StopLossReturnCal(const boost::shared_ptr<QuantLib::ReferenceCalculation>& refCal,
							 Real power,
							 Real lossTrigger,
							 Real maximumLoss,
							 //Real withNotional,
							 const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList = std::vector<boost::shared_ptr<VariableInfo>>() );

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
			boost::shared_ptr<QuantLib::ReferenceCalculation> refCal_;
			Real power_;
			Real lossTrigger_;
			Real maximumLoss_;
			//Real withNotional_;
			std::valarray<Real> val_;
	};

}

#endif