#include "EventIndexTransformation.hpp"

namespace QuantLib {

EventIndexTransformation
	::EventIndexTransformation(std::vector<boost::shared_ptr<VariableValue>> variableValues)
	: variableValues_(variableValues)
{

	variableValueNum_ = variableValues_.size();


	for(Size i=0;i<variableValues_.size();++i)
	{
		//variableValues_[i]->symbolName();
		variableValuesPtr_[i]=variableValues_[i].get();
	}
}

Size EventIndexTransformation::size()
{
	return variableValues_.size();
}

void EventIndexTransformation::initialize(const std::vector<Date>& eventDates)
{
	for(Size i=0;i<variableValueNum_;++i)
	{
		variableValuesPtr_[i]->initialize(eventDates);
	}
}

//void EventIndexTransformation::setTimeInformation(const std::vector<Date>& eventDates)
//{
//	for(Size i=0;i<variableValueNum_;++i){
//		variableValuesPtr_[i]->setTimeInformation(eventDates);
//	}
//}

void EventIndexTransformation::variableBind()
{
	for(Size i=0;i<variableValueNum_;++i)
	{
		variableValuesPtr_[i]->variableBind();
	}
}

void EventIndexTransformation::variablePtrBind()
{
	for(Size i=0;i<variableValueNum_;++i)
	{
		variableValuesPtr_[i]->variablePtrBind();
	}
}



void EventIndexTransformation::validFixingDates(const std::vector<Date>& eventDates)
{
	for(Size i=0;i<variableValueNum_;++i)
	{
		variableValuesPtr_[i]->validFixingDates(eventDates);
	}
}

std::vector<Date> EventIndexTransformation::indexFixingDates()
{
	std::vector<Date> fixings;
	
	for(Size i=0 ; i < variableValueNum_ ; ++i)
	{
		const std::vector<Date>& fixingDates = this->variableValuesPtr_[i]->indexFixingDates();
		fixings.insert(fixings.begin(),fixingDates.begin(),fixingDates.end());
	}

	return fixings;
}

void EventIndexTransformation::calculate()
{
	for(Size i=0;i<variableValueNum_;++i){
		variableValuesPtr_[i]->calculate();
	}
}

void EventIndexTransformation::calculate(Size timePosition)
{
	//timeType 인경우에 이게 call 되면 안됨. timetype class에서 막아 놨음. 걱정안해도 됨.
	for(Size i=0;i<variableValueNum_;++i){
		variableValuesPtr_[i]->calculate(timePosition);
	}
}

}