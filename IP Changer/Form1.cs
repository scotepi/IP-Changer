using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IP_Changer
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();

            var nicList = new List<NICs>();
            nicList.Add(new NICs() { Name = "abc", Value = "def" });
            nicList.Add(new NICs() { Name = "xyz", Value = "nyc" });

            //mainWindow.listNic.DataSource = nicList;
            //mainWindow.listNic.DisplayMember = "Name";
            //mainWindow.listNic.ValueMember = "Value";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public class NICs
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }
    }
}
