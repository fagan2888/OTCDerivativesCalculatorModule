#ifndef quantlib_CallPutReturnCal_hpp
#define quantlib_CallPutReturnCal_hpp

#include <src/Engine/MonteCarlo/returnCalculation/returnCalculation.hpp>


namespace QuantLib {

	class CallPutReturnCal : public ReturnCalculation
	{
		public:
			CallPutReturnCal(bool callPut,
							 Real partiRate,
							 Real strike,
							 Real spread,
							 const boost::shared_ptr<QuantLib::ReferenceCalculation>& refCal,
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
			bool callPut_;
			Real partiRate_;
			Real strike_;
			Real spread_;
			std::valarray<Real> val_;
	};

}

#endif