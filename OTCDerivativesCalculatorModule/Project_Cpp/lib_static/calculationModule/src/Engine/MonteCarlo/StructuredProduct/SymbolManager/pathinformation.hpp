#ifndef calculationModule_pathInformation_hpp
#define calculationModule_pathInformation_hpp

#include <ql/patterns/singleton.hpp>
#include <ql/methods/montecarlo/multipath.hpp>
#include <ql/time/calendar.hpp>

namespace QuantLib {

    //! global repository for past index fixings
    /*! \note index names are case insensitive */
    class PathInformation : public Singleton<PathInformation> {
        friend class Singleton<PathInformation>;
      private:
        PathInformation() {
			initializeFlag_ = false;
			IndexFixingDatesSetFlag_ = false;	
		}
      public:
		//void initialize(Size nAsset,const TimeGrid& timeGrid,Calendar calendar);
		void initialize(const boost::shared_ptr<MultiPath>& multiPath, Calendar calendar);
		void addIndexFixingDate(const Date& indexFixingDate);
		std::vector<Date> indexFixingDates();
		void addIndexName(const std::string& name);
		boost::shared_ptr<MultiPath> getMultiPath();
		void setMultiPath(MultiPath& multiPath);

		Size getPosition(const Date& date);
		double* getPositionPtr(const std::string& name,const Date& date);
		Size getIndexPosition(const std::string& name);
        bool hasPath(const std::string& name) const;
        void clearPath(const std::string& name);
        void clearPath();
		Size pathNum(const std::string& name);
		//product calendar 
		Calendar getCalendar();
		void setCalendar(Calendar calendar);

	  private:
		bool checkInitialize();
      private:

		std::vector<Date> indexFixingDates_;
		std::vector<Date> remainIndexFixingDates_;

		std::vector<std::string> indexName_;// path num을 위한것
        typedef std::map< std::string, Real > path_map;
        mutable path_map data_; //이놈의 포인터를 얻어가서 사용할거임 딴데서 변한단 이야기.

		boost::shared_ptr<MultiPath> multiPath_;
		//MultiPath* multiPathPtr_;
		
		// product Calendar임. path는 product종속이므로 여기서 setting 하고 가져다 쓸거임, history calculation 할때 여기서 가져가서 씀.  // 과거 index 뽑을때는 index Calendar 로 계산할거임.
		Calendar calendar_;

		Size count_; // index add 할때 사용 
		Size maxCount_;
		Size pathSize_;

		bool initializeFlag_;
		bool IndexFixingDatesSetFlag_;

    };

}



#endif