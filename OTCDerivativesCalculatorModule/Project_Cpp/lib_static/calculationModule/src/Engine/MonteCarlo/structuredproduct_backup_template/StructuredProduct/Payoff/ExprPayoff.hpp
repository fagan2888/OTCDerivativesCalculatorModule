#ifndef calculationModule_exprPayoff_hpp
#define calculationModule_exprPayoff_hpp

#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/IndexTran/indextransBase.hpp>

namespace QuantLib {

	class ExprPayoff {
	  public:
		ExprPayoff(){}
	    ExprPayoff(const std::string& symbolName,
					const Date& payoffDate,
					std::string payoffExpr,
					//const std::vector<std::string>& baseIndex , //기본 index와 Event에서 만든 count symbol 까지 같이 포함. 2012-11-20 나중에 add하는걸로 바꿈.
					const std::vector<std::pair<std::string,boost::shared_ptr<IndexTransBase>>>& itms
										= std::vector<std::pair<std::string,boost::shared_ptr<IndexTransBase>>>());

		virtual void initialize(const TimeGrid& timeGrid, const Calendar& calendar);

		//void AddSymbol(std::string symbolName,const IndexTransManager& its);
		virtual void defineVar(const std::string& varStr);

		virtual void removeSymbol(std::string symbolName);
		
		virtual Date payoffDate(){return payoffDate_;}
		virtual Size payoffDatesPosition(){return payoffDatesPosition_;}
		
		virtual void defineConst(const std::string& varStr,Real constValue);
		virtual void defineBaseIndex(const std::string& varStr);

		virtual Real value();

	  protected:

		  mu::Parser parser_;
		  Size symbolNum_;
		  Size itmsNum_;
		  std::string symbolName_;
		  Date payoffDate_;
		  Size payoffDatesPosition_;
		  std::vector<Size> observationDatesPosition_;

		  std::vector<Size> pastDaysIndex_;
		  std::vector<Date> observationDates_;

		  std::string payoffExpr_;

		  //parser를 위한 배열..
		  std::vector<double*> baseIndexValue_; 
		  std::vector<double*> addedSymbolValue_;

		  std::vector<std::string> baseIndex_;
		  std::vector<std::pair<std::string,boost::shared_ptr<IndexTransBase>>> itms_;

	};

}
#endif
