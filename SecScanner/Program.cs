using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SecScanner
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IpDatebase IpDb = new IpDatebase();
            IpDb.Load();
            foreach(string area in IpDb.IpAreas)
            {
                using (TextWriter file = File.CreateText(@"..\..\..\ip." + area))
                {
                    long total_ip = 0;
                    foreach (Ipv4Range ir in IpDb.IpRanges)
                    {
                        if (ir.AreaCode == area)
                        {
                            file.WriteLine(ir.IpStart + "\t" + ir.IpEnd + "\t" + ir.IpCount + "\t" + MSB(ir.ip_count));
                            total_ip += ir.ip_count;
                        }
                    }
                    file.WriteLine("total ip:" + total_ip);
                    file.Close();
                }
            }
            //Application.Run(new Form1());
            Application.Run(new FormLogin());
        }

        static int MSB(long num)
        {
            long msb = 0x01;
            for(int i = 32; i > 0; i--,msb<<=1)
            {
                if (msb == num) return i;
            }
            return 0;
        }
    }
}
