#ifndef quantlib_CashFlowResult_hpp
#define quantlib_CashFlowResult_hpp

#include <boost/shared_ptr.hpp>
#include <ql/time/date.hpp>
#include <string>

namespace QuantLib {

	class CashFlowResult
	{
		public:
			CashFlowResult();
			CashFlowResult(Size seq,
							Date eventDate,
							Date payoffDate,
							std::string type,
							std::string currency,
							Real discount);

			//void initialize(Size seq,
			//				Date eventDate,
			//				std::string type,
			//				std::string currency,
			//				Real simulNum);

			void initialize(const boost::shared_ptr<CashFlowResult>& cf_result, Real simulNum);

			void cumulate(const boost::shared_ptr<CashFlowResult>& cf_result);
		
			void reset();
		//member

		// cumul part
		public:
			double cashFlow() const { return this->cashFlow_ /  this->simulNum_; }
			double discount() const { return this->discount_ ; }
			double exProb() const { return this->exProb_ /  this->simulNum_; }
			double value() const { return this->value_ /  this->simulNum_; }
			double yield() const { return this->yield_ /  this->simulNum_; }
			double notionalPayment() const { return this->notionalPayment_ /  this->simulNum_; }
		
			double cashFlow_;
			double discount_;
			double exProb_;
			double value_;
			double notionalPayment_;
		
		// setting part
			Size seq_;
			Date eventDate_;
			Date payoffDate_;
			std::string type_;
			std::string currency_;
			bool isExpired_;
		// later calc part
			double yield_;

			// 고정된 payoffDate 에 관련된 discount Factor임
			// expected discount factor를 계산하기 위한 cumulate 작업을 위해 초기값을 설정함.
			Real initial_discount_; 
			

		private:
			Size cummulCount_;
			Real simulNum_;
			
	};

			
}

#endif