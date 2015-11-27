#ifndef quantlib_jointevent_hpp
#define quantlib_jointevent_hpp

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
		  virtual bool checkJoint(const std::vector<bool>& checkbools,Size startDatePosition,Size refDatePosition) = 0;
		  
		  virtual Size getCount() const = 0;

		  std::vector<bool> setbools_;
		  Size setboolCount_;
	};

	class IdentityJointEvent : public JointEvent {
		public:
			IdentityJointEvent(bool tf) :  JointEvent(tf) {}
			IdentityJointEvent(std::vector<bool> setbools) //항상 true를 반환할지 false를 반환할지 여부
				: JointEvent(setbools[0]) { } 

			bool checkJoint(const std::vector<bool>& checkbools) {
				return setbools_[0];
			}
			bool checkJoint(const std::vector<bool>& checkbools,Size startDatePosition,Size refDatePosition) {
				return setbools_[0];
			}
			Size getCount() const{
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
			Size getCount(){return leastCount_;}

			bool checkJoint(const std::vector<bool>& checkbools) {
			
				//QL_REQUIRE(setboolCount_==checkbools.size(),"input Size and check Size is not same")
				Size leastCount = 0;
				
				for(Size i=0;i<setboolCount_;++i){
					if(checkbools[i] == setbools_[i]){
						leastCount += 1;	
					}
				}

				leastCount_ = leastCount;
				if(leastCount_ >= numSetAtLeast_){tf_=true;}
				else{tf_=false;}
					
				return tf_;

			}
		
			bool checkJoint(const std::vector<bool>& checkbools,Size startDatePosition,Size refDatePosition){
				
				//QL_REQUIRE(setboolCount_==checkbools.size(),"input Size and check Size is not same")
				Size leastCount = 0;
				
				for(Size i=0;i<refDatePosition;++i){
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
				Size numSetAtLeast_;
				Size leastCount_; 
				bool tf_;;
	
	};

}

#endif