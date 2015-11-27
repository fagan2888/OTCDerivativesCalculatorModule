#ifndef quantlibTest_standardSwap_hpp
#define quantlibTest_standardSwap_hpp

#include <ql/time/date.hpp>
#include <ql/pricingEngine.hpp>
#include <ql/instrument.hpp>
#include <ql/testClass/standardswapTest/swappayoff.hpp>

namespace QuantLib {

	class StandardSwap : public Instrument
{
	public:
		//�߰��� �Ϻΰ� ��ȯ�� �� �����Ƿ� ���⼭ Notional�� ������� ����.
		StandardSwap(const Date& issueDate,
					const Date& maturityDate,
					Natural settlementDays,
					const boost::shared_ptr<SwapPayoff>& swappayoff,
					const DayCounter& dayCounter);
					//const std::vector<boost::shared_ptr<StockIndex>>& refIndex,
					//const Schedule& schedule,
					
					
		
		class arguments;
        class results;
        class engine;

		//Instrument interface

		std::string decription() const{return "StandardSwap";}
		void setupArguments(PricingEngine::arguments* args) const;
		bool isExpired() const{ return false;} // �켱 ����
		//Real accrualNPV() const;

	protected:


	private:
		Date issueDate_;
		Date maturityDate_;
		Natural settlementDays_;
		boost::shared_ptr<SwapPayoff> swappayoff_;
		DayCounter dayCounter_;
		
		//Real accrualNPV_;

};

class StandardSwap::arguments : public PricingEngine::arguments {

    public:
        
        Real nominal;

		Date issueDate;
		Date maturityDate;
		Natural settlementDays;
		DayCounter dayCounter;
		boost::shared_ptr<SwapPayoff> swappayoff;

		void validate() const{};

};

class StandardSwap::results : public Instrument::results {
    public:
		//Rate fairRate;
  //      Spread fairSpread;
        //void reset();
};


class StandardSwap::engine : public GenericEngine<StandardSwap::arguments,
                                                 StandardSwap::results> {
};

}

#endif