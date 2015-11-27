//#ifndef test_crs_hpp
//#define test_crs_hpp
//
//#include <ql/instrument.hpp>
//#include <FpmlSerialized/GenClass/fpml-ird-5-4/swap.hpp>
//#include <calculationmodule/src/instrument/swap/currencyrateswap/currencyrateswap.hpp>
//#include <xmlFactory/Factory/Instrument/Swap/CurrencyRateSwap/CurrencyRateSwapFactory.hpp>
//
//
//using namespace XmlFactory;
//
//int test()
//{
//	TiXmlDocument doc( "ird-ex06-xccy-swap.xml" );
//	doc.LoadFile();
//	TiXmlNode* rootNode = doc.RootElement();
//	
//	boost::shared_ptr<FpmlSerialized::Swap> fpml_crs = boost::shared_ptr<FpmlSerialized::Swap>(new FpmlSerialized::Swap(rootNode));
//
//	boost::shared_ptr<CurrencyRateSwapFactory> crsf
//						= boost::shared_ptr<CurrencyRateSwapFactory>(new CurrencyRateSwapFactory(fpml_crs));
//
//	//boost::shared_ptr<QuantLib::Instrument> inst = crs->getInstrument();
//
//	
//
//	return 0;
//}
//
//#endif