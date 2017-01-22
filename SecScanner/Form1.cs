using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecScanner
{
    public partial class Form1 : FormLogin
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStrip1.ImageList = imageList1;
            UpdateListViewIp();
        }

        private void UpdateListViewIp()
        {
            IpDatebase IpDb = new IpDatebase();
            IpDb.Load();
            treeView1.BeginUpdate();
            foreach(string area in IpDb.IpAreas)
            {
                treeView1.Nodes.Add(area);
            }
            treeView1.EndUpdate();

            listViewIp.BeginUpdate();
            listViewIp.Columns.Add("国家/地区", 100);
            listViewIp.Columns.Add("起始IP地址", 200);
            listViewIp.Columns.Add("结束IP地址", 200);
            listViewIp.Columns.Add("IP数量", 200);
            listViewIp.Columns.Add("分配日期", 200);
            foreach (Ipv4Range iprange in IpDb.IpRanges)
            {
                ListViewItem li = listViewIp.Items.Add(iprange.AreaCode);
                li.SubItems.Add(iprange.IpStart);
                li.SubItems.Add(iprange.IpEnd);
                li.SubItems.Add(iprange.IpCount);
                li.SubItems.Add(iprange.RegisterTime);
            }
            listViewIp.EndUpdate();
        }

        private void toolStripButton_ExportIp_Click(object sender, EventArgs e)
        {

        }
    }
}
