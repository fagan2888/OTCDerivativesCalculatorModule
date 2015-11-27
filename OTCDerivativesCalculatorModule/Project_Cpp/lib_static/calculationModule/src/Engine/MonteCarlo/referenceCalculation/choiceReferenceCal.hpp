#ifndef quantlib_choiceReferenceCal_hpp
#define quantlib_choiceReferenceCal_hpp

#include <src/Engine/MonteCarlo/referenceCalculation/referenceCalculation.hpp>

namespace QuantLib {

	class ChoiceReferenceCal : public ReferenceCalculation
	{
		public:
			ChoiceReferenceCal(const boost::shared_ptr<QuantLib::FixingDateInfo>& fixingDateInfo,
								const std::string& code,
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
			Size choiceAssetNum_;
			std::string code_;
	};

}

#endif