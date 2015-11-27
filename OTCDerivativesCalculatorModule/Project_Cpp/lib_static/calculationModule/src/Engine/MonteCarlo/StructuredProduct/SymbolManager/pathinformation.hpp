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

		std::vector<std::string> indexName_;// path num�� ���Ѱ�
        typedef std::map< std::string, Real > path_map;
        mutable path_map data_; //�̳��� �����͸� ���� ����Ұ��� ������ ���Ѵ� �̾߱�.

		boost::shared_ptr<MultiPath> multiPath_;
		//MultiPath* multiPathPtr_;
		
		// product Calendar��. path�� product�����̹Ƿ� ���⼭ setting �ϰ� ������ ������, history calculation �Ҷ� ���⼭ �������� ��.  // ���� index �������� index Calendar �� ����Ұ���.
		Calendar calendar_;

		Size count_; // index add �Ҷ� ��� 
		Size maxCount_;
		Size pathSize_;

		bool initializeFlag_;
		bool IndexFixingDatesSetFlag_;

    };

}



#endif