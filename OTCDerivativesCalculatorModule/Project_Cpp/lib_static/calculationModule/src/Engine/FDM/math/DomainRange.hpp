#ifndef quantlib_domain_range_hpp
#define quantlib_domain_range_hpp

#include "Domain.hpp"

namespace QuantLib {

    class DomainRange : public Domain {
      public:
		  virtual ~DomainRange() {}
		  
		  DomainRange(const boost::shared_ptr<FdmPayoffFunction>& function,
					 Real a,
					 Real b,
					 bool a_equality = false,
					 bool b_equality = false,
					 bool inOut = true) // true : in , false : out
		  {
		  
		  }
		  
		  bool eventOcc(const std::valarray<Real>& value) const
		  {
			  Real y = function_->calValue(value);

			  bool result = false;

			  if(a < y && y < b)
				  result = true;

			  return result;

		  }


		  
		  // operation
	
	};
}

#endif