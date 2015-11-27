#ifndef calculationModule_ieventcheck_hpp
#define calculationModule_ieventcheck_hpp

#include <ql/timegrid.hpp>
#include <ql/time/calendar.hpp>
#include <ql/methods/montecarlo/multipath.hpp>

namespace QuantLib {

	class IEventCheck {

		public:
			~IEventCheck();

			virtual void gridInitialize(const TimeGrid& timeGrid, const Calendar& calendar) = 0;
			virtual void addSymbolEvent(const std::string& symbolName) = 0;
			virtual void defineConst(const std::string varStr,Real constValue) =0;
			virtual void defineBaseIndex(const std::string varStr) = 0;
			virtual void defineVar(const std::string varStr) = 0;

			virtual void calculate() = 0;
			virtual Real payoff() = 0;

			virtual void reset() = 0;
			virtual Size payoffIndexLocation() = 0;


	};

}

#endif