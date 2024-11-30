using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PC_DTO;
using PC_DAL;
using System.Data;

namespace PC_BLL
{
    public class BLLNV
    {
        DALNV dALNV = new DALNV();
        public List<DTONV> LoadNVBlL()
        {
            return dALNV.LoadNV();
        }
    }
}
