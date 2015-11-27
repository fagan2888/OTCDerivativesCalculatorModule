#ifndef quantlib_hullwhiteProcess1Dwrapper_hpp
#define quantlib_hullwhiteProcess1Dwrapper_hpp

#include <src/Engine/MonteCarlo/stochasticProcess/IProcessWrapper.hpp>

namespace QuantLib 
{
	class HullWhiteProcess1DWrapper : public IProcessWrapper
	{
		public:
			//HullWhiteProcess1DWrapper(const boost::shared_ptr<HullWhiteProcess>& hullWhiteProcess);

			HullWhiteProcess1DWrapper(const std::string& code,
									  const std::string& currency,
									  const boost::shared_ptr<YieldTermStructure>& fittingCurve,
									  Period& tenor,		
									  Period& legTenor,
									  const std::string& rateType, // ir , cms , cmt
									  Real initialValue,
									  Real a,
									  Real sigma);

			//HullWhiteProcess1DWrapper(const std::string& code,
			//						  const std::string& currency,
			//						  const boost::shared_ptr<YieldTermStructure>& fittingCurve,
			//						  Period& tenor,	
			//						  Period& legTenor,
			//						  const std::string& rateType,
			//						  Real initialValue,
			//						  Real a,
			//						  Real sigma);

			void generatePath(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition);
			void convertingPath(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition);

			void generatePath_s_up(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition);
			void generatePath_s_down(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition);
			void generatePath_sigma_up(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition);
			void generatePath_sigma_down(MultiPath& targerPath,const MultiPath& randomSeq,Size todayPosition,Size assetPosition);

			void initialize(const TimeGrid& timeGrid);
			//void initializeMonthly(const TimeGrid& timeGrid);
			void convertingInitialize(const TimeGrid& timeGrid);

			bool isNeedSimul() { return true; }
			Real volatility() const;

			Real generatedValueConverting(Real v) { return v; }
			Real periodToTime(Period p);
			Real indexAdjustment(Real r_t,Size t);

			friend class CMSRate;

			class CMSRate {
		  
			  public:
				CMSRate(const std::vector<Real>& A_t_T,
						const std::vector<Real>& B_t_T,
						Real swapTenor,
						Real initialX)
					:A_t_T_(A_t_T), B_t_T_(B_t_T),swapTenor_(swapTenor),initialX_(initialX){}

				Real operator()(Real x) const;
				//Real derivative(Real x) const { return 2.0*x; }
			  private:
				Real initialX_;
				Real swapTenor_;
				std::vector<Real> A_t_T_;
				std::vector<Real> B_t_T_;
			};

		private:

			boost::shared_ptr<HullWhiteProcess> hullWhiteProcess_;
			boost::shared_ptr<YieldTermStructure> fittingCurve_;
			Period tenor_;
			Real r0_;
			Real a_;
			Real sigma_;

			Real sigma_perturbation_;
			// 
			Size pathSize_;

			//factor∏¶ chol«—∞≈
			Matrix factorChol_;

			// initial r 
			//Real r0_;

			// ft(0,t) + aF(0,t) + (sigma^2 / 2*sigma) * ( 1 - exp(-2at) )
			std::valarray<Real> thetaGrid_;

			std::valarray<Real> thetaGrid_s_up_;
			std::valarray<Real> thetaGrid_s_down_;

			std::valarray<Real> thetaGrid_sigma_up_;
			std::valarray<Real> thetaGrid_sigma_down_;
			
			std::valarray<Real> tGrid_;
			std::valarray<Real> dtGrid_;
			
			std::valarray<Real> converting_tGrid_;
			std::valarray<Size> converting_tPos_;
			//std::valarray<Real> volGrid_;

			Size factorNum_;
			Size convertingPathNum_;
			Size todayConvPosition_;

			std::string currency_;
			Period legTenor_;
			std::string rateType_;

		private:

			Real legFraction_;
			Size legTenorNum_;

			std::vector<std::vector<Real>> B_ti_T_;
			std::vector<std::vector<Real>> A_t_T_;

			//std::vector<Real> P_ti_T_;
	};
}

#endif