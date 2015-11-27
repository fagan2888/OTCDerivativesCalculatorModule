#ifndef quantlib_gbmProcess1Dwrapper_hpp
#define quantlib_gbmProcess1Dwrapper_hpp

#include <ql/processes/all.hpp>
#include <random>
#include <ql/methods/montecarlo/multipath.hpp>
#include <valarray>
#include <src/Engine/MonteCarlo/stochasticProcess/IProcessWrapper.hpp>

namespace QuantLib 
{
	class GBMProcess1DWrapper : public IProcessWrapper
	{
		public:

			GBMProcess1DWrapper(const boost::shared_ptr<GeometricBrownianMotionProcess>& gbmProcess);

			GBMProcess1DWrapper(const std::string& code,
								Real initialValue,
                                Real mue,
                                Real sigma);
			 
			void generatePath(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition);

			void generatePath_s_up(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition);
			void generatePath_s_down(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition);
			void generatePath_sigma_up(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition);
			void generatePath_sigma_down(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition);

			void initialize(const TimeGrid& timeGrid);
			bool isNeedSimul() { return true; }
			Real volatility() const;

			Real generatedValueConverting(Real v) { return v / this->basePrice_; }

		private:

			
			Real mue_;
			Real sigma_;

			// 
			Size pathSize_;

			//factor∏¶ chol«—∞≈
			Matrix factorChol_;

			Real S0_;
			Real S0_up_;
			Real S0_down_;

			std::valarray<Real> muGrid_;
			std::valarray<Real> muGrid_volup_;
			std::valarray<Real> muGrid_voldown_;

			std::valarray<Real> volGrid_;
			std::valarray<Real> vol_upGrid_;
			std::valarray<Real> vol_downGrid_;

			Size factorNum_;

			boost::shared_ptr<GeometricBrownianMotionProcess> gbmProcess_;
	};
}

#endif