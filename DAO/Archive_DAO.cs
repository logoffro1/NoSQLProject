using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Archive_DAO : Base
    {
        public void ArchiveDatabase(string collectionName, int daysOldArchive)
        {
            base.ArchiveDatabase(collectionName, daysOldArchive);
        }
    }
}
