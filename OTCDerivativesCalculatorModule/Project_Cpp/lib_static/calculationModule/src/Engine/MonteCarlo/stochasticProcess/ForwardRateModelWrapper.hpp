#ifndef quantlib_ForwardRateModelWrapper_hpp
#define quantlib_ForwardRateModelWrapper_hpp

#include <src/Engine/MonteCarlo/stochasticProcess/IProcessWrapper.hpp>

namespace QuantLib 
{
	class ForwardRateModelWrapper : public IProcessWrapper
	{
		public:
			ForwardRateModelWrapper(const std::string& code,
									const boost::shared_ptr<YieldTermStructure>& fittingCurve,
									Real initialValue,
									Period& tenor);
									//Real r0);				  

			void generatePath(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition);

			void generatePath_s_up(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition = 0);
			void generatePath_s_down(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition = 0);
			void generatePath_sigma_up(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition = 0);
			void generatePath_sigma_down(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition = 0);

			void initialize(const TimeGrid& timeGrid);
			bool isNeedSimul() { return false; }
			Real volatility() const { return 0.0; }

			Real indexAdjustment(Real r);


		private:

			boost::shared_ptr<YieldTermStructure> fittingCurve_;
			Period tenor_;
			// 
			Size pathSize_;

			// initial r 
			//Real r0_;

			Real s_perturbation_;

			Size factorNum_;
			Size positionNum_;
			std::vector<Real> values_;

	};
}

#endif