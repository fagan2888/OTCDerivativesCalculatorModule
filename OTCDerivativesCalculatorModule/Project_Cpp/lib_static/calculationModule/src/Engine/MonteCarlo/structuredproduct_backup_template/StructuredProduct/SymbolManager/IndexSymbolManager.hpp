#ifndef calculationModule_index_symbol_manager_hpp
#define calculationModule_index_symbol_manager_hpp

#include <ql/patterns/singleton.hpp>

namespace QuantLib {

    //! global repository for past index fixings
    /*! \note index names are case insensitive */
    class IndexSymbolManager : public Singleton<IndexSymbolManager> {
        friend class Singleton<IndexSymbolManager>;
      private:
        IndexSymbolManager() {}
      public:
        //! returns whether historical fixings were stored for the index
        bool hasSymbol(const std::string& name) const;
		
		//이미 있는 symbol이면 주소만 반환해줌.
		double* setSymbol(const std::string& name) const;

        //! clears the historical fixings of the index
        void clearSymbol(const std::string& name);
        //! clears all stored fixings
        void clearSymbol();

      public:
        typedef std::map< std::string, Real > symbol_map;
		
        mutable symbol_map data_; //이놈의 포인터를 얻어가서 사용할거임 딴데서 변한단 이야기.
    };

}


#endif
