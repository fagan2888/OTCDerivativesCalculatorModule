#ifndef quantlib_UpperBarrierEventCal_hpp
#define quantlib_UpperBarrierEventCal_hpp

#include <src/Engine/MonteCarlo/eventCalculation/eventCalculation.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <src/Engine/MonteCarlo/eventCalculation/dateInformation/dateInformation.hpp>

namespace QuantLib {

	class UpperBarrierEventCal : public EventCalculation
	{
		public:
			UpperBarrierEventCal(const std::vector<boost::shared_ptr<DateInformation>>& dateInfoList,
								 const std::vector<Real>& upperTrrigerList,
								 const boost::shared_ptr<ReferenceCalculation>& refCal,
								 const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList = std::vector<boost::shared_ptr<VariableInfo>>() );

			void initializeImpl(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			Real accrualNum(const MultiPath& path,Size endPosition);

			std::vector<Date> fixingDates() const;
			std::vector<Date> payoffDates() const;

			bool pastEventOcc();;
			bool inRange(const std::valarray<Real>& val);

		protected:
			bool checkEventImpl(const MultiPath& path,Size endPosition);

		private:
			std::vector<boost::shared_ptr<DateInformation>> dateInfoList_;
			std::vector<Real> upperTrrigerList_;
			boost::shared_ptr<ReferenceCalculation> refCal_;

			std::vector<std::valarray<Size>> fixingDatePositionList_;
			std::vector<Size> fixingDatePositionSizeList_;

			Size barrierNum_;
			
			bool pastEventOcc_;

			// 지난거 barrier ( 시작하는 위치를 뜻함 )
			Size pastBarrierStartCount_;

			// 지난거 barrier중에 시작되는 position위치를 뜻함
			Size pastBarrierStartPosition_;


	};
}

#endif