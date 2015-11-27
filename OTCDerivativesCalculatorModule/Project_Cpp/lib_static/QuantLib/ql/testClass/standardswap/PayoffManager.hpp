#ifndef quantlib_payoffmanager_hpp
#define quantlib_payoffmanager_hpp

#include <ql/testClass/standardswap/indextransmanager.hpp>

namespace QuantLib {

	class PayoffManager {
	  public:
		  PayoffManager(){}
		PayoffManager(const Date& payoffDate,
					//평균취할거면 indesTran에서 평균취한걸 만들어서 들어오는데 그 observationDates임..
					//걍 안에서 세팅함. std::vector<Date> observationDates, // 이거 averager Date임..ㅡㅠ;
					std::string payoffExpr,
					//const std::vector<std::string>& baseIndex , //기본 index와 Event에서 만든 count symbol 까지 같이 포함. 2012-11-20 나중에 add하는걸로 바꿈.
					const std::vector<std::pair<std::string,boost::shared_ptr<IndexTransManager>>>& itms 
										= std::vector<std::pair<std::string,boost::shared_ptr<IndexTransManager>>>());

		virtual void initialize(const TimeGrid& timeGrid, const Calendar& calendar);

		//void AddSymbol(std::string symbolName,const IndexTransManager& its);
		virtual void defineVar(const std::string& varStr);

		virtual void removeSymbol(std::string symbolName);
		virtual Real value(const MultiPath& multiPath);
		virtual void setBaseIndexValue(const MultiPath& multiPath);
		virtual Date payoffDate(){return payoffDate_;}
		virtual Size payoffDatesPosition(){return payoffDatesPosition_;}
		
		virtual void defineConst(const std::string& varStr,Real constValue);
		virtual void defineBaseIndex(const std::string& varStr);

	  protected:
		  Size symbolNum_;
		  Date payoffDate_;
		  Size payoffDatesPosition_;
		  std::vector<Size> observationDatesPosition_;

		  std::vector<Size> pastDaysIndex_;
		  std::vector<Date> observationDates_;


		  std::string payoffExpr_;

		  //parser를 위한 배열..
		  std::vector<double*> baseIndexValue_; 
		  std::vector<double*> addedSymbolValue_;

		  //std::vector<boost::shared_ptr<Real> > isvs_; 이거도.. 어디다.. 쓰는거였더라.. ㅡ.ㅡ; 2012-11-23

		  mu::Parser parser_;

		  std::vector<std::string> baseIndex_;
//		  std::vector<std::string> totalSymbolNames_; //indexSymbolNames_를 기본으로 가짐
		  //std::vector<IndexTransManager> itm_; 어디다 쓰는 거였더라.. ㅡ.ㅡ; 2012-11-23

		  std::vector<std::pair<std::string,boost::shared_ptr<IndexTransManager>>> itms_;

	};

}
#endif
