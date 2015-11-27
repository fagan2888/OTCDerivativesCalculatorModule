#ifndef quantlib_payoffmanager_hpp
#define quantlib_payoffmanager_hpp

#include <ql/testClass/standardswap/indextransmanager.hpp>

namespace QuantLib {

	class PayoffManager {
	  public:
		  PayoffManager(){}
		PayoffManager(const Date& payoffDate,
					//������ҰŸ� indesTran���� ������Ѱ� ���� �����µ� �� observationDates��..
					//�� �ȿ��� ������. std::vector<Date> observationDates, // �̰� averager Date��..�Ѥ�;
					std::string payoffExpr,
					//const std::vector<std::string>& baseIndex , //�⺻ index�� Event���� ���� count symbol ���� ���� ����. 2012-11-20 ���߿� add�ϴ°ɷ� �ٲ�.
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

		  //parser�� ���� �迭..
		  std::vector<double*> baseIndexValue_; 
		  std::vector<double*> addedSymbolValue_;

		  //std::vector<boost::shared_ptr<Real> > isvs_; �̰ŵ�.. ����.. ���°ſ�����.. ��.��; 2012-11-23

		  mu::Parser parser_;

		  std::vector<std::string> baseIndex_;
//		  std::vector<std::string> totalSymbolNames_; //indexSymbolNames_�� �⺻���� ����
		  //std::vector<IndexTransManager> itm_; ���� ���� �ſ�����.. ��.��; 2012-11-23

		  std::vector<std::pair<std::string,boost::shared_ptr<IndexTransManager>>> itms_;

	};

}
#endif
