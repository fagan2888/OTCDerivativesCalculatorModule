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
	
				//기준일이랑 얼마 지났는지니까.. 이건 템플릿으로 바꿔서 
				//xml 파일로 세팅할때 픽스 시킬거임.
				//가지고 있는 event가 daily check일 경우 생각. 2012-12-11
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