using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using phanmemquanlylichthi.DTO.model;

namespace phanmemquanlylichthi.DAO
{
    public class ChuyennganhDAO
    {
        modelDataContext db = new modelDataContext();
        private static ChuyennganhDAO instance;
        public static ChuyennganhDAO Instance
        {
            get { if (instance == null) instance = new ChuyennganhDAO(); return ChuyennganhDAO.instance; }
            private set { ChuyennganhDAO.instance = value; }
        }

        private ChuyennganhDAO()
        { }
    }
}
