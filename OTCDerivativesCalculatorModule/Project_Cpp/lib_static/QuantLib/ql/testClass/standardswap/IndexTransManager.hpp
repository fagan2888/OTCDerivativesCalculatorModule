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

		//���� evenDate �� ������ ������ , averageDates �� ���� ���� ������ �ƴϰ� fix�Ǽ� �ھƾ��ϸ�
		//������ ������.. �̷������� Ŀ�� �Ұ�... 
		//�׷��Ƿ� eventcheck������ �ϰ������� ���� ��ĥ ���������� �̿��Ͽ� ����ϸ�, fix�Ȱ�쵵 ��� ��ġ�� ���⼭ ����ؼ� �����.
		IndexTransManager(const std::string& symbolName,
						 const std::vector<std::string> addedSymbols,
						 const std::string& eqExpression,
						 //evenDate�� ���ӵ� �ų� payoffDate �̰ų���. �״ϱ� �˻��ؾ��ϴ� ���ڰ� �ϳ� �ų� �������ų�.
						 bool AbsRelFlag, //Date�� ��� ��������
						 const Date& pastOservationDate, // ���Ű�����.. ���� �ƴϸ� �׳� ���� ������ ��.//timeGrid ������ ���� �ʿ���. �� �����̼��� �޾Ƶ� ��µ� ���߿� Ȥ�� ������� ���� �� timegrid�޾Ƽ� ���� �����. ������ ��� �ð� ���� �Ȱɸ��ϱ�..
						 bool averageFlag,
						 std::vector<Date> averDates);
	
		std::string getSymbol();
		void initialize(const TimeGrid& timeGrid, const Calendar& calendar); //daycounter �� ������ ���� �������� �� �׷��� ����.

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
		double* symbolValuesPtr_; // indexSymbolManger�� reference����.
		//std::vector<double*> symbolValues_;

		//Date payoffDates_;
		Date pastOservationDate_;
		int pastPosition_;
		int baseIndexNum_; //����ؼ� set �ϴ� �ڵ� �ʿ�.

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

		// ���� ���� �������� �Լ� �߰��ؾ���.

		//member function for specific type math_function ( Ex. date calculation )

	//double average()
	};

}
#endif