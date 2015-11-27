#include <FpmlSerialized/GenClass/fpml-ird-5-4/Swap.hpp>
#include <xmlFactory/Factory/Etc/qlCashFlowFactory.hpp>
//#include <xmlFactory/Factory/Instrument/Swap/CurrencyRateSwap/CurrencyRateSwapFactory.hpp>

//Extension Class from quantLib
#include <calculationModule/src/instrument/swap/currencyRateSwap/currencyRateswap.hpp>
#include <xmlFactory/Factory/Etc/qlTermstructureFactory.hpp>

using namespace FpmlSerialized;
using namespace QuantLib;

namespace XmlFactory {

class CurrencyRateSwapFactory {

	public:
		CurrencyRateSwapFactory(const boost::shared_ptr<FpmlSerialized::Swap>& crs);

		boost::shared_ptr<QuantLib::CurrencyRateSwap> getInstrument();
		
		//그냥 안에서 넣어서 리턴해

		void make();

		//우선은 여기다가 놔둠. 딴데서 쓸거 같지도 않고..
		boost::shared_ptr<QuantLib::InterestRateIndex> 
			irIndex(const boost::shared_ptr<InterestRateStream>& irStream) ;

		boost::shared_ptr<QuantLib::DayCounter> 
			makeDayCounter(const boost::shared_ptr<CalculationPeriodAmount>& cpa);
		// class 로 빼내기엔 상품안에 있는 다른 정보를 사용해야하는 경우 때매 아직 보류
	protected:

		boost::shared_ptr<QuantLib::PricingEngine> getEngine();

		boost::shared_ptr<FpmlSerialized::Swap> crs_;
		boost::shared_ptr<QuantLib::CurrencyRateSwap> qlcrs_;

};

}
