#ifndef quantlib_VanillaReturnCal_hpp
#define quantlib_VanillaReturnCal_hpp

#include <src/Engine/MonteCarlo/returnCalculation/returnCalculation.hpp>


namespace QuantLib {

	class VanillaReturnCal : public ReturnCalculation
	{
		public:
			VanillaReturnCal(const boost::shared_ptr<QuantLib::ReferenceCalculation>& refCal,
							 Real gearing,
							 Real spread,
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
			boost::shared_ptr<QuantLib::ReferenceCalculation> refCal_;
			Real gearing_;
			Real spread_;
			std::valarray<Real> val_;
	};

}

#endif