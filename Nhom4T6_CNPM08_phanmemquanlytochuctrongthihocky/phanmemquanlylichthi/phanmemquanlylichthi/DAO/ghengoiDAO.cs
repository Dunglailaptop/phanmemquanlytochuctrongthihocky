using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using phanmemquanlylichthi.DTO.model;

namespace phanmemquanlylichthi.DAO
{
    public class ghengoiDAO
    {
        modelDataContext db = new modelDataContext();
        private static ghengoiDAO instance;
        public static ghengoiDAO Instance
        {
            get { if (instance == null) instance = new ghengoiDAO(); return ghengoiDAO.instance; }
            private set { ghengoiDAO.instance = value; }
        }

        private ghengoiDAO()
        { }

        public bool insertghengoi(string maphong,int stt)
        {
            string q = "INSERT INTO ghengoi(phongthi,soghe) values ('"+maphong+"','"+stt+"')";
            int result = DataProvider.Instance.ExecuteNonQuery(q);
            return result> 0;
        }

 
    }
}
