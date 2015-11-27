#ifndef calculationModule_exprtrans_hpp
#define calculationModule_exprtrans_hpp

//#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/IndexTran/IndexTransManagerBase.hpp>
#include <ql/time/date.hpp>
#include <string>

namespace QuantLib {

	class ExprTrans : public IndexTransBase {
	
		public:
			ExprTrans(const std::string& symbolName,
					  const std::string& eqExpression,
					  const Date& date) 
					  : IndexTransBase(symbolName)
			{
			}

			//ExprTrans(const std::string& symbolName,
			//		  const std::string& eqExpression,
			//		  std::vector<Date> dates,
			//		  bool )
			//{
			//	parser_.DefineVar(symbolName,symbolValuesPtr_);
			//	parser_.SetExpr(eqExpression_);
			//}

			void initialize(const TimeGrid& timeGrid, const Calendar& calendar){
	
				Date today = Settings::instance().evaluationDate();
	
				//�������̶� �� ���������ϱ�.. �̰� ���ø����� �ٲ㼭 
				//xml ���Ϸ� �����Ҷ� �Ƚ� ��ų����.
				//������ �ִ� event�� daily check�� ��� ����. 2012-12-11
				//pastPosition_ = calendar.businessDaysBetween(today,pastOservationDate_,true,false);
	
			}
			void defineVar(const std::string varStr)
			{
					//parser_.DefineVar(varStr,IndexSymbolManager::instance().setSymbol(varStr));
			}
			void defineConst(const std::string varStr,Real constValue)
			{
					//parser_.DefineConst(varStr,constValue);
			}
			void defineBaseIndex(const std::string varStr)
			{
					//parser_.DefineVar(varStr,IndexSymbolManager::instance().setSymbol(varStr));
			}

			void calValue(const MultiPath& multiPath);
			void calValue(const MultiPath& multiPath,int refDatePosition)
			{
				//*symbolValuesPtr_ = parser_.Eval();
			}

		private:
	};
}

#endif