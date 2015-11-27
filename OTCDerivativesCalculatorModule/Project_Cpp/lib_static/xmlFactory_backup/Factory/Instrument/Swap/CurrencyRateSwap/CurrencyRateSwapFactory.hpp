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
		
		//�׳� �ȿ��� �־ ������

		void make();

		//�켱�� ����ٰ� ����. ������ ���� ������ �ʰ�..
		boost::shared_ptr<QuantLib::InterestRateIndex> 
			irIndex(const boost::shared_ptr<InterestRateStream>& irStream) ;

		boost::shared_ptr<QuantLib::DayCounter> 
			makeDayCounter(const boost::shared_ptr<CalculationPeriodAmount>& cpa);
		// class �� �����⿣ ��ǰ�ȿ� �ִ� �ٸ� ������ ����ؾ��ϴ� ��� ���� ���� ����
	protected:

		boost::shared_ptr<QuantLib::PricingEngine> getEngine();

		boost::shared_ptr<FpmlSerialized::Swap> crs_;
		boost::shared_ptr<QuantLib::CurrencyRateSwap> qlcrs_;

};

}
