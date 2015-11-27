#ifndef quantlib_constantpayoffEventInfo_hpp
#define quantlib_constantpayoffEventInfo_hpp

#include <src/Engine/MonteCarlo/pricer/event/eventtriggerInfo.hpp>

namespace QuantLib {

	// �̰� ��ü Barrier�� �κ� �踮��� ���� ����
	class ConstantPayoffETI : public EventTriggerInfo
	{
		public:
			ConstantPayoffETI(double unit,
						   const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
						   double constValue,
						    const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);
			
			void initializeImpl(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);
			
			std::vector<Date> fixingDates() const;
			std::vector<Date> payoffDates() const;

			bool pastEventOcc();

			bool checkEvent(const MultiPath& path,Size endPosition);

		protected:
			Real payoffImpl(const MultiPath& path,Size endPosition);

		private:
			double unit_;
			double constValue_;

	};

}

#endif