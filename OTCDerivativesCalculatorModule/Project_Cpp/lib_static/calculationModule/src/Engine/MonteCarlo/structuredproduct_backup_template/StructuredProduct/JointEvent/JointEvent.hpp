#ifndef calculationModule_jointevent_hpp
#define calculationModule_jointevent_hpp

#include <vector>

// bit연산으로 변경

namespace QuantLib {
	//template 로 갈거임.
	class JointEvent {
	  public:
		  JointEvent(bool tf) { setbools_.push_back(tf);  }
		  JointEvent(std::vector<bool> setbools) : setbools_(setbools) {
			  setboolCount_ = setbools.size();
		  }
		  ~JointEvent(){}
		  //usual
		  virtual bool checkJoint(const std::vector<bool>& checkbools) = 0;
		  //timeStream을 위한것
		  virtual bool checkJoint(const std::vector<bool>& checkbools,int startDatePosition,int refDatePosition) = 0;
		  
		  virtual int getCount() const = 0;
	  protected:
		  std::vector<bool> setbools_;
		  int setboolCount_;
	};

	class IdentityJointEvent : public JointEvent {
		public:
			IdentityJointEvent(bool tf) :  JointEvent(tf) {}
			IdentityJointEvent(std::vector<bool> setbools) //항상 true를 반환할지 false를 반환할지 여부
				: JointEvent(setbools[0]) { } 

			bool checkJoint(const std::vector<bool>& checkbools) {
				return setbools_[0];
			}
			bool checkJoint(const std::vector<bool>& checkbools,int startDatePosition,int refDatePosition) {
				return setbools_[0];
			}
			int getCount() const{
				return 1;
			}
	
	};

	class AndJointEvent : public JointEvent {
		public:
			AndJointEvent(bool tf) :  JointEvent(tf) {}
			AndJointEvent(std::vector<bool> setbools) 
				: JointEvent(setbools) { } 

			bool checkJoint(const std::vector<bool>& checkbools) {
				return setbools_[0];
			}
			bool checkJoint(const std::vector<bool>& checkbools,int startDatePosition,int refDatePosition) {
				return setbools_[0];
			}
			int getCount() const{
				return 1;
			}
	
	};

	class ORJointEvent : public JointEvent {
		public:
			ORJointEvent(bool tf) :  JointEvent(tf) {}
			ORJointEvent(std::vector<bool> setbools) //항상 true를 반환할지 false를 반환할지 여부
				: JointEvent(setbools[0]) { } 

			bool checkJoint(const std::vector<bool>& checkbools) {
				return setbools_[0];
			}
			bool checkJoint(const std::vector<bool>& checkbools,int startDatePosition,int refDatePosition) {
				return setbools_[0];
			}
			int getCount() const{
				return 1;
			}
	
	};

	class CompJointEvent : public JointEvent {
		public:
			CompJointEvent(bool tf) :  JointEvent(tf) {}
			CompJointEvent(std::vector<bool> setbools) //항상 true를 반환할지 false를 반환할지 여부
				: JointEvent(setbools[0]) { } 

			bool checkJoint(const std::vector<bool>& checkbools) {
				return setbools_[0];
			}
			bool checkJoint(const std::vector<bool>& checkbools,int startDatePosition,int refDatePosition) {
				return setbools_[0];
			}
			int getCount() const{
				return 1;
			}
	
	};


	class AtLeatJointEvent : public JointEvent {
		public:
			AtLeatJointEvent(bool tf) : JointEvent(tf) 
			{
				numSetAtLeast_=1;
				setboolCount_=1;
			}
			AtLeatJointEvent(std::vector<bool> setbools,
							 int numSetAtLeast = 1) 
				: JointEvent(setbools) 
			{
				numSetAtLeast_=numSetAtLeast;
			} 
			int getCount(){return leastCount_;}

			bool checkJoint(const std::vector<bool>& checkbools) {
			
				//QL_REQUIRE(setboolCount_==checkbools.int(),"input int and check int is not same")
				int leastCount = 0;
				
				for(int i=0;i<setboolCount_;++i){
					if(checkbools[i] == setbools_[i]){
						leastCount += 1;	
					}
				}

				leastCount_ = leastCount;
				if(leastCount_ >= numSetAtLeast_){tf_=true;}
				else{tf_=false;}
					
				return tf_;

			}
		
			bool checkJoint(const std::vector<bool>& checkbools,int startDatePosition,int refDatePosition){
				
				//QL_REQUIRE(setboolCount_==checkbools.int(),"input int and check int is not same")
				int leastCount = 0;
				
				for(int i=0;i<refDatePosition;++i){
					if(setbools_[i] == setbools_[i]){
						leastCount += 1;	
					}
				}

				leastCount_ = leastCount;
				if(leastCount_ >= numSetAtLeast_){tf_=true;}
				else{tf_=false;}
					
				return tf_;

			}

			private:
				int numSetAtLeast_;
				int leastCount_; 
				bool tf_;;
	
	};

}

#endif