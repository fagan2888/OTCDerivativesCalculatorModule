#include "FdmContingentPayoff.hpp"

namespace QuantLib {

FdmContingentPayoff::FdmContingentPayoff(const Date& payoffDate,
										const std::vector<FdmPayoffFunction>& payoffFunction, // ���⿡ constant�� �ְ� �˴� �����.
										const std::vector<boost::shared_ptr<Domain>>& domains, // ���� fdmPayoffFunction �� ������Ű������ ����ٰ� �������� ����.
										Size fixingDays,
										const ContingentEvent& eventInfo,
										const FdmContingentStepConditionComposite& conditions);
: payoffDate_(payoffDate), payoffFunction_(payoffFunction), domains_(domains),fixingDays_(fixingDays),
  eventInfo_(eventInfo), conditions_(conditions)										
{
	
}

void FdmContingentPayoff::build(const boost::shared_ptr<FdmMesher>& mesher)
{
	// �ڱⲨ �켱 build �ϰ�
	mesher_ = mesher;

	// FdmContingentStepConditionComposite ���� �ϰ�
	conditions.build(mesher);

	conditions.stoppingTimes();

}

std::vector<Time> stoppingTimes()
{
	return stoppingTimes_;
}

void FdmContingentPayoff::payoffRhs(Array& rhs)
{
	//x_.reserve(mesher->layout()->dim()[0]);
 //   y_.reserve(mesher->layout()->dim()[1]);
	rhs.resize(mesher_->layout()->size());

    const boost::shared_ptr<FdmLinearOpLayout> layout = mesher_->layout();
    const FdmLinearOpIterator endIter = layout->end();
    for (FdmLinearOpIterator iter = layout->begin(); iter != endIter ; ++iter) 
	{
        values[iter.index()] = calculator->avgInnerValue(iter);

        //if (!iter.coordinates()[1]) {
        //    x_.push_back(mesher->location(iter, 0));
        //}
        //if (!iter.coordinates()[0]) {
        //    y_.push_back(mesher->location(iter, 1));
        //}
    }

	return values;
}


}