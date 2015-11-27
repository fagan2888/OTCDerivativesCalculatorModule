#ifndef quantlib_setHistoryParametor_hpp
#define quantlib_setHistoryParametor_hpp

#include <ql/processes/stochasticprocessarray.hpp>

namespace QuantLib {

    class SetHistoryParametor {
      public:
			
		  virtual void setProcess(const boost::shared_ptr<StochasticProcessArray>& process) const=0;//={
			  //QL_FAIL("this method does not support.");
		  //}
		  //virtual void drift(){QL_FAIL("this method does not support.")}
	};
}

#endif