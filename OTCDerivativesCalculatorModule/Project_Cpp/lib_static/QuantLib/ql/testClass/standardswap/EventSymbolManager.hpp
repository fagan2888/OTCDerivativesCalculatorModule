#ifndef quantlib_event_symbol_manager_hpp
#define quantlib_event_symbol_manager_hpp

#include <ql/patterns/singleton.hpp>
#include <ql/testClass/standardSwap/EventCheck.hpp>
#include <boost/shared_ptr.hpp>

namespace QuantLib {

    //! global repository for past index fixings
    /*! \note index names are case insensitive */
    class EventSymbolManager : public Singleton<EventSymbolManager> {
        friend class Singleton<EventSymbolManager>;
      private:
        EventSymbolManager() {}
      public:
        //! returns whether historical fixings were stored for the index
        bool hasSymbol(const std::string& name) const;
		 
		boost::shared_ptr<EventCheck> getSymbol(const std::string& name) const;
		
		void setSymbol(const std::string& name , const boost::shared_ptr<EventCheck>& ptr) const;

        //! clears the historical fixings of the index
        void clearSymbol(const std::string& name);
        //! clears all stored fixings
        void clearSymbol();

      public:
        typedef std::map< std::string, boost::shared_ptr<EventCheck> > symbol_map;
		
        mutable symbol_map data_; //이놈의 포인터를 얻어가서 사용할거임 딴데서 변한단 이야기.
    };

}


#endif
