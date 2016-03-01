using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BLL.DbLogic;

namespace BLL
{
    public class TxtCreator
    {
        public TxtCreator()
        {
            this.WriteFile();
        }
        public void WriteFile()
        {
            try
            {
                File.Delete(
                    "C:\\Users\\Alex\\Desktop\\EpamInternetProvider\\EpamInternetProvider\\App_Data\\СписокЗадач.txt");
            }
            catch { }
            using (FileStream fs = File.Create(
                "C:\\Users\\Alex\\Desktop\\EpamInternetProvider\\EpamInternetProvider\\App_Data\\СписокЗадач.txt"))
            {
                fs.Dispose();
            }
            using (StreamWriter sw = new StreamWriter("C:\\Users\\Alex\\Desktop\\EpamInternetProvider\\EpamInternetProvider\\App_Data\\СписокЗадач.txt", true))
            {
                var db = new AllDb();
                foreach (var rate in db.RateDb.GetAll())
                {
                    sw.Write(rate.Title + " " + rate.Price + "      ");
                }
            }
        }
    }
}
