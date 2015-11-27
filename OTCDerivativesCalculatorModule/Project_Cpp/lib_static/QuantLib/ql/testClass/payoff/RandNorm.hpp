#ifndef quantlib_randnorm_hpp
#define quantlib_randnorm_hpp
// This class is for ProcessArr COM. Excel VBA
#include <vector>
#include <random>

#include <cstdlib>


namespace QuantLib {

	class RandNorm {

	 public:
		RandNorm(){}
			
		const std::vector<double>& nextPath(int randNum,int seed){
			path.resize(randNum);
			
			std::tr1::mt19937 eng;
			std::tr1::normal_distribution<double> dist; 

			for(int i=0;i<randNum;++i){
				path[i]=dist(eng);
				
			}

			return path;
		}
		
	 private:
		 std::vector<double> path;
	};
}

#endif