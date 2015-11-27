#include "CashFlowResult.hpp"

namespace QuantLib 
{

CashFlowResult::CashFlowResult()
{
	this->isExpired_ = false;
}

CashFlowResult::CashFlowResult(Size seq,
								Date eventDate,
								Date payoffDate,
								std::string type,
								std::string currency,
								Real discount)
{
	this->seq_ = seq;

	this->eventDate_ = eventDate;
	this->payoffDate_ = payoffDate;
	this->type_ = type;
	this->currency_ = currency;

	this->cashFlow_ = 0.0;
	this->yield_ = 0.0;
	//this->discount_ = 0.0;
	this->exProb_ = 0.0;
	this->value_ = 0.0;
	this->notionalPayment_ = 0.0;
	this->discount_ = discount;
	this->initial_discount_ = discount;
	this->cummulCount_ = 0;
	
	this->simulNum_ = 1.0;
	this->isExpired_ = false;
}

//void CashFlowResult::initialize(Size seq,
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

void CashFlowResult::initialize(const boost::shared_ptr<CashFlowResult>& cf_result,
								Real simulNum)
{
	this->seq_ = cf_result->seq_;
	this->eventDate_ = cf_result->eventDate_;
	this->payoffDate_ = cf_result->payoffDate_;
	this->type_ = cf_result->type_;
	this->currency_ = cf_result->currency_;

	this->cashFlow_ = 0.0;
	this->yield_ = 0.0;
	this->discount_ = cf_result->initial_discount_;
	this->exProb_ = 0.0;
	this->value_ = 0.0;
	this->notionalPayment_ = 0.0;

	this->cummulCount_ = 0;
	this->initial_discount_ = cf_result->initial_discount_;
	this->simulNum_ = simulNum;
}

void CashFlowResult::cumulate(const boost::shared_ptr<CashFlowResult>& cf_result)
{
	this->cashFlow_ += cf_result->cashFlow_;
	//this->yield_ += cf_result->cashFlow_;
	//this->discount_ += cf_result->discount_;
	this->exProb_ += cf_result->exProb_;
	this->value_ += cf_result->value_;
	this->notionalPayment_ += cf_result->notionalPayment_;

	this->cummulCount_ += 1;
}

void CashFlowResult::reset()
{

	this->cashFlow_ = 0.0;
	this->yield_ = 0.0;
	//this->discount_ = this->initial_discount_;
	this->exProb_ = 0.0;
	this->value_ = 0.0;
	this->notionalPayment_ = 0.0;
}

}
