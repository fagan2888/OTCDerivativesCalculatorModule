#ifndef calculationModule_entiredomainmanager_hpp
#define calculationModule_entiredomainmanager_hpp

#include <ql/patterns/singleton.hpp>

namespace QuantLib {

    //! global repository for past index fixings
    /*! \note index names are case insensitive */
    class EntireDomainManager : public Singleton<EntireDomainManager> {
        friend class Singleton<EntireDomainManager>;
      private:
        EntireDomainManager() {	}
      public:
		//void initialize(Size nAsset,const TimeGrid& timeGrid,Calendar calendar);
		void initialize(const boost::shared_ptr<MultiPath>& multiPath, Calendar calendar);
		
		bool checkDomain();

		
		Size pathNum(const std::string& name);
		//product calendar 
		Calendar getCalendar();
		void setCalendar(Calendar calendar);

	  private:
		bool checkInitialize();
      private:

		std::vector<Date> eventDates_;
		
		std::vector<std::string> indexName_;// path num�� ���Ѱ�

        typedef std::map< std::string, boost::shared_ptr<Domain> > domain_map;
        mutable domain_map data_; //�̳��� �����͸� ���� ����Ұ��� ������ ���Ѵ� �̾߱�.


    };

}



#endif