#ifndef calculationModule_payoffInformation_hpp
#define calculationModule_payoffInformation_hpp

#include <ql/patterns/singleton.hpp>
#include <calculationModule/src/Engine/MonteCarlo/StructuredProduct/variableValue/variableValue.hpp>
#include <valarray>

namespace QuantLib {

    //! global repository for past index fixings
    /*! \note index names are case insensitive */
    class PayoffInformation : public Singleton<PayoffInformation> {
        friend class Singleton<PayoffInformation>;
      private:
        PayoffInformation() {}
      public:
		void initialize();
        //! returns whether historical fixings were stored for the index
        bool hasDate(const Date& date) const;
		
		Real* getPositionPtr(const Date& date) const;

        //! clears the historical fixings of the index
		void addPayoffDate(const Date& date);
		void removePayoffDate(const Date& date);
		
		//! clears all stored fixings
		void clearPayoffDate();

		void zeroPayoff(const Date& date);
        void zeroPayoff();
		
		bool checkInitialize() const;

      public:
        typedef std::map< Date, Size > symbol_map;
        mutable symbol_map data_; //이놈의 포인터를 얻어가서 사용할거임 딴데서 변한단 이야기.

		std::valarray<Real> payoff_;

		std::vector<Date> payoffDates_;
		std::vector<Date> remainPayoffDates_;

		Size pastPosition_;
		Size payoffDateNum_;

		bool initializeFlag_;
    };

}


#endif
