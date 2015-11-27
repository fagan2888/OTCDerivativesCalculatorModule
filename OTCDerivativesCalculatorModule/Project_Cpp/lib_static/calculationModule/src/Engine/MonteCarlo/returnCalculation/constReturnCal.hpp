#ifndef quantlib_ConstReturnCal_hpp
#define quantlib_ConstReturnCal_hpp

#include <src/Engine/MonteCarlo/returnCalculation/returnCalculation.hpp>

namespace QuantLib {

	class ConstReturnCal : public ReturnCalculation
	{
		public:
			ConstReturnCal(Real constValue,
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
			Real constValue_;
	};

}

#endif