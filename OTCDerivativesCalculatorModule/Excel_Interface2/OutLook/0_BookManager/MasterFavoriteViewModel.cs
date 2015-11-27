using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    // 전체 포지션, 사용자 포지션은 개개의 BookXmlFile에 종속함.
    public class MasterFavoriteViewModel : FavoriteViewModel
    {

        public MasterFavoriteViewModel()
        {
            this.favoriteCode_ = "wholeMasterPositionCode";
            this.favoriteName_ = "wholeMasterPosition";
            
            this.instrumentList_ = MasterInformationViewModel.WholeMasterPosition_;
        }

        public override bool removeInstrument(Excel_instrumentViewModel e_ivm)
        {
            // list 에서 삭제함.
            this.instrumentList_.Remove(e_ivm);

            // db 에서 삭제함.
            MasterInformationViewModel.removeMasterInfo(e_ivm.Item_code_);



            return true;
            
        }

        public override void AddInstrument(Excel_instrumentViewModel e_instVM)
        {
            //base.AddInstrument(e_instVM);
        }


    }
}
