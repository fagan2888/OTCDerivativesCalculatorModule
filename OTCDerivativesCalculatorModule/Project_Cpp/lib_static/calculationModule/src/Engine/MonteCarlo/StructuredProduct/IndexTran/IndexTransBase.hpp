#ifndef calculationModule_indextransBase_hpp
#define calculationModule_indextransBase_hpp

#include <ql/timegrid.hpp>
#include <ql/time/date.hpp>
#include <ql/time/daycounter.hpp>
#include <ql/time/calendar.hpp>
#include <ql/settings.hpp>
#include <ql/indexes/indexmanager.hpp>
#include <ql/timeseries.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/EventFunction/eventFunction.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/variableValue/variableValue.hpp>

namespace QuantLib {
	
	class IndexTransBase {
		public:
		IndexTransBase(const std::string& symbolName);
	
		virtual Size size() = 0;
		std::string getSymbol(){return symbolName_;}
		
		virtual void initialize() = 0;
		
		virtual void calculate() = 0;
		//daily check calculation��, time type�� �ƴϸ� �ƹ��� ���Ұ���.
		//virtual void calculate(int refDatePosition);
					
		//history �켱 �̷��� �ϰ� ���߿� menual fix�� �����ҵ�.
		//DB�� ������ �޾Ƽ� menual fix ��Ű�� ���.
		//���� ����. daily�� ����� ���� �����ϱ�.. ��.��;;

		//timeIndexTrans�� ���� refEventDates
		//virtual void setTimeInformation(const std::vector<Date>& eventDates) = 0;
		//void setIndexPtrForHistoryValue(const std::vector<boost::shared_ptr<IndexTransBase>>& preTransBases);

		//multiPath �� ������� �Ŀ� position ��ġ ���ε� ��Ŵ
		//indexFixing �� ��������鼭 binding �� �ȵ�.
		//virtual void bindingPathPosition() = 0;
		//virtual void bindingPathPosition(const MultiPath& pathInfo){QL_FAIL("not implemented");}
		virtual void variableBind() = 0;
		virtual void variablePtrBind() = 0;
		virtual std::vector<Date> indexFixingDates() = 0;

	protected:

		//std::vector<boost::shared_ptr<IndexTransBase>> preTransBases_;
		boost::shared_ptr<VariableValue> thisVariableValue_;
		std::vector<Date> indexFixingDates_;
//		mu::Parser parser_;
		//bool fixedFlag_; // ���� fixed ����
		std::string symbolName_;
		//std::string eqExpression_;
		double* symbolValuesPtr_; // indexSymbolManger�� reference����.
		//std::vector<double*> symbolValues_;
		//boost::shared_ptr<EventFunction> domainSet_;
		int position_;
		Real* thisPtr_;
	};

}

#endif