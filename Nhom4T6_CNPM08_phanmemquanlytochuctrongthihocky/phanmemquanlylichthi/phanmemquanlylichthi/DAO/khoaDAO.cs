using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using phanmemquanlylichthi.DTO.model;

namespace phanmemquanlylichthi.DAO
{
    public class khoaDAO
    {
        modelDataContext db = new modelDataContext();
        private static khoaDAO instance;
        public static khoaDAO Instance
        {
            get { if (instance == null) instance = new khoaDAO(); return khoaDAO.instance; }
            private set { khoaDAO.instance = value; }
        }

        private khoaDAO()
        { }
        
    }
}
