#ifndef calculationModule_indextransBase_hpp
#define calculationModule_indextransBase_hpp

#include <ql/timegrid.hpp>
#include <ql/time/date.hpp>
#include <ql/time/daycounter.hpp>
#include <ql/time/calendar.hpp>
#include <ql/settings.hpp>
#include <ql/methods/montecarlo/multipath.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/SymbolManager/indexsymbolmanager.hpp>

#include <ql/testClass/muparser/muparser.h>

namespace QuantLib {
	
	class IndexTransBase {
		public:
		IndexTransBase();

		IndexTransBase(const std::string& symbolName,
						 const std::string& eqExpression
						 );
	
		virtual Size size() = 0;
		std::string getSymbol(){return symbolName_;}
		void initialize(const TimeGrid& timeGrid, const Calendar& calendar); //daycounter �� ������ ���� �������� �� �׷��� ����.

		//void defineVar(const std::string varStr,double* value);
		virtual void defineVar(const std::string varStr);
		virtual void defineConst(const std::string varStr,Real constValue);
		virtual void defineBaseIndex(const std::string varStr);

		virtual void calValue();
		virtual void calValue(int refDatePosition);

	protected:
		
//		mu::Parser parser_;
		std::string symbolName_;
		std::string eqExpression_;
		double* symbolValuesPtr_; // indexSymbolManger�� reference����.
		//std::vector<double*> symbolValues_;

		int position_;
		 //����ؼ� set �ϴ� �ڵ� �ʿ�.

//		const std::vector<std::string> addedSymbols_;
//		const MultiPath* multiPath_;

		// ���� ���� �������� �Լ� �߰��ؾ���.

		//member function for specific type math_function ( Ex. date calculation )

	//double average()
	};

}
#endif