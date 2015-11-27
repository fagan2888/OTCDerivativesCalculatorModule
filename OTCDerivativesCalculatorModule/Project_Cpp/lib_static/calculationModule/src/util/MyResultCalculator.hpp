#ifndef quantlib_MyResultCalculator_hpp
#define quantlib_MyResultCalculator_hpp

#include <boost/shared_ptr.hpp>
#include <src/Engine/MonteCarlo/MCPricer.hpp>
#include <src/Engine/MonteCarlo/result/resultCommulator.hpp>
#include <src/Engine/MonteCarlo/result/CalculationLogCommulator.hpp>
#include <src/util/CalcValueResult.hpp>

namespace QuantLib {

	class MyResultCalculator {
	
		public:
			MyResultCalculator();

			void calculation(const boost::shared_ptr<MCPricer>& pricer,
							 const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);

			void initialize(const boost::shared_ptr<MCPricer>& pricer,
							const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory,
							Real simulNum);

			void reset(const boost::shared_ptr<PathGeneratorFactory>& pathGenFactory);
			void calculateGreek();
			void save();

			//double payValue_;
			//double receiveValue_;
			double value_;

			double simulNum_;

			std::vector<double> S_h_;

			std::vector<double> S_up_;
			std::vector<double> S_down_;
			
			std::vector<double> sigma_up_;
			std::vector<double> sigma_down_;

			double time_oneDayLater_;

			Size numAssets_;
		//result
		
		//method
			double value();

			std::vector<std::string> underlyingName();
			std::vector<double> underlyingValue();
			std::vector<double> basePrice();
			std::vector<double> volatility();

			std::vector<double> delta();
			std::vector<double> gamma();
			std::vector<double> vega();
			std::vector<double> rho();
			double theta();

		//member

			// under Info
			std::vector<std::string> underlyingName_;
			std::vector<double> underlyingValue_;
			std::vector<double> basePrice_;
			std::vector<double> volatility_;

			//greek
			std::vector<double> delta_;
			std::vector<double> gamma_;
			std::vector<double> vega_;
			std::vector<double> rho_;
			double theta_;

			std::vector<CashFlowResult> cashFlowResults_;
			std::vector<CalcValueResult> valueResults_;


		private:
			boost::shared_ptr<ResultCommulator> resultCommulator_;
			mutable std::vector<std::vector<std::string>> logList_;
	};

			
}

#endif