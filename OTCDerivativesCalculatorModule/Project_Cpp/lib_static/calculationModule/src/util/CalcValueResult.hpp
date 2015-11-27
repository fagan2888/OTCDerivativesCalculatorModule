#ifndef quantlib_CalcValueResult_hpp
#define quantlib_CalcValueResult_hpp

#include <boost/shared_ptr.hpp>
#include <ql/time/date.hpp>
#include <string>

namespace QuantLib {

	//resultSide, // net : 0 , pay  : 1 , receive : 2
	class CalcValueResult
	{
		public:
			CalcValueResult();

			CalcValueResult(std::string resultSide,
						    std::string currency);

			void initialize(const boost::shared_ptr<CalcValueResult>& calcValue_result,Real simulNum);
			void initialize(Real simulNum);

			void cumulate(const boost::shared_ptr<CalcValueResult>& calcValue_result);
			//void reset();

		// cumul part
		public:
			Real dirty() const;
			Real option() const;
			
			Real dirty_;
			Real option_;

		// setting part
			Real clean() const; 
			Real accrualAmt() const;

			Real accrualAmt_;
			std::string resultSide_;
			
			std::string currency_;

		private:
			Size cummulCount_;
			Real simulNum_;
			 
			
	};

			
}

#endif