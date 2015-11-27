//#include <ql/quantlib.hpp>
//#include <boost/timer.hpp>
//#include <iostream>
//#include <fstream>
//#include <random>
////---------------------------------------------------------------------
//
////void factoryStepDownKI();
//void testRandomSpeed();
//
//using namespace QuantLib;
//
//int main(int, char* []) 
//{
//	//factoryStepDownKI();
//	testRandomSpeed();
//	return 0;
//}
//
//
//void testRandomSpeed()
//{
//	std::ofstream SaveFile("hullwhiteprocess.txt");
//	
//
//	boost::shared_ptr<YieldTermStructure> yieldTS = boost::shared_ptr<YieldTermStructure>(
//				new FlatForward(Date(26,Aug,2013),0.032,Actual365Fixed()));
//	Handle<YieldTermStructure> yieldCurve = Handle<YieldTermStructure>(yieldTS);
//
//	HullWhiteProcess process = HullWhiteProcess(yieldCurve,0.0046,0.00498);
//
//	std::vector<double> rateVec;
//
//	double timeDt = 00.00396825396825397;
//	double time = 0.0;
//	double rand = 0.0;
//	double rate = 0.0277;
//
//	rateVec.push_back(rate);
//
//	std::tr1::mt19937 eng;
//	std::tr1::normal_distribution<double> dist; 
//	
//	Size simulNum = 1000;
//
//	for ( Size simulCount=0 ;simulCount<simulNum ;++simulCount){
//		
//		rate = 0.0277;
//		time = 0.0;
//
//		for ( Size i=0 ;i < 252 ; ++i )
//		{
//			//std::cout << rate << std::endl;
//			SaveFile << rate << "|" ;
//
//			rand = dist(eng);
//			rate = process.evolve(time , rate , timeDt , rand);
//			rateVec.push_back(rate);
//			time = time + timeDt;
//			
//		}
//		SaveFile << std::endl;
//	}
//
//	SaveFile.close();
//
//}
