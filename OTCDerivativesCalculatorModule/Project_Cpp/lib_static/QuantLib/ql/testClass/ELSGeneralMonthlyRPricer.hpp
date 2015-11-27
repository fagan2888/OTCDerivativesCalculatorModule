#ifndef quantlib_testClass_ELS_ELSGeneralMonthlyRPricer_hpp
#define quantlib_testClass_ELS_ELSGeneralMonthlyRPricer_hpp

#include <ql/processes/stochasticprocessarray.hpp>
#include <ql/math/matrix.hpp>
#include <ql/math/statistics/statistics.hpp>
#include <ql/math/matrixutilities/choleskydecomposition.hpp>
#include <ql/math/randomnumbers/rngtraits.hpp>
#include <ql/testClass/checkKIType.hpp>

namespace QuantLib {

	class ELSGeneralMonthlyRPricer {
      public:
        ELSGeneralMonthlyRPricer(//const boost::shared_ptr<PayoffLeg> & payoffLeg,
                             const std::vector<Time> & times,
							 const boost::shared_ptr<StochasticProcessArray>& process,
							 const Array & x0,
                             const Array & discounts,
						     const std::vector<bool> & earlyRedemtimePositions,
							 const Array & KIRedemPayoff,
						     const Matrix & earlyExValues_Chg,
						     const Matrix & KIbarrierValues_Chg,
						     const std::vector<Real>& redemCoupon,
							 Real KILossCoupon,
							 Size pastFixingNum,
							 Size pastKICount,
							 Size seed,
							 std::vector<Statistics>& additionalStats,
							 CheckKIType checkKIType,
							 bool KIfalg);

		  virtual Real values(Size simul) const;
		
	  public:
		  std::vector<Real> earlyExProb(){return earlyExProb_;}
	  protected:
		  bool KIflag(){return KIflag_;}
		  // ���������޽��� ��� redemCoupon�� �����ڷ� �����.(������ �����ȯ�� �����ε�, ���� ���ݻ�ȯ�Ǽ� 0�̾ �����ڷ� ������)
		  bool checkEarlyRedem(Array& sumdZ,Size i) const;

		  bool checkKI(Array& sumdZ,Size i) const;
		  Real SumdZMin(Array& sumdZ) const;
		  Real slopePayoff(Array& sumdZ) const; //������ payoff
		  Real lossCountPayoff(Array& sumdZ) const; //loss ���� �������� ���ִ� �� payoff

		  void KIPayoff(Array& sumdZ,Size i) const; //monthly loss counter


		std::vector<Time> times_;
		Array x0_;
		boost::shared_ptr<StochasticProcessArray>  process_;
        Array discounts_;
		Array KIRedemPayoff_;
		Matrix earlyExValues_Chg_;
	
		Matrix KIbarrierValues_Chg_;
		Matrix chol_;
		//Matrix vol_;
		Array vol_;
		Matrix sigmaDt_;
		std::vector<Real> redemCoupon_;
		Size pastFixingNum_;
		Size m_; //Brownian Bridge;
		Size bridgeGridNum_; //Brownian Bridge Num;
		Size numberOfAssets_;
		Size seed_;

		mutable std::vector<Statistics>& additionalStats_;
		mutable std::vector<Real> earlyExProb_;
		Size countMe_;

		Array corrCoff_;
		CheckKIType checkKIType_;
		bool monthlyflag_;
		bool KIflag_;

		Real KILossCoupon_;
		Size pastKICount_;

		mutable Size KILossCount_;
		std::vector<bool> earlyRedemtimePositions_;

		
    };


}

#endif