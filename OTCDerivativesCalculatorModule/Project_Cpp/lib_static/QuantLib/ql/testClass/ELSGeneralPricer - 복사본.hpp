#ifndef quantlib_testClass_ELS_ELSGeneralPricer_hpp
#define quantlib_testClass_ELS_ELSGeneralPricer_hpp

#include <ql/processes/stochasticprocessarray.hpp>
#include <ql/math/matrix.hpp>
#include <ql/math/statistics/statistics.hpp>
#include <ql/math/matrixutilities/choleskydecomposition.hpp>
#include <ql/testClass/ELSStepDown.hpp>
#include <ql/math/randomnumbers/rngtraits.hpp>
#include <ql/testClass/checkKIType.hpp>


namespace QuantLib {

class ELSGeneralPricer {
      public:
		ELSGeneralPricer();
        ELSGeneralPricer(//const boost::shared_ptr<PayoffLeg> & payoffLeg,
                             const std::vector<Time> & times,
							 const boost::shared_ptr<StochasticProcessArray>& process,
							 const Array & x0_def,
							 const std::vector<Real> & underValue,
							 const std::vector<Real>& dividendValue,
                             const Array & discounts,
							 const Array & KIRedemPayoff,
						     const Matrix & earlyExValues_Chg,
						     const Matrix & KIbarrierValues_Chg,
							 const std::vector<Real>& KIbarrierValue,
							 const std::vector<Real>& earlyExValue,
						     const std::vector<Real>& redemCoupon,
							 const TimeGrid& timeGrid,
							 Size pastFixingNum,
							 Size seed,
							 std::vector<Statistics>& additionalStats,
							 CheckKIType checkKIType,
							 bool KIfalg
							 );

		virtual Real values(Size simul) const;

		//2013-01-25 greek 때매 추가함
		std::vector<Real> delta() const;
		std::vector<Real> gamma() const;
		std::vector<Real> vega() const;

		std::vector<Real> Sup() const;
		std::vector<Real> SDown() const;
		std::vector<Real> VolUp() const;
		std::vector<Real> VolDown() const;
		std::vector<Real> step_h() const;

	  protected:
		  void setInformation() const;
		  bool KIflag(){return KIflag_;}
		  bool checkEarlyRedem(Array& sumdZ,Size i) const;
		  bool checkKI(Array& sumdZ,Size i) const;
		  Real SumdZMin(Array& sumdZ) const;
		  Real slopePayoff(Array& sumdZ) const; //마지막 payoff

		  void resetPara() const;
		  Real eachValues(Size simulNum) const;

        std::vector<Time> times_;
		mutable Array x0_def_; // mutable 로 변경 2013-01-25 Greek 때문에 변경함.
		mutable Array x0_; // mutable 로 변경 2013-01-25 Greek 때문에 변경함.
		boost::shared_ptr<StochasticProcessArray>  process_;
        Array discounts_;
		Array KIRedemPayoff_;
		mutable Matrix earlyExValues_Chg_;
	
		mutable Matrix KIbarrierValues_Chg_;
		Matrix chol_;
		//Matrix vol_;
		mutable Array vol_,vol_def_;
		mutable Matrix sigmaDt_,sigmaDt_def_;

		TimeGrid timeGrid_;
		std::vector<Real> dividendValue_;
		std::vector<Real> KIbarrierValue_;
		std::vector<Real> earlyExValue_;
		std::vector<Real> redemCoupon_;
		Size pastFixingNum_;
		Size m_; //Brownian Bridge;
		Size bridgeGridNum_; //Brownian Bridge Num;
		Size numberOfAssets_;
		Size numberOfTimes_;
		Size seed_;

		mutable std::vector<Statistics>& additionalStats_;
		Size countMe_;

		Array corrCoff_;
		CheckKIType checkKIType_;
		bool monthlyflag_;
		bool KIflag_;

		mutable std::vector<Real> S_Up_ , S_Down_ , Vol_Up_ , Vol_Down_; 
		mutable std::vector<Real> delta_ , gamma_ , vega_; //나중에 additionalResult에 들어갈거여서 vector로 만듬.
		mutable std::vector<Real> underValue_;
		mutable std::vector<Real> step_h_;
    };


}

#endif