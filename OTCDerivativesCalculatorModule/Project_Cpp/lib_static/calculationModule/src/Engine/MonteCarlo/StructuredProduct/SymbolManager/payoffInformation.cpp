#include "payoffInformation.hpp"
#include <boost/algorithm/string/case_conv.hpp>
#include <ql/settings.hpp>

using boost::algorithm::to_upper_copy;

namespace QuantLib {

//�̹� calendar ������ ��ġ�� �� ���� date�� ����ؾ���.
// ordering�� �� ���� �;���.
void PayoffInformation::initialize()
{
	Date today = Settings::instance().evaluationDate();

	payoffDateNum_ = payoffDates_.size();

	this->payoff_ = std::valarray<Real>(0.0,payoffDateNum_);

	for(Size i = 0 ; i < payoffDateNum_ ; ++i)
	{
		data_[payoffDates_[i]] = i;

		if( payoffDates_[i] <= today )
			pastPosition_ = i;
			
	}

	initializeFlag_ = true;

}

//indexFixingDate �� eventDate �� �������� ���� (���Ŵ� ���⼭ ��� ����)
bool PayoffInformation::hasDate(const Date& date) const
{
	return data_.find(date) != data_.end();
}

Real* PayoffInformation::getPositionPtr(const Date& date) const 
{
	
	if(this->checkInitialize())
	{
		if(hasDate(date))
		{
			return &payoff_[data_[date]];
		}
		else
		{
			QL_FAIL("payoff doesn't have date. date : " << date );
		}

	}else
	{
		QL_FAIL("path not initialized");
	}
	/*Date today = Settings::instance().evaluationDate();*/
}

void PayoffInformation::addPayoffDate(const Date& date)
{
	bool addedFlag = false;

	Date today = Settings::instance().evaluationDate();

	for (std::vector<Date>::iterator iter = payoffDates_.begin() ; iter != payoffDates_.end(); ++iter)
	{
		if(date == (*iter) ){
			addedFlag = true;
			break;
		}
		else if(date < (*iter) )
		{
			addedFlag = true;
			payoffDates_.insert(iter,date);

			if(today <= date )
				for (std::vector<Date>::iterator iter = remainPayoffDates_.begin() ; iter != remainPayoffDates_.end(); ++iter){
					if(date < (*iter) )
					{
						remainPayoffDates_.insert(iter,date);
						addedFlag = true;
						break;
					}
				}
			break;
		}else
		{
			//nothing next iter
		}

	}

	if(!addedFlag){
		payoffDates_.push_back(date);
		if(today < date )
			remainPayoffDates_.push_back(date);
	}
}
void PayoffInformation::removePayoffDate(const Date& date)
{
	data_.erase(date);
}

void PayoffInformation::clearPayoffDate()
{
	data_.clear();
}

void PayoffInformation::zeroPayoff(const Date& date)
{
	Date today = Settings::instance().evaluationDate();

	QL_REQUIRE( today < date  , "pastFixing payoff can't adjust in this zero payoff method. date : " << date );	

	if(hasDate(date))
	{
		payoff_[data_[date]] = 0.0;
	}
	else
	{
		QL_FAIL("payoff doesn't have date. date : " << date );
	}
}

void PayoffInformation::zeroPayoff()
{
	for(Size i = pastPosition_ + 1 ; i < payoffDateNum_ ; ++i)
		payoff_[i] = 0.0 ;
}

bool PayoffInformation::checkInitialize() const
{
	if( this->initializeFlag_ )
	{ return true; }
	else
	{ return false;	}

}

}



