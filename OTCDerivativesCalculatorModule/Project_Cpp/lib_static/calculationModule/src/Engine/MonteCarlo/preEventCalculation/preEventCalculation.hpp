#ifndef quantlib_PreEventCalculation_hpp
#define quantlib_PreEventCalculation_hpp

//#include <src/Engine/MonteCarlo/IRefVariable.hpp>
#include <src/Engine/MonteCarlo/eventCalculation/eventCalculation.hpp>
#include <src/Engine/MonteCarlo/preEventCalculation/preEventCalculation.hpp>
#include <src/Engine/MonteCarlo/eventCalculation/jointEventCalculation/jointEventCalculation.hpp>

namespace QuantLib {

	class PreEventCalculation 
	{
		public:
			PreEventCalculation(const std::vector<boost::shared_ptr<EventCalculation>>& eventCalList,
								const std::vector<boost::shared_ptr<JointEventCalculation>>& jointEventCalList);

			void initialize(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);
			
			//bool checkEvent(const MultiPath& path,Size endPosition);
			void preEventCalculate(const MultiPath& path, Size endPosition = 0);
			void preEventCalculateEarlyEx(const MultiPath& path,Size endPosition);

		private:
			std::vector<boost::shared_ptr<EventCalculation>> eventCalList_;
			std::vector<boost::shared_ptr<JointEventCalculation>> jointEventCalList_;

	};
}

#endif