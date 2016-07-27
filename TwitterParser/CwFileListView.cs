using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TwitterParser
{
    public class CwFileListView : ListView
    {
        public CwFileListView()
        {
            base.AllowDrop = true;
            Columns.Add("Kullanıcı Adı");
            Columns[0].Width = 150;
            Columns.Add("Tweet");
            Columns[1].Width = 1000;
            Columns.Add("Link");
            Columns[2].Width = 800;
            View = View.Details;
            FullRowSelect = true;
            SmallImageList = new ImageList();
        }
    }
}
