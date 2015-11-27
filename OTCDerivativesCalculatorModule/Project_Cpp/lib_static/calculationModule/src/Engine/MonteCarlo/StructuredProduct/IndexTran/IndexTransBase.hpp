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
		//daily check calculation용, time type이 아니면 아무짓 안할거임.
		//virtual void calculate(int refDatePosition);
					
		//history 우선 이렇게 하고 나중에 menual fix로 가야할듯.
		//DB의 도움을 받아서 menual fix 시키고 사용.
		//최초 계산용. daily로 만들면 존내 나오니까.. ㅡ.ㅡ;;

		//timeIndexTrans용 계산될 refEventDates
		//virtual void setTimeInformation(const std::vector<Date>& eventDates) = 0;
		//void setIndexPtrForHistoryValue(const std::vector<boost::shared_ptr<IndexTransBase>>& preTransBases);

		//multiPath 가 만들어진 후에 position 위치 바인딩 시킴
		//indexFixing 이 만들어지면서 binding 이 안됨.
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
		//bool fixedFlag_; // 과거 fixed 여부
		std::string symbolName_;
		//std::string eqExpression_;
		double* symbolValuesPtr_; // indexSymbolManger에 reference용임.
		//std::vector<double*> symbolValues_;
		//boost::shared_ptr<EventFunction> domainSet_;
		int position_;
		Real* thisPtr_;
	};

}

#endif