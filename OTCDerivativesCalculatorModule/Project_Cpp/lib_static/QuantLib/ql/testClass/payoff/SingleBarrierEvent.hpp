#ifndef quantlib_singlebarrierEvent_hpp
#define quantlib_singlebarrierEvent_hpp

#include <ql/testClass/payoff/EventCheck.hpp>


namespace QuantLib {

	class SingleBarrierEvent : public EventCheck
	{
	public:

		SingleBarrierEvent(int indexNum,
						   double barrierValue,
						   std::vector<Date> dates,
						   EventDateType eventDateType,
						   CheckUnderType underType ,
						   BarrierType barrierType,	
						   int chooseNum = -1)
			: indexNum_(indexNum),barrierValue_(barrierValue),dates_(dates),eventDateType_(eventDateType),
			barrierType_(barrierType),underType_(underType),chooseNum_(chooseNum){}

		//member function
		inline BarrierType barrierType() const{return barrierType_;}
		inline void check(const Array& indexValue,Size pathIndexK) const{
			
			if(!eventOcc_ && isEventDate(pathIndexK)){
				if(underType == Both){
					for(int i=0;i<indexNum_;++i){
						if(indexValue[i] < barrierValue_)
							barrierValue_=true;
					}
				}else if (barrierType == Upper){
					switch (underType){
						case UnderMin:
							if(underMin(indexValue) > barrierValue_)
								upperFlag_=true;					
							break;
						case UnderMax:
							if(underMax(indexValue) > barrierValue_)
								upperFlag_=true;					
							break;
						case Choose:
							if(indexValue[chooseUpperNum_] > barrierValue_)
								upperFlag_=true;					
							break;	
						case EtcFunction:
							
							break;	
					}
				}else{
					
					switch (underType){
						case UnderMin:
							if(underMin(indexValue) < barrierValue_)
								lowerFlag_=true;					
							break;
						case UnderMax:
							if(underMax(indexValue) < barrierValue_)
								lowerFlag_=true;					
							break;
						case Choose:
							if(indexValue[chooseUpperNum_] < barrierValue_)
								lowerFlag_=true;					
							break;	
						case EtcFunction:
							
							break;	
					}
				}
			}
		}
		
	private:
		int chooseNum_;
		double barrierValue_;
		mutable bool barrierValue_Flag_;
		CheckUnderType underType_;
		BarrierType barrierType_;

	};


}

#endif