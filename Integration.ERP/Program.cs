using Integration.ERP.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Integration.ERP
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceFtp sftp = new ServiceFtp(new System.Net.NetworkCredential("AvisSite", "dm#o4%v#Wn43arWv2"), "ftp://new.avislogistics.kz:2021/GOODS_RECEIPT/");
            //sftp.DownLoadFile();
        }
    }
}
