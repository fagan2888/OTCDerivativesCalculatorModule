#ifndef quantlibTest_indextransmanager_hpp
#define quantlibTest_indextransmanager_hpp

#include <ql/timegrid.hpp>
#include <ql/time/date.hpp>
#include <ql/time/daycounter.hpp>
#include <ql/time/calendar.hpp>
#include <ql/settings.hpp>
#include <ql/methods/montecarlo/multipath.hpp>
#include <ql/testClass/standardswapTest/indexsymbolmanager.hpp>
#include <ql/testClass/muparser/muparser.h>

namespace QuantLib {
	
	class IndexTransBase {
		public:
		IndexTransBase();

		IndexTransBase(const std::string& symbolName,
						 const std::string& eqExpression
						 );
	
		std::string getSymbol();
		void initialize(const TimeGrid& timeGrid, const Calendar& calendar); //daycounter �� ������ ���� �������� �� �׷��� ����.

		//void defineVar(const std::string varStr,double* value);
		virtual void defineVar(const std::string varStr);
		virtual void defineConst(const std::string varStr,Real constValue);
		virtual void defineBaseIndex(const std::string varStr);

		virtual void calValue(const MultiPath& multiPath){}
		virtual void calValue(const MultiPath& multiPath,int refDatePosition){}

		//custom function
		//double pastUnder(int underNum , int pastDays);
		std::vector<Date> averDates() const;
		bool average() const;

	protected:
		
		mu::Parser parser_;
		std::string symbolName_;
		std::string eqExpression_;
		double* symbolValuesPtr_; // indexSymbolManger�� reference����.
		//std::vector<double*> symbolValues_;

		//Date payoffDates_;
		Date pastOservationDate_;
		int position_;
		int pastPosition_;
		int baseIndexNum_; //����ؼ� set �ϴ� �ڵ� �ʿ�.

		const std::vector<std::string> addedSymbols_;
		int payoffDatesPosition_;
		const MultiPath* multiPath_;

		// ���� ���� �������� �Լ� �߰��ؾ���.

		//member function for specific type math_function ( Ex. date calculation )

	//double average()
	};

}
#endif