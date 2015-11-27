#ifndef quantlib_constKiMinLossPayoffTriggerETI_hpp
#define quantlib_constKiMinLossPayoffTriggerETI_hpp

#include <src/Engine/MonteCarlo/pricer/event/eventtriggerInfo.hpp>
#include <valarray>

namespace QuantLib {

	class ConstKiMinLossPayoffTriggerETI : public EventTriggerInfo
	{
		public:
			ConstKiMinLossPayoffTriggerETI(const boost::shared_ptr<ReferenceCalculation>& referenceCal,
										   const boost::shared_ptr<DateInformation>& kiBarrierDate,
										   const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
										   std::vector<Real> kiValues,
										   bool pastEventOcc,
										   const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

			void initializeImpl(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			std::vector<Date> fixingDates() const;
			std::vector<Date> payoffDates() const;

			bool pastEventOcc();
			bool autoCallEvent(const MultiPath& path);
			bool checkEvent(const MultiPath& path,Size endPosition);

		protected:
			Real payoffImpl(const MultiPath& path,Size endPosition);

		private:
			Size assetNum_;
			Size fixingDateNum_;
			std::valarray<Size> fixingDatePosition_;
			boost::shared_ptr<ReferenceCalculation> referenceCal_;
			boost::shared_ptr<DateInformation> kiBarrierDate_;
			std::valarray<Real> kiValues_;
			Real constReturn_;

	};

}

#endif