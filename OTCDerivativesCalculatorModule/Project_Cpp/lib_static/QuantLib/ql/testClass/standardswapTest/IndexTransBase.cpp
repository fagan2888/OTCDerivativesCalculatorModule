#include <ql/testClass/standardswapTest/indextransmanager.hpp>

namespace QuantLib {

IndexTransManagerBase::IndexTransManagerBase()
				: symbolName_("defualtSymbolName"), eqExpression_("defaultEqExpression") {}

IndexTransManagerBase::IndexTransManagerBase(const std::string& symbolName,
									 const std::vector<std::string> addedSymbols,
									 const std::string& eqExpression,
									 bool AbsRelFlag, //Date�� ��� ��������(abs����ref����)
									 const Date& pastOservationDate,
									 bool averageFlag,
									 std::vector<Date> averDates)
				: symbolName_(symbolName), addedSymbols_(addedSymbols), eqExpression_(eqExpression), AbsRelFlag_(AbsRelFlag),
				  pastOservationDate_(pastOservationDate),averageFlag_(averageFlag), averDates_(averDates),
				  symbolValuesPtr_(IndexSymbolManager::instance().setSymbol(symbolName))
{
	// ����� ��¥ �޾ƾ��� eventCalss�� ����.
	//baseIndex �� �׳� �� Ŭ������ ������ �ִ� ������ ����������.

	parser_.DefineVar(symbolName,symbolValuesPtr_);
	for(Size i=0;i<addedSymbols.size();++i){
		this->defineVar(addedSymbols_[i]);
	}
	parser_.SetExpr(eqExpression_);
	pastPosition_ = 0;

}

void IndexTransManagerBase::initialize(const TimeGrid& timeGrid, const Calendar& calendar){
	
	Date today = Settings::instance().evaluationDate();
	
	//�������̶� �� ���������ϱ�.. �̰� ���ø����� �ٲ㼭 
	//xml ���Ϸ� �����Ҷ� �Ƚ� ��ų����.
	//������ �ִ� event�� daily check�� ��� ����. 2012-12-11
	//pastPosition_ = calendar.businessDaysBetween(today,pastOservationDate_,true,false);

	
}

std::vector<Size> IndexTransManagerBase::averRelativeDatesPosition() const {
	return averRelativeDatesPosition_;
}

//void IndexTransManager::defineVar(const std::string varStr,double* value){
void IndexTransManagerBase::defineVar(const std::string varStr){
	parser_.DefineVar(varStr,IndexSymbolManager::instance().setSymbol(varStr));
}
void IndexTransManagerBase::defineConst(const std::string varStr,Real constValue){
	parser_.DefineConst(varStr,constValue);
}
void IndexTransManagerBase::defineBaseIndex(const std::string varStr){
	parser_.DefineVar(varStr,IndexSymbolManager::instance().setSymbol(varStr));
}

// ���߿� �̰Ŷ��� template�� �����ϴ� ��Ȳ�� ���� ���� 2012-11-28 (��ն���)
//template<class IndexCalType>
void IndexTransManagerBase::calValue(const MultiPath& multiPath,int refDatePosition){

	indexPastFlag_=true;

	//base�� ������ �����Ǿ �ð���.(eventcheck����?)
	//payoffDates_ = payoffDates_ - pastDays; 
	//indexCalType_.calValue();

	if(indexPastFlag_){
		//multiPath_=&multiPath;
		*symbolValuesPtr_ = parser_.Eval();
	}else{
		*symbolValuesPtr_ = multiPath[baseIndexNum_][refDatePosition - pastPosition_];
	}
}

//double IndexTransManager::pastUnder(int baseIndexNum , int pastDays){
//
//	//form ���� �����ؼ� ���°���� �ѱ����
//	return (*multiPath_)[baseIndexNum][payoffDatesPosition_ - pastDays];
//
//}
std::vector<Date> IndexTransManagerBase::averDates() const {
	return averDates_;
}
bool IndexTransManagerBase::average() const{
	return averageFlag_;

}

std::string IndexTransManagerBase::getSymbol(){
	return symbolName_;
}



}