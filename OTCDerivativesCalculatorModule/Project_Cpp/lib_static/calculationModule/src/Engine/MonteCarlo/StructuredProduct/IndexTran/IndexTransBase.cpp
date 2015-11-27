#include "IndexTransBase.hpp"
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/SymbolManager/indexsymbolmanager.hpp>

namespace QuantLib {

IndexTransBase::IndexTransBase(const std::string& symbolName)
				: symbolName_(symbolName)
{
	QL_REQUIRE(symbolName.size() > 0,"symbolName must have some string");
}


//class 생성 확정 될때 전부 완료 되어야함. 나중에 같은 날짜에 심볼 전후 관계가 바뀔 수 있으니까.. 미리 indexsymbolmanger에 lastfixingDate ptr만 얻어 놓고 있다가
// 나중에 bind 함수 부를 때 lastfixingDate 계산하고 validation 검사하고 binding 함.

//void IndexTransBase::setIndexPtrForHistoryValue(const std::vector<boost::shared_ptr<IndexTransBase>>& preTransBases)
//{
//	this->preTransBases_ = preTransBases;
//}

}