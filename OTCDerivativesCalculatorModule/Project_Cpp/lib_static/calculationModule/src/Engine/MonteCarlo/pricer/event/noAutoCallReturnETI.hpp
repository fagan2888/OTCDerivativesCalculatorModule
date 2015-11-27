#ifndef quantlib_noautocallreturntriggerinfo_hpp
#define quantlib_noautocallreturntriggerinfo_hpp

#include <ql/timegrid.hpp>
#include <ql/methods/montecarlo/multipath.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <src/Engine/MonteCarlo/returnCalculation/returnCalculation.hpp>
#include <ql/time/date.hpp>

namespace QuantLib {

	class NoAutoCallReturnETI : public EventTriggerInfo
	{
		public:
			NoAutoCallReturnETI(const boost::shared_ptr<ReturnCalculation>& returnCal,
								const boost::shared_ptr<FixingDateInfo>& payoffDateInfo,
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
			boost::shared_ptr<ReturnCalculation> returnCal_;

			//std::vector<Real> basePrice_;
	};

}

#endif