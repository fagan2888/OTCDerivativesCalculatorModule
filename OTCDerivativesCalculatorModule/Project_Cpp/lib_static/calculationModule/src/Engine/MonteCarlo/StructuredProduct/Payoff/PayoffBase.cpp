#include "payoffBase.hpp"
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolmanager/pathinformation.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolmanager/indexsymbolmanager.hpp>
#include <ql/settings.hpp>

namespace QuantLib {

// 이놈의 thisVariable은 factory에서 만들어짐. 왜냐면 정보가 거기있으니까.. 
// 간단한 연산만을 제공하며, 대부분 eit에서 계산되서 와야함.
// thisVariableValue_ 에 저장하는 건, eventcheck에서 event를 거치고 나온 payoff를 저장함
// 실제로 event 검사전 payoff는 그냥 값일뿐 다른데서 사용되지 않음, 왜냐하면,
// 실제로 어차피 최종 검사용이 아니고 단순 변환해서 나온 값이므로, 다시 계산해서 씀.
// 두개가 헷갈려서 하나로 감. 여깃는 thisvariablevalue는 eventcheck에서 사용할거임

PayoffBase::PayoffBase(const std::string& symbolName)
: symbolName_(symbolName)
{
	
}
void PayoffBase::setThisVariable(const boost::shared_ptr<VariableValue>& thisVariable)
{
	this->thisVariableValue_ = thisVariable;

}





std::string PayoffBase::symbolName()
{
	return this->symbolName_;
}

}