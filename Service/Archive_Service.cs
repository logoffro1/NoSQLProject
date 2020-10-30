using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace Service
{
    public class Archive_Service
    {
        private Archive_DAO archiveDao = new Archive_DAO();

        public void ArchiveConfigItemDatabase()
        {
            archiveDao.ArchiveDatabase("configitemdb", 10);
        }



    }


}
