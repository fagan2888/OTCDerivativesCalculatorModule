#ifndef quantlib_mc_pricer_engine_hpp
#define quantlib_mc_pricer_engine_hpp

#include <ql/types.hpp>
#include <ql/timegrid.hpp>
#include <ql/methods/montecarlo/multipath.hpp>
#include <ql/termstructures/yieldtermstructure.hpp>
#include <ql/time/date.hpp>
#include <src/Engine/MonteCarlo/PathGeneratorFactory.hpp>
#include <src/Engine/MonteCarlo/variableInfo/variableInfo.hpp>
#include <src/Engine/MonteCarlo/pricer/event/eventTriggerInfo.hpp>
#include <src/util/CashFlowResult.hpp>
#include <src/util/CalcValueResult.hpp>

namespace QuantLib {

	class MCPricer {
		public:
			MCPricer() 
			{
				this->notional_ = 1.0;
				this->currency_ = "KRW";
			}

			//여기서 refVariable set을 하고
			void initialize(const TimeGrid& timeGrid,
						 	const boost::shared_ptr<YieldTermStructure>& discountCurve,
						 	const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			virtual Real calculate(const MultiPath& multiPath,Size endPosition = 9999 ) const = 0;
			//virtual Real calculateEarlyEx(const MultiPath& multiPath,Size endPosition) const = 0;

			virtual std::vector<Date> fixingDates() const = 0;
			virtual std::vector<Date> payoffDates() const = 0;
			
			void reset() const;

			Size earlyExEventPosition() { return this->earlyExEventPosition_;}

			virtual bool autoCallEvent(const MultiPath& path) { return false; }
			virtual Real autoCallPayoff(Size position) { return 0.0; }
			
			virtual std::vector<boost::shared_ptr<EventTriggerInfo>> getEtiList() const 
			{
				return eventTriggerList_;
			}

			virtual Real getNotional() const
			{
				return notional_;
			}

			virtual std::string getCurrency() const
			{
				return currency_;
			}

			virtual boost::shared_ptr<FixingDateInfo> getPayoffDateInfo() const
			{
				return payoffDateInfo_;
			}

			void registVariableInfo(const std::vector<boost::shared_ptr<VariableInfo>>& variableInfoList);

			std::valarray<Real> valueTimeHorizon() const { return this->valueTimeHorizon_; }
			std::valarray<Real> earlyExCount() const { return this->earlyExCount_; }

			virtual std::vector<boost::shared_ptr<CashFlowResult>> cashFlowResults() { return this->cf_results_; } 
			virtual std::vector<boost::shared_ptr<CalcValueResult>> valueResults() { return this->calcValue_results_; } 

		protected:
			Real notional_;
			std::string currency_;
			std::vector<boost::shared_ptr<EventTriggerInfo>> eventTriggerList_;

		    // discount를 위한 것
		    boost::shared_ptr<FixingDateInfo> payoffDateInfo_;


			virtual void initializeImpl(const TimeGrid& timeGrid,
						 				const boost::shared_ptr<YieldTermStructure>& discountCurve,
						 				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory) = 0;
			
			virtual void resetImpl() const = 0;

			mutable Real value_;
			mutable std::vector<boost::shared_ptr<VariableInfo>> variableInfoList_;
			mutable std::valarray<Real> valueTimeHorizon_;
			mutable Size earlyExEventPosition_;

			mutable std::vector<boost::shared_ptr<CashFlowResult>> cf_results_;
			mutable std::vector<boost::shared_ptr<CalcValueResult>> calcValue_results_;

			mutable std::valarray<Real> earlyExCount_;
	};
}

#endif