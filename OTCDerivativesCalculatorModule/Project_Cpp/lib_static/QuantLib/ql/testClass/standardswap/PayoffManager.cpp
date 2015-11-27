#include <ql/testClass/standardswap/payoffmanager.hpp>
#include <ql/settings.hpp>

namespace QuantLib {

PayoffManager::PayoffManager(const Date& payoffDate,
							 //std::vector<Date> observationDates, // <- �ʿ䰡 �ֳ�..? �� IndexTran���� ����?
							 std::string payoffExpr,
							 //const std::vector<std::string>& baseIndex, //�⺻ index , Event���� ���� count symbol �� defVar �Լ��� �̿���.
							 const std::vector<std::pair<std::string,boost::shared_ptr<IndexTransManager>>>& itms
							 )
		: payoffDate_(payoffDate), payoffExpr_(payoffExpr), itms_(itms), 
		  parser_(mu::Parser())
{
	
	//int averageCount = 0; //average�� indexTrans�� �ι������°� ����

	for(Size i=0;i<itms_.size();++i){
		addedSymbolValue_.push_back( IndexSymbolManager::instance().setSymbol(itms_[i].first)); 
		parser_.DefineVar(itms_[i].first, addedSymbolValue_[i]);
	//	if(itms_[i].second->average()){
	//	observationDates_ = itms_[i].second->averDates();
	//		averageCount = averageCount +1;
	//	}
//		if(averageCount > 1){
			//Error return;	
//		}
	}
	
	parser_.SetExpr(payoffExpr);
}

void PayoffManager::initialize(const TimeGrid& timeGrid, const Calendar& calendar){
			
		Date today = Settings::instance().evaluationDate();
		Date issueDate = Date(27,Sep,2012);
		/*std::cout << issueDate.serialNumber() << std::endl;
		std::cout << payoffDate_.serialNumber() << std::endl;
		std::cout << payoffDate_.serialNumber() - issueDate.serialNumber() << std::endl;*/

		payoffDatesPosition_ = calendar.businessDaysBetween(issueDate,payoffDate_,true,false);
		//std::cout << payoffDatesPosition_;
}
void PayoffManager::defineConst(const std::string& varStr,Real constValue){
	parser_.DefineConst(varStr,constValue);
	
	for(Size i=0 ;i<itms_.size(); ++i){
		itms_[i].second->defineConst(varStr,constValue);
	}
}
// �̹� eventCheck���� ���� ���ǰ� �ǰ�, ���⿣ parser�� �׳� �ּҵ�ϸ� ��.
// Count Symbol �̷��� Add����..
//void PayoffManager::AddSymbol(std::string symbolName,const IndexTransManager& its){			
void PayoffManager::defineVar(const std::string& varStr){			

	parser_.DefineVar(varStr, IndexSymbolManager::instance().setSymbol(varStr));
	for(Size i=0 ;i<itms_.size(); ++i){
		itms_[i].second->defineVar(varStr);
	}
}

void PayoffManager::defineBaseIndex(const std::string& varStr){			
	
	parser_.DefineVar(varStr, IndexSymbolManager::instance().setSymbol(varStr));
	baseIndexValue_.push_back(IndexSymbolManager::instance().setSymbol(varStr));
	
	for(Size i=0 ;i<itms_.size(); ++i){
		itms_[i].second->defineVar(varStr);
	}
}

void PayoffManager::removeSymbol(std::string symbolName){
	
}

Real PayoffManager::value(const MultiPath& multiPath){

	this->setBaseIndexValue(multiPath); //payoffDate setting
	
	for(Size i=0;i<addedSymbolValue_.size();++i){
		//if(itms_[i].second->average()){
			//for(Size z=0; z<observationDates_.size() ; ++z ){ //�׳� pastIndex�� �Ųٷ� ������ ����..
//		setBaseIndexValue(multiPath,payoffDatesPosition_); 
		itms_[i].second->calValue(multiPath,payoffDatesPosition_);		
	}

	return parser_.Eval();

}

//eventcheck ���� �����ؿ�.
void PayoffManager::setBaseIndexValue(const MultiPath& multiPath){
	for(Size i=0;i<baseIndexValue_.size();++i){
		*baseIndexValue_[i]=multiPath[i][payoffDatesPosition_];
	}
}




}