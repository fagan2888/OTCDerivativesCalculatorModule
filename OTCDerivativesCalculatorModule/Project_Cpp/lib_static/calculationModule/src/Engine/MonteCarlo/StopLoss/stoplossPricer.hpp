#ifndef quantlib_mc_stoplosspricer_engine_hpp
#define quantlib_mc_stoplosspricer_engine_hpp

#include <ql/types.hpp>
#include <boost/shared_ptr.hpp>
#include <valarray>
#include <src/Engine/MonteCarlo/MCPricer.hpp>
#include <src/Engine/MonteCarlo/Common/Interface/all.hpp>

namespace QuantLib {
	class StopLossPricer : public MCPricer {
		
		public:
			StopLossPricer(	boost::shared_ptr<IEventInfo> stopLossEventInfo,
							boost::shared_ptr<IReturnCalculation> stopLossCalculation,
							boost::shared_ptr<ISwapStream> standardStream,
							std::valarray<Real> discountFactor )
			: stopLossEventInfo_(stopLossEventInfo), stopLossCalculation_(stopLossCalculation),
			  standardStream_(standardStream) , discountFactor_(discountFactor)
			{
				
			}

			void initialize(const TimeGrid& timeGrid,
							const boost::shared_ptr<YieldTermStructure>& discountCurve,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
			{
				this->stopLossEventInfo_->initialize(timeGrid);
				this->stopLossCalculation_->initialize(timeGrid);
				this->standardStream_->initialize(timeGrid);
			}

			Real calculate(const MultiPath& multiPath)
			{
				Real value = 0.0;

				if( this->stopLossEventInfo_->eventOcc(multiPath) )
				{
					//Date eventDate = this->stopLossEventInfo_->eventDate();
					Size eventDateLocation = this->stopLossEventInfo_->eventDateLocation();
					
					value = stopLossCalculation_->returnCalculate(multiPath);

					if(standardStream_->accrualFlag())
						value += standardStream_->accrualCoupon(eventDateLocation);

				}

				return value;

			}

		private:
			boost::shared_ptr<IEventInfo> stopLossEventInfo_;
			boost::shared_ptr<IReturnCalculation> stopLossCalculation_;
			boost::shared_ptr<ISwapStream> standardStream_;
			std::valarray<Real> discountFactor_;

	};
}

#endif