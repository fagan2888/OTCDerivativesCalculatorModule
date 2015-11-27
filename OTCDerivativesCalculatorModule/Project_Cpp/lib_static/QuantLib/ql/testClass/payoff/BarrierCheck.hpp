#ifndef quantlib_barriercheck_hpp
#define quantlib_barriercheck_hpp

namespace QuantLib {
    
BarrierType { Upper , Lower };

	class BarrierCheck 
	{
	public:
		//constructor
		BarrierCheck(double a,BarrierType type){
			if(type==Upper){
				upper_=a;
				lower_=-1000000000;
			}
			else{
				upper_=1000000000;
				lower_=a;
			}
		}
		BarrierCheck(double a, double b){
			if(a<b){
				upper_=b;
				lower_=a;
			}
			else{
				upper_=a;
				lower_=b;
			}
		}
		
		//member function
		bool check(double value) const{
			if(value>upper_ || value<lower_)
			{
				return true;
			}

		return false;
		}

		double upper_,lower_;
	};


}

#endif