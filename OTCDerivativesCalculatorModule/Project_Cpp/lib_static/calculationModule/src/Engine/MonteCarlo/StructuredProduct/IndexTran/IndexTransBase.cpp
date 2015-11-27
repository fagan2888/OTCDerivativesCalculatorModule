#include "IndexTransBase.hpp"
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/SymbolManager/indexsymbolmanager.hpp>

namespace QuantLib {

IndexTransBase::IndexTransBase(const std::string& symbolName)
				: symbolName_(symbolName)
{
	QL_REQUIRE(symbolName.size() > 0,"symbolName must have some string");
}


//class ���� Ȯ�� �ɶ� ���� �Ϸ� �Ǿ����. ���߿� ���� ��¥�� �ɺ� ���� ���谡 �ٲ� �� �����ϱ�.. �̸� indexsymbolmanger�� lastfixingDate ptr�� ��� ���� �ִٰ�
// ���߿� bind �Լ� �θ� �� lastfixingDate ����ϰ� validation �˻��ϰ� binding ��.

//void IndexTransBase::setIndexPtrForHistoryValue(const std::vector<boost::shared_ptr<IndexTransBase>>& preTransBases)
//{
//	this->preTransBases_ = preTransBases;
//}

}