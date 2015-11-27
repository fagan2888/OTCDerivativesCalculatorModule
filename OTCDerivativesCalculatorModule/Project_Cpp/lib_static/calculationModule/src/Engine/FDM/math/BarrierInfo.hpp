#ifndef calculationModule_barrierInfo_hpp
#define calculationModule_barrierInfo_hpp

namespace QuantLib {

    class BarrierInfo {
      public:
		  virtual ~BarrierInfo() {}
		  
		  BarrierInfo(const std::vector<Date>& observationDates,
					  const std::vector<Domain>& barrierSet)


		  Domain unionDomain(return Domain();){}
		  Domain subtractDomain(return Domain();){}
		  Domain Complement(return Domain();){}

		  bool operator()(std::valarray<Real> values)
		  {
		      return true;
		  }
		  
		  // operation
	
	};
}

#endif