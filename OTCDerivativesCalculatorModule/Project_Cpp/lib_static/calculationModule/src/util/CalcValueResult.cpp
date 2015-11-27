#include "CalcValueResult.hpp"

namespace QuantLib 
{

CalcValueResult::CalcValueResult()
{
	
}

CalcValueResult::CalcValueResult(std::string resultSide,
								 std::string currency)
{
	this->resultSide_ = resultSide;
	this->currency_ = currency;

	this->dirty_ = 0.0;
	this->option_ = 0.0;
	this->cummulCount_ = 0;
	this->accrualAmt_= 0.0;
	this->simulNum_ = 1.0;
	
}

//void CalcValueResult::initialize(Size seq,
//								Date eventDate,
//								std::string type,
//								std::string currency,
//								Real simulNum)
//{
//
//	this->cashFlow_ = 0.0;
//	this->yield_ = 0.0;
//	this->discount_ = 0.0;
//	this->exProb_ = 0.0;
//	this->value_ = 0.0;
//	this->notionalPayment_ = 0.0;
//
//	this->cummulCount_ = 0;
//	this->simulNum_ = simulNum;
//}

void CalcValueResult::initialize(const boost::shared_ptr<CalcValueResult>& calcValue_result,Real simulNum)
{
	this->resultSide_ = calcValue_result->resultSide_;
	this->currency_ = calcValue_result->currency_;

	this->dirty_ = 0.0;
	this->option_ = 0.0;
	this->accrualAmt_ = calcValue_result->accrualAmt();

	this->simulNum_ = simulNum;
}

void CalcValueResult::initialize(Real simulNum)
{
	this->simulNum_ = simulNum;
}

void CalcValueResult::cumulate(const boost::shared_ptr<CalcValueResult>& calcValue_result)
{
	this->dirty_ += calcValue_result->dirty_;
	this->option_ += calcValue_result->option_;
	this->cummulCount_ += 1;
}

Real CalcValueResult::dirty() const
{
	return this->dirty_ / this->simulNum_;
}

Real CalcValueResult::clean() const
{
	return this->dirty_ / this->simulNum_ - this->accrualAmt_ ;
}

Real CalcValueResult::accrualAmt() const
{
	return this->accrualAmt_ ;
}

Real CalcValueResult::option() const
{
	return this->option_ / this->simulNum_;;
}

//void CalcValueResult::reset()
//{
//
//	//this->value_ = 0.0;
//}

}
