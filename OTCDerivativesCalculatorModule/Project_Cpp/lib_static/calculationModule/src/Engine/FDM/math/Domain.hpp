#ifndef quantlib_domain_hpp
#define quantlib_domain_hpp

#include <ql/math/array.hpp>
#include <ql/experimental/finitedifferences/fdmmesher.hpp>
#include <valarray>

namespace QuantLib {

	enum SetOperation {OR , AND};

    class Domain {
      public:
		  virtual ~Domain() {}
		  
		  Domain(){}
		  
		  Array& buildIndexPosition(const boost::shared_ptr<FdmMesher>& mesher) 
		  {
			  const boost::shared_ptr<FdmLinearOpLayout> layout = mesher->layout();
			  const FdmLinearOpIterator endIter = layout->end();
			  
			  Array position(endIter.index());
			  Size positionCount = 0;

			  Array x(mesher->layout()->dim().size());

			  for (FdmLinearOpIterator iter = layout->begin(); iter != endIter; ++iter) 
			  {
				  for (Size i=0 ; i < x.size(); ++i) 
				  {
					  x[i] = mesher_->location(iter, i);
				  }
				  
				  if(this->()(x))
				  {
					  indexPosition_.push_back(iter.index());
					  positionCount += 1;
				  }
			  }

			  return position;
		  }

		  bool eventOcc(std::valarray<Real> values) = 0;

	protected:
		boost::shared_ptr<FdmMesher>& mesher_;

		  
		  // operation
	
	};
}

#endif