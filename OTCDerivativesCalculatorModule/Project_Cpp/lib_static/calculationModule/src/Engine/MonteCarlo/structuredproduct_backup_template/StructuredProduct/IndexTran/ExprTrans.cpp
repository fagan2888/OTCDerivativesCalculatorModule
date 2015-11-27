//#include <src/Engine/MonteCarlo/StructuredProduct/IndexTran/IndexTransBase.hpp>
//
//namespace QuantLib {
//
//IndexTransBase::IndexTransBase()
//				: symbolName_("defualtSymbolName"), eqExpression_("defaultEqExpression") {}
//
//IndexTransBase::IndexTransBase(const std::string& symbolName,
//											 const std::string& eqExpression)
//				: symbolName_(symbolName), symbolValuesPtr_(IndexSymbolManager::instance().setSymbol(symbolName))
//{
//
//	parser_.DefineVar(symbolName,symbolValuesPtr_);
//	for(Size i=0;i<addedSymbols.size();++i){
//		this->defineVar(addedSymbols_[i]);
//	}
//	parser_.SetExpr(eqExpression_);
//	pastPosition_ = 0;
//
//}
//
//void IndexTransBase::initialize(const TimeGrid& timeGrid, const Calendar& calendar){
//	
//	Date today = Settings::instance().evaluationDate();
//	
//	//�������̶� �� ���������ϱ�.. �̰� ���ø����� �ٲ㼭 
//	//xml ���Ϸ� �����Ҷ� �Ƚ� ��ų����.
//	//������ �ִ� event�� daily check�� ��� ����. 2012-12-11
//	//pastPosition_ = calendar.businessDaysBetween(today,pastOservationDate_,true,false);
//
//	
//}
//
//std::vector<Size> IndexTransBase::averRelativeDatesPosition() const {
//	return averRelativeDatesPosition_;
//}
//
////void IndexTransManager::defineVar(const std::string varStr,double* value){
//void IndexTransBase::defineVar(const std::string varStr){
//	parser_.DefineVar(varStr,IndexSymbolManager::instance().setSymbol(varStr));
//}
//void IndexTransBase::defineConst(const std::string varStr,Real constValue){
//	parser_.DefineConst(varStr,constValue);
//}
//void IndexTransBase::defineBaseIndex(const std::string varStr){
//	parser_.DefineVar(varStr,IndexSymbolManager::instance().setSymbol(varStr));
//}
//
//// ���߿� �̰Ŷ��� template�� �����ϴ� ��Ȳ�� ���� ���� 2012-11-28 (��ն���)
////template<class IndexCalType>
//void IndexTransBase::calValue(const MultiPath& multiPath,int refDatePosition){
//
//	indexPastFlag_=true;
//
//	//base�� ������ �����Ǿ �ð���.(eventcheck����?)
//	//payoffDates_ = payoffDates_ - pastDays; 
//	//indexCalType_.calValue();
//
//	if(indexPastFlag_){
//		//multiPath_=&multiPath;
//		*symbolValuesPtr_ = parser_.Eval();
//	}else{
//		*symbolValuesPtr_ = multiPath[baseIndexNum_][refDatePosition - pastPosition_];
//	}
//}
//
////double IndexTransManager::pastUnder(int baseIndexNum , int pastDays){
////
////	//form ���� �����ؼ� ���°���� �ѱ����
////	return (*multiPath_)[baseIndexNum][payoffDatesPosition_ - pastDays];
////
////}
//std::vector<Date> IndexTransBase::averDates() const {
//	return averDates_;
//}
//
//bool IndexTransBase::average() const{
//	return averageFlag_;
//
//}
//
//std::string IndexTransBase::getSymbol(){
//	return symbolName_;
//}
//
//
//
//}