using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SecScanner
{
    public class Ipv4Range
    {
        public int iCode;
        public string AreaCode;
        public string IpStart;
        public string IpEnd;
        public string IpCount;
        public string RegisterTime;
        public UInt32 ip_start;
        public UInt32 ip_count;
        public DateTime register_time;
    }

    class IpDatebase
    {
        public List<Ipv4Range> ipranges = new List<Ipv4Range>();

        public void Load()
        {
            string[] all_lines = File.ReadAllLines(@"..\..\..\delegated-apnic-latest.txt");

            foreach (string ip_line in all_lines)
            {
                if (!ip_line.StartsWith("apnic|")) continue;
                string[] ip_items = ip_line.Split(new char[] { '|' });
                if (ip_items.Length != 7 || ip_items[2] != "ipv4") continue;
                Ipv4Range iprange = new Ipv4Range();
                iprange.iCode = ((int)ip_items[1][0]) * 256 + (int)(int)ip_items[1][1];
                iprange.AreaCode = ip_items[1];
                iprange.IpStart = ip_items[3];
                iprange.IpCount = ip_items[4];
                iprange.RegisterTime = ip_items[5];
                iprange.ip_start = IPToNumber(iprange.IpStart);
                iprange.ip_count = UInt32.Parse(iprange.IpCount);
                iprange.IpEnd = NumberToIP(iprange.ip_start + iprange.ip_count);
                ipranges.Add(iprange);
            }
            return;
        }

 

        /// <summary>
        /// 将IPv4格式的字符串转换为int型表示
        /// </summary>
        /// <param name="strIPAddress">IPv4格式的字符</param>
        /// <returns></returns>
        public static UInt32 IPToNumber(string strIPAddress)
        {
            //将目标IP地址字符串strIPAddress转换为数字
            string[] arrayIP = strIPAddress.Split('.');
            UInt32 sip1 = UInt32.Parse(arrayIP[0]);
            UInt32 sip2 = UInt32.Parse(arrayIP[1]);
            UInt32 sip3 = UInt32.Parse(arrayIP[2]);
            UInt32 sip4 = UInt32.Parse(arrayIP[3]);
            UInt32 tmpIpNumber;
            tmpIpNumber = (sip1 << 24) + (sip2 << 16) + (sip3 << 8) + sip4;
            return tmpIpNumber;
        }

        /// <summary>
        /// 将int型表示的IP还原成正常IPv4格式。
        /// </summary>
        /// <param name="intIPAddress">int型表示的IP</param>
        /// <returns></returns>
        public static string NumberToIP(UInt32 ip)
        {
            UInt32 s1 = (ip >> 24) & 0xff;
            UInt32 s2 = (ip >> 16) & 0xff;
            UInt32 s3 = (ip >> 8) & 0xff;
            UInt32 s4 = (ip >> 0) & 0xff;
            string strIPAddress = s1.ToString() + "." + s2.ToString() + "." + s3.ToString() + "." + s4.ToString();
            return strIPAddress;
        }

    }
}
