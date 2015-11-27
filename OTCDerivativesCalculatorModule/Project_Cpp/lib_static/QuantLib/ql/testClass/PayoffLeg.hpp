//Leg�� ��ӹ޾Ƽ� �����? Leg InterFace�� ����ؾ� �ϴϱ�.

//Index�� ��ǰ���� �����ͼ� ����ٰ� �ھ���. ������ Set�Ҽ��� ����.

#include <ql/cashflow.hpp>
#include <iostream>
#include <ql/math/matrix.hpp> 
#include <ql/option.hpp>
#include <ql/handle.hpp>
#include <ql/indexes/iborindex.hpp>
#include <ql/time/schedule.hpp>

#ifndef quantlib_payoffLeg_hpp
#define quantlib_payoffLeg_hpp

#include <ql/testClass/montecoupon.hpp>


namespace QuantLib{

class PayoffLeg {
	public:
		PayoffLeg(const std::vector<Date>& dates,
				  //const std::vector<boost::shared_ptr<MonteCoupon>>& payoff,
				  std::vector<boost::shared_ptr<Index>>& refIndex);
		//virtual std::string name() const = 0;
        //virtual std::string description() const = 0;
		virtual void value(std::vector<Array> & path, 
					Array   & payments, 
					Array   & exercises, 
					std::vector<Array> & states) = 0;
		
		void setRefIndex(const std::vector<boost::shared_ptr<Index>>& refIndex);
		std::vector<IndexType> indexType() const{return indexType_;};
		void setPastFixing(std::vector<Array> & path);
		void setPastCashflow();
		
		Real nominal() const {return Redemption_;}
		const std::vector<Date>& dates(){return dates_;}
		std::vector<boost::shared_ptr<MonteCoupon>> payoff() const;
		//std::vector<Real>& pastCashflow() const;

		void initialize();

		Leg& leg();
	protected:
		bool earlyExFlag_;
		std::vector<Date> dates_;
		Array initialIndexFixings_;
		std::vector<boost::shared_ptr<MonteCoupon>> payoff_;
		std::vector<boost::shared_ptr<Index>> refIndex_;
		std::vector<IndexType> indexType_;
		Size pastFixingNum_;
		Size totalFixingNum_;
		std::vector<Real> pastCashflow_;
		Real calculatedPayment_;
		bool calFlag_;


		Real Redemption_;
		Leg leg_;

};



}

#endif