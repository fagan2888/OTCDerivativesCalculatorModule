using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excel_Interface
{
    //rootfavoritVM 과 rootbookVM의 interface
    interface IFolderAction
    {
        bool removeInstrument(Excel_instrumentViewModel itemCode);
    }
}
