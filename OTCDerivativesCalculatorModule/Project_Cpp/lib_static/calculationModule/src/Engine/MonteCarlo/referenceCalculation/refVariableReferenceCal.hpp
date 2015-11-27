#ifndef quantlib_refVariableReferenceCal_hpp
#define quantlib_refVariableReferenceCal_hpp

#include <src/Engine/MonteCarlo/referenceCalculation/referenceCalculation.hpp>

namespace QuantLib {

	class RefVariableReferenceCal : public ReferenceCalculation
	{
		public:
			//RefVariableReferenceCal(const Date& fixingDates,
			//					 const std::string& code);

			RefVariableReferenceCal(const std::string& refName,
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
			std::string refName_;
			Size assetPosition_;
			std::string code_;

	};

}

#endif