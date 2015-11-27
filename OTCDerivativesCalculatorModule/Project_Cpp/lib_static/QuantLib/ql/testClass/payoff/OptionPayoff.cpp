#include <ql/testClass/payoff/optionpayoff.hpp>

namespace QuantLib {

	OptionPayoff::OptionPayoff(const std::vector<boost::shared_ptr<EventCheck>>& eventChecks,
					 const UnderType& underTypes,
					 const std::vector< std::vector<boost::shared_ptr<Payoff>>>& hitEuPayoff, 
					 const std::vector<boost::shared_ptr<Payoff>>& nohitEuPayoff, 
					 const std::vector<boost::shared_ptr<Payoff>>& underlyingTransform)
	: eventChecks_(eventChecks), underTypes_(underTypes),hitEuPayoff_(hitEuPayoff),
	  nohitEuPayoff_(nohitEuPayoff), underlyingTransform_(underlyingTransform)
	{
				
				//eventOcc_ = false; //과거 히트는 나중에
				indexSize_ = underlyingTransform_.size();
				eventSize_ = eventChecks_.size();
				underValue_ = Array(indexSize_,0.0);
				hitEupayoffSize_ = hitEuPayoff.size();
				nohitEupayoffSize_ = nohitEuPayoff.size();
				weights_=Array(indexSize_, 1.0/static_cast<Real>(indexSize_));
	}


	Real OptionPayoff::underlyingFunc(const Array& indexValue) const{
		switch (underTypes_) {
			case MIN:
				return *std::min_element(indexValue.begin(),indexValue.end());
			case MAX:
				return *std::max_element(indexValue.begin(),indexValue.end());
			case AVER:
			 	return std::inner_product(weights_.begin(),weights_.end(),
										indexValue.begin(),0.0);
			default:
				QL_FAIL("unknown function type");
				return 0;
		}
	}

	Real OptionPayoff::value(const Array& indexValue) const{
		Real sum=0;
		
		//for(Size i=0;i<indexSize_;++i){
		//	underValue_[i]=(*underlyingTransform_[i])(indexValue[i]);
		//}
		//
		//for(Size k=0;k<eventSize_;++k){
		//	if(eventOcc_[k] == true){
		//		sum += (*hitEuPayoff_[k])(underlyingFunc(underValue_));
		//	}
		//
		//}

		//if(eventOcc_[i] == true){
		//	for(Size i=0;i<hitEupayoffSize_;++i){
		//		sum += (*hitEuPayoff_[i])(underlyingFunc(underValue_));
		//	}
		//}else{
		//	for(Size i=0;i<nohitEupayoffSize_;++i){
		//		sum += (*nohitEuPayoff_[i])(underlyingFunc(underValue_));
		//	}
		//}

		return sum;
	}
	std::vector<boost::shared_ptr<EventCheck>> OptionPayoff::eventChecks() const{
		return eventChecks_;
	}
	void OptionPayoff::checkEventOcc(const Array& indexValue,Size k) const{
		//if(barrierHit_ == false){
		//	for(Size i=0;i<indexSize_;++i){
		//		if(barrierHit_ == false){
		//			barrierHit_ = barrierChecks_[i]->check(indexValue[i]);
		//		}
		//	}
		//}
		//for(Size i=0;i<eventSize_;++i){
		//	if(eventChecks_[i]->isEventDay(k) ){
		//		eventChecks_[i]->check(indexValue);
		//	}
		//}

	}
	void OptionPayoff::reset() const{
		//eventOcc_=std::vector<bool>; // 과거 다시
	}

}