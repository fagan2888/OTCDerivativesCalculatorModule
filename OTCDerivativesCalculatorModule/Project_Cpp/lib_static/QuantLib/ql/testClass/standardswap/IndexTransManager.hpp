#ifndef quantlib_indextransmanager_hpp
#define quantlib_indextransmanager_hpp

#include <ql/timegrid.hpp>
#include <ql/time/date.hpp>
#include <ql/time/daycounter.hpp>
#include <ql/time/calendar.hpp>
#include <ql/settings.hpp>
#include <ql/methods/montecarlo/multipath.hpp>
#include <ql/testClass/standardswap/indexsymbolmanager.hpp>
#include <ql/testClass/muparser/muparser.h>

namespace QuantLib {
	
	class IndexTransManager {
		public:
		IndexTransManager();

		//만약 evenDate 가 여러개 들어오고 , averageDates 가 과거 일자 형식이 아니고 fix되서 박아야하면
		//에러를 뱉어야함.. 이론적으로 커버 불가... 
		//그러므로 eventcheck에서는 일괄적으로 과거 며칠 지났는지를 이용하여 계산하며, fix된경우도 상대 위치를 여기서 계산해서 사용함.
		IndexTransManager(const std::string& symbolName,
						 const std::vector<std::string> addedSymbols,
						 const std::string& eqExpression,
						 //evenDate에 종속되 거나 payoffDate 이거나임. 그니까 검사해야하는 일자가 하나 거나 여러개거나.
						 bool AbsRelFlag, //Date를 어떻게 받을건지
						 const Date& pastOservationDate, // 과거관찰일.. 과거 아니면 그냥 현재 넣으면 됨.//timeGrid 세팅을 위해 필요함. 걍 로케이션을 받아도 대는데 나중에 혹시 사용할지 몰라서 걍 timegrid받아서 새로 계산함. 어차피 계산 시간 오래 안걸리니까..
						 bool averageFlag,
						 std::vector<Date> averDates);
	
		std::string getSymbol();
		void initialize(const TimeGrid& timeGrid, const Calendar& calendar); //daycounter 는 전일자 가격 가져오는 뭐 그런데 쓰임.

		std::vector<Size> averRelativeDatesPosition() const;

		//void defineVar(const std::string varStr,double* value);
		void defineVar(const std::string varStr);
		void defineConst(const std::string varStr,Real constValue);
		void defineBaseIndex(const std::string varStr);
		void calValue(const MultiPath& multiPath, int refDatePosition);

		//custom function
		//double pastUnder(int underNum , int pastDays);
		std::vector<Date> averDates() const;
		bool average() const;

	private:
		
		mu::Parser parser_;
		std::string symbolName_;
		std::string eqExpression_;
		double* symbolValuesPtr_; // indexSymbolManger에 reference용임.
		//std::vector<double*> symbolValues_;

		//Date payoffDates_;
		Date pastOservationDate_;
		int pastPosition_;
		int baseIndexNum_; //계산해서 set 하는 코드 필요.

		const std::vector<std::string> addedSymbols_;
		std::vector<Date> averDates_;
		int payoffDatesPosition_;
		std::vector<Size> averRelativeDatesPosition_;
		const MultiPath* multiPath_;
		bool averageFlag_;
		int averDatesNum_;

		bool reCalculatePast_;
		bool AbsRelFlag_;
		bool indexPastFlag_;

		// 과거 일자 가져오는 함수 추가해야함.

		//member function for specific type math_function ( Ex. date calculation )

	//double average()
	};

}
#endif