#include "pathinformation.hpp"
#include <boost/algorithm/string/case_conv.hpp>
#include <ql/settings.hpp>

using boost::algorithm::to_upper_copy;

namespace QuantLib {

//calendar는 내부 사용용이 아니고 외부에 제공용임.
void PathInformation::initialize(const boost::shared_ptr<MultiPath>& multiPath, Calendar calendar)
{
	count_ = 0;
	this->calendar_ = calendar;

	QL_REQUIRE(multiPath->pathSize() > 0,"pathSize of multiPath must be positive");
	QL_REQUIRE(multiPath->assetNumber() > 0,"assetNumber of multiPath must be positive");

	this->multiPath_ = multiPath;
	//multiPathPtr_ = multiPath_.get();

	this->pathSize_ = multiPath_->pathSize();

	initializeFlag_ = true;

}

//이미 calendar 조정을 거치고 난 후의 date를 사용해야함.
//indexFixingDate 은 eventDate 를 기준으로 들어옴 (과거는 여기서 계산 안함)
void PathInformation::addIndexFixingDate(const Date& indexFixingDate)
{
	bool addedFlag = false;

	Date today = Settings::instance().evaluationDate();

	for (std::vector<Date>::iterator iter = indexFixingDates_.begin() ; iter != indexFixingDates_.end(); ++iter)
	{
		if(indexFixingDate == (*iter) ){
			addedFlag = true;
			break;
		}
		else if(indexFixingDate < (*iter) )
		{
			addedFlag = true;

			indexFixingDates_.insert(iter,indexFixingDate);

			if(today <= indexFixingDate )
				for (std::vector<Date>::iterator iter = remainIndexFixingDates_.begin() ; iter != remainIndexFixingDates_.end(); ++iter){
					if(indexFixingDate < (*iter) )
					{
						remainIndexFixingDates_.insert(iter,indexFixingDate);
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
		indexFixingDates_.push_back(indexFixingDate);
		if(today < indexFixingDate )
		{
			remainIndexFixingDates_.push_back(indexFixingDate);
		}
	}

	
	//QL_REQUIRE(indexFixingDates_.size() == multiPath_.pathSize(),"pathSize of multiPath must be same to number of indexFixingDates");

}

std::vector<Date> PathInformation::indexFixingDates()
{
	return this->indexFixingDates_;
}

void PathInformation::addIndexName(const std::string& name)
{
	bool hasIndexFlag = false;

	for(Size i = 0 ; i < indexName_.size() ; ++i){
		if(to_upper_copy(indexName_[i]) == to_upper_copy(name))
			hasIndexFlag = true;
	}
	if(!hasIndexFlag)
		this->indexName_.push_back(name);

}

Size PathInformation::getPosition(const Date& date)
{
	Size position = 99999;

	if(checkInitialize()){
		Size position = 0;
		//position = calendar_.businessDaysBetween(indexFixingDates_.front(),date,true,false);
		
		for(Size i = 0 ; i < remainIndexFixingDates_.size() ; ++i){
			if(remainIndexFixingDates_[i] == date)
				position = i;
		}

		QL_REQUIRE(position != 99999, "unknown date position");

		return position;

	}else
	{
		QL_FAIL("path not initialized");
	}
	/*Date today = Settings::instance().evaluationDate();*/
}

double* PathInformation::getPositionPtr(const std::string& name,const Date& date)
{
	if(this->checkInitialize())
	{
		Size position = 99999;
		Size indexPosition = 99999;

		//position = calendar_.businessDaysBetween(indexFixingDates_.front(),date,true,false);

		for(Size i = 0 ; i < remainIndexFixingDates_.size() ; ++i){
			if(remainIndexFixingDates_[i] == date)
				position = i;
		}

		indexPosition = this->getIndexPosition(name);

		QL_REQUIRE(position != 99999, "unknown date position");

		return &(multiPath_->operator[](indexPosition)[position]);

	}else
	{
		QL_FAIL("path not initialized");
	}
}

Size PathInformation::getIndexPosition(const std::string& name)
{
	Size pathNum = 999;

	for(Size i = 0 ; i < indexName_.size() ; ++i)
	{
		if(name == indexName_[i])
			pathNum = i;
	}

	if(pathNum==999)
		QL_FAIL("path name is not initialized : " << name);

	return pathNum;
}

//! returns whether historical fixings were stored for the index
bool PathInformation::hasPath(const std::string& name) const
{
	return data_.find(to_upper_copy(name)) != data_.end();
}

void PathInformation::clearPath()
{
	data_.clear();
	//multiPath_.reset();
	//multiPathPtr_ = 0;
	initializeFlag_ = false;
	IndexFixingDatesSetFlag_ = false;
}

bool PathInformation::checkInitialize()
{
	if( this->initializeFlag_ )
	{ return true; }
	else
	{ return false;	}

}

Calendar PathInformation::getCalendar()
{
	//QL_REQUIRE(calendar_,"calendar not initialized");
	return this->calendar_;
}

void PathInformation::setCalendar(Calendar calendar)
{
	this->calendar_ = calendar;
}

}



