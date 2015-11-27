#ifndef quantlib_SimpleRangeEventCal_hpp
#define quantlib_SimpleRangeEventCal_hpp

#include <src/Engine/MonteCarlo/eventCalculation/eventCalculation.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <src/Engine/MonteCarlo/referenceCalculation/referenceCalculation.hpp>
#include <src/Engine/MonteCarlo/IRProduct/rateCalculation/range1D.hpp>
#include <src/Engine/MonteCarlo/eventCalculation/jointEventCalculation/simpleJointCal/jointSimpleCalculation.hpp>

namespace QuantLib {

	class SimpleRangeEventCal : public EventCalculation
	{
		public:
			SimpleRangeEventCal(const boost::shared_ptr<Range1D>& range1D,
								//const boost::shared_ptr<ReferenceCalculationInfo>& referenceCalInfo,
								const boost::shared_ptr<ReferenceCalculation>& referenceCal,
								const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList = std::vector<boost::shared_ptr<VariableInfo>>() );

			Real accrualNum(const MultiPath& path,Size endPosition);

			void initializeImpl(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			std::vector<Date> fixingDates() const;
			std::vector<Date> payoffDates() const;

			bool pastEventOcc();;
			
			bool inRange(const std::valarray<Real>& val);

		protected:
			//Real payoffImpl(const MultiPath& path,Size endPosition);
			bool checkEventImpl(const MultiPath& path,Size endPosition);

			boost::shared_ptr<Range1D> range1D_;
			//boost::shared_ptr<ReferenceCalculationInfo> referenceCalInfo_;
			boost::shared_ptr<ReferenceCalculation> referenceCal_;
			Size fixingAccrualNum_;

			std::valarray<Real> refValArr_;

	};
}

#endif