#ifndef quantlib_SimpleRangeEventTimeCal_hpp
#define quantlib_SimpleRangeEventTimeCal_hpp

#include <src/Engine/MonteCarlo/eventCalculation/eventCalculation.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <src/Engine/MonteCarlo/referenceCalculation/referenceCalculation.hpp>
#include <src/Engine/MonteCarlo/IRProduct/rateCalculation/range1D.hpp>
#include <src/Engine/MonteCarlo/eventCalculation/jointEventCalculation/simpleJointCal/jointSimpleCalculation.hpp>

namespace QuantLib {

	//자 이건 뭐냐면...

	// accrual 할때 쓰거나. 

	class SimpleRangeEventTimeCal : public EventCalculation
	{
		public:
			SimpleRangeEventTimeCal(const boost::shared_ptr<Range1D>& range1D,
								const boost::shared_ptr<ReferenceCalculationInfo>& referenceCalInfo,
								const boost::shared_ptr<DateInformation>& dateInfo,
								const boost::shared_ptr<JointSimpleCalculation>& jointSimpleCal,
								const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

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
			boost::shared_ptr<ReferenceCalculationInfo> referenceCalInfo_;
			Size fixingAccrualNum_;

			std::valarray<Real> refValArr_;

			Size timeSize_;
			boost::shared_ptr<DateInformation> dateInfo_;
			boost::shared_ptr<JointSimpleCalculation> jointSimpleCal_;
			std::valarray<bool> timeJointArr_;

	};
}

#endif