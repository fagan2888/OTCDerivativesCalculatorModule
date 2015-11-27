#ifndef quantlib_JointEventCalculation_hpp
#define quantlib_JointEventCalculation_hpp

#include <src/Engine/MonteCarlo/IRefVariable.hpp>
#include <src/Engine/MonteCarlo/eventCalculation/eventCalculation.hpp>

namespace QuantLib {

	class JointEventCalculation : public EventCalculation
	{
		public:
			JointEventCalculation(const std::vector<boost::shared_ptr<EventCalculation>>& eventCalList,
								  const std::vector<boost::shared_ptr<VariableInfo>>& usingVariableInfoList);

			void initializeImpl(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);
			
			//bool checkEventImpl(const MultiPath& path,Size endPosition);

			//virtual bool pastEventOcc() = 0;
			//virtual std::vector<Date> fixingDates() const = 0;

			Real accrualNum(const MultiPath& path,Size endPosition)
			{
				return 0.0;
			}

		protected:
			Size eventNum_;
			std::vector<boost::shared_ptr<EventCalculation>> eventCalList_;
	};

}

#endif