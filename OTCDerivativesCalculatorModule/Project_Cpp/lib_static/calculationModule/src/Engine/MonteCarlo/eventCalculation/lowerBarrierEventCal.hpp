#ifndef quantlib_LowerBarrierEventCal_hpp
#define quantlib_LowerBarrierEventCal_hpp

#include <src/Engine/MonteCarlo/eventCalculation/eventCalculation.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <src/Engine/MonteCarlo/eventCalculation/dateInformation/dateInformation.hpp>

namespace QuantLib {

	class LowerBarrierEventCal : public EventCalculation
	{
		public:
			LowerBarrierEventCal(const std::vector<boost::shared_ptr<DateInformation>>& dateInfoList,
								 const std::vector<Real>& lowerTrrigerList,
								 const boost::shared_ptr<ReferenceCalculation>& refCal,
								 const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList = std::vector<boost::shared_ptr<VariableInfo>>() );

			LowerBarrierEventCal(const boost::shared_ptr<DateInformation>& dateInfo,
								 const Real lowerTrriger,
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
			std::vector<Real> lowerTrrigerList_;
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