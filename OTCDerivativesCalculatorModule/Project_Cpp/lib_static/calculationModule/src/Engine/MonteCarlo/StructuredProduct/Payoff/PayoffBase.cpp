#include "payoffBase.hpp"
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolmanager/pathinformation.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/symbolmanager/indexsymbolmanager.hpp>
#include <ql/settings.hpp>

namespace QuantLib {

// �̳��� thisVariable�� factory���� �������. �ֳĸ� ������ �ű������ϱ�.. 
// ������ ���길�� �����ϸ�, ��κ� eit���� ���Ǽ� �;���.
// thisVariableValue_ �� �����ϴ� ��, eventcheck���� event�� ��ġ�� ���� payoff�� ������
// ������ event �˻��� payoff�� �׳� ���ϻ� �ٸ����� ������ ����, �ֳ��ϸ�,
// ������ ������ ���� �˻���� �ƴϰ� �ܼ� ��ȯ�ؼ� ���� ���̹Ƿ�, �ٽ� ����ؼ� ��.
// �ΰ��� �򰥷��� �ϳ��� ��. ����� thisvariablevalue�� eventcheck���� ����Ұ���

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