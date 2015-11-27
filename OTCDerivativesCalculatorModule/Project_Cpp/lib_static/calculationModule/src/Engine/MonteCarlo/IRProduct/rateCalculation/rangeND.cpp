#include "rangeND.hpp"

namespace QuantLib {

RangeND::RangeND(std::string jointType,
					const std::vector<boost::shared_ptr<QuantLib::Range1D>>& range1DList,
					const std::vector<boost::shared_ptr<ReferenceCalculation>>& refCalcList)
: jointType_(jointType), range1DList_(range1DList), refCalcList_(refCalcList)
{
	if ( jointType == "or")
	{
		this->checkTF_ = false;
	}
	else // and
	{
		this->checkTF_ = true;
	}

	if ( range1DList.size() != refCalcList.size())
	{
		QL_FAIL("rngNum must be same to refNum");
	}
}

void RangeND::initialize(const TimeGrid& timeGrid,
				const boost::shared_ptr<YieldTermStructure>& discountCurve,
				const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory)
{
	for ( Size i=0 ; i<this->refCalcList_.size() ; i++)
	{
		this->refCalcList_[i]->initialize(timeGrid,discountCurve,pathGenFactory);
	}

	this->rangeNum_ = range1DList_.size();

}

bool RangeND::eventOcc(std::vector<Real> value) const
{
	bool tf = false;
	

	return tf;
}

bool RangeND::eventOccSlice(const MultiPath& path,Size position) const
{
	if ( this->checkTF_ ) // and
	{
		bool tf = true;

		for ( Size i=0 ;i<this->rangeNum_; i++ )
		{
			tf = tf & this->range1DList_[i]->eventOcc(
				this->refCalcList_[i]->calSlice(path,position));
		}

		return tf;

	}else
	{
		bool tf = false;

		for ( Size i=0 ;i<this->rangeNum_; i++ )
		{
			tf = tf | this->range1DList_[i]->eventOcc(
				this->refCalcList_[i]->calSlice(path,position));
		}

		return tf;
	}

}

}

