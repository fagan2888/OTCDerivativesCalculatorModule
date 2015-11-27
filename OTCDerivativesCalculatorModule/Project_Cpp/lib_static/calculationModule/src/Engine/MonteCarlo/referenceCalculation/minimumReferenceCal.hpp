#ifndef quantlib_minReturnCalculation_hpp
#define quantlib_minReturnCalculation_hpp

#include <src/Engine/MonteCarlo/referenceCalculation/referenceCalculation.hpp>

namespace QuantLib {

	class MinimumReferenceCal : public ReferenceCalculation
	{
		public:
			MinimumReferenceCal(const boost::shared_ptr<QuantLib::FixingDateInfo>& fixingDateInfo,
								const std::vector<std::string>& selectedUnder,
								const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);
								
			//MinimumReferenceCal(const boost::shared_ptr<QuantLib::FixingDateInfo>& fixingDateInfo,
			//					const std::string& minRefVarName);

			Real calSlice(const std::valarray<Real>& val);
			Real calSlice(const MultiPath& path,Size position);
			std::vector<Date> fixingDates() const;

		protected:
			void initializeImpl(const TimeGrid& timeGrid,
								const boost::shared_ptr<YieldTermStructure>& discountCurve,
								const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);
			
			Real calculateImpl(const MultiPath& path,Size endPosition);

		private:
			std::string minRefVarName_;
			bool minRefVarExistFlag_;

			std::vector<std::string> selectedUnder_;
			std::vector<Size> selectedAssetPosition_;

			Size selectedAssetNum_;
			std::valarray<Real> val_;
	};

}

#endif