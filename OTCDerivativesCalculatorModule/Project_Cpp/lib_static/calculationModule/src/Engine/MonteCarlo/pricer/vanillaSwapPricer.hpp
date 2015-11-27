#ifndef quantlib_mc_vanillaSwapPricer_hpp
#define quantlib_mc_vanillaSwapPricer_hpp

#include <boost/shared_ptr.hpp>

#include <src/Engine/MonteCarlo/MCPricer.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <ql/termstructures/all.hpp>

namespace QuantLib {

    class VanillaSwapPricer : public MCPricer {
      public:
        VanillaSwapPricer(const boost::shared_ptr<MCPricer>& payPart,
						  const boost::shared_ptr<MCPricer>& recievePart);

		//interface
		void initializeImpl(const TimeGrid& timeGrid,
						const boost::shared_ptr<YieldTermStructure>& discountCurve,
						const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

		

		Real calculate(const MultiPath& path,Size endPosition = 0) const;
		std::vector<Date> fixingDates() const;
		std::vector<Date> payoffDates() const;
	protected:
		void resetImpl() const;

      private:
		  
		  Size remainEventPosition_;

		  //boost::shared_ptr<PayoffCalculation> occBarrierPayoffCalculation_;
		  boost::shared_ptr<MCPricer> payPart_;
		  boost::shared_ptr<MCPricer> recievePart_;
          //Array discount_;

		  std::vector<Date> fixingDates_;
		  std::vector<Date> payoffDates_;
	};
}

#endif