#ifndef quantlib_doublebarrierEvent_hpp
#define quantlib_doublebarrierEvent_hpp

#include <ql/testClass/payoff/EventCheck.hpp>

namespace QuantLib {

	class DoubleBarrierEvent : public EventCheck
	{
	public:

		DoubleBarrierEvent(int indexNum,
						   double upper,
						   double lower,
						   std::vector<Date> dates,
						   EventDateType eventDateType,
						   CheckUnderType upperUnderType = CheckUnderType::Both,
						   CheckUnderType lowerUnderType = CheckUnderType::Both,
						   int chooseUpperNum = -1,
						   int chooseLowerNum = -1)
			: indexNum_(indexNum),upper_(upper),lower_(lower),dates_(dates),
			  upperUnderType_(upperUnderType),lowerUnderType_(lowerUnderType),
			  chooseUpperNum_(chooseUpperNum),chooseLowerNum_(chooseLowerNum){}
		
		//member function
		inline void check(const Array& indexValue,Size pathIndexK) const{
			
			if(!eventOcc_ && isEventDate(pathIndexK)){
				if(upperUnderType == Both && lowerUnderType == Both){
					for(int i=0;i<indexNum_;++i){
						if(indexValue[i] < lower_)
							lowerFlag_=true;
						if(indexValue[i] > upper_)
							upperFlag_=true;
					}
				}else{
					if(!upperFlag_){
						switch (upperUnderType){
							case Both:
								if(underMax(indexValue) > upper_)
									upperFlag_=true;
								break;
							case UnderMin:
								if(underMin(indexValue) > upper_)
									upperFlag_=true;					
								break;
							case UnderMax:
								if(underMax(indexValue) > upper_)
									upperFlag_=true;					
								break;
							case Choose:
								if(indexValue[chooseUpperNum_] > upper_)
									upperFlag_=true;					
								break;	
							case EtcFunction:
								
								break;	
						}
					}
					if(!lowerFlag_){
						switch (lowerUnderType){
							case Both:
								if(underMax(indexValue) < lower_)
									lowerFlag_=true;
								break;
							case UnderMin:
								if(underMin(indexValue) < lower_)
									lowerFlag_=true;					
								break;
							case UnderMax:
								if(underMax(indexValue) < lower_)
									lowerFlag_=true;					
								break;
							case Choose:
								if(indexValue[chooseUpperNum_] < lower_)
									lowerFlag_=true;					
								break;	
							case EtcFunction:
								
								break;	
						}
					}
				}
				if(lowerFlag_==true && upperFlag_==true){eventOcc_=true;}
			}
		}
		
	private:
		int chooseLowerNum_,chooseUpperNum_;
		double lower_,upper_;
		mutable bool lowerFlag_,upperFlag_;
		CheckUnderType lowerUnderType_,upperUnderType_;


	};


}

#endif