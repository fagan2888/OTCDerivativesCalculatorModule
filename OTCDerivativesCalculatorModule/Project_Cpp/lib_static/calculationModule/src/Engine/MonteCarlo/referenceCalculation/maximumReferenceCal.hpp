#ifndef quantlib_maxReturnCalculation_hpp
#define quantlib_maxReturnCalculation_hpp

#include <src/Engine/MonteCarlo/referenceCalculation/referenceCalculation.hpp>

namespace QuantLib {

	class MaximumReferenceCal : public ReferenceCalculation
	{
		public:
			MaximumReferenceCal(const boost::shared_ptr<QuantLib::FixingDateInfo>& fixingDateInfo,
								const std::vector<std::string>& selectedUnder,
								const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

			//MaximumReferenceCal(const boost::shared_ptr<QuantLib::FixingDateInfo>& fixingDateInfo,
			//					const std::string& maxRefVarName);

			Real calSlice(const MultiPath& path,Size position);
			Real calSlice(const std::valarray<Real>& val);

			std::vector<Date> fixingDates() const;

		protected:
			void initializeImpl(const TimeGrid& timeGrid,
								const boost::shared_ptr<YieldTermStructure>& discountCurve,
								const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);
			
			Real calculateImpl(const MultiPath& path,Size endPosition);

		private:
			//std::string maxRefVarName_;
			//bool maxRefVarExistFlag_;

			std::vector<std::string> selectedUnder_;
			std::vector<Size> selectedAssetPosition_;

			Size selectedAssetNum_;
			std::valarray<Real> val_;

	};

}

#endif