#ifndef test_structuredProduct_hpp
#define test_structuredProduct_hpp

//#include <ql/instrument.hpp>
//#include <calculationmodule/src/instrument/swap/currencyrateswap/currencyrateswap.hpp>
//#include <xmlFactory/Factory/Instrument/Swap/CurrencyRateSwap/CurrencyRateSwapFactory.hpp>

#include <FileManager.hpp>
#include <ahn-product-1-0\StructuredProduct.hpp>
#include <xmlFactory/Factory/Instrument/StructuredProduct/qlStructuredProductFactory.hpp>
#include <calculationModule/src/engine/montecarlo/structuredproduct/MCStructuredProductEngine.hpp>

#include <boost/shared_ptr.hpp>

#include <ql\math\randomnumbers\rngtraits.hpp>
#include <ql/math/statistics/statistics.hpp>

#include <ql/methods/montecarlo/multipathgeneratorfixedpath.hpp>

//using namespace XmlFactory;

int testSP()
{
	TiXmlDocument doc( "testStructruedProductNodeExceptTime.xml" );
	doc.LoadFile();
	TiXmlNode* rootNode = doc.RootElement();

	if (rootNode)
	{
		boost::shared_ptr<FpmlSerialized::StructuredProduct> fpml_sp = 
			boost::shared_ptr<FpmlSerialized::StructuredProduct>(new FpmlSerialized::StructuredProduct(rootNode));
		
		FpmlSerialized::FileManager::instance().closeFile();

		XmlFactory::qlStructuredProductFactory qspf = XmlFactory::qlStructuredProductFactory();
		qspf.setSerialClass(fpml_sp);
		boost::shared_ptr<QuantLib::StructuredProduct> ql_sp = qspf.getSP();

		boost::shared_ptr<MCStructuredProductEngine<PseudoRandom,Statistics>> engine 
						= boost::shared_ptr<MCStructuredProductEngine<PseudoRandom,Statistics>>(new 
											MCStructuredProductEngine<PseudoRandom,Statistics>(10000,1));

		ql_sp->setPricingEngine(engine);
		ql_sp->NPV();


	}





	//PseudoRandom::rsg_type gen =
 //               PseudoRandom::make_sequence_generator(100,0);

	//boost::shared_ptr<MultiPathGeneratorFixedPath<PseudoRandom>> pgPtr 
	//							= boost::shared_ptr<MultiPathGeneratorFixedPath<PseudoRandom>>(
	//									   new MultiPathGeneratorFixedPath<PseudoRandom>());

	 

	
	//boost::shared_ptr<QuantLib::Instrument> inst = crs->getInstrument();

	

	return 0;
}

#endif