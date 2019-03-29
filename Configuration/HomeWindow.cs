using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Configuration
{
    public partial class HomeWindow : Form
    {
        public HomeWindow()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.ReadOnly = true;
            lbl_message.Text = "Overview of current \nconfiguration settings";
        }

        private void HomeWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fog_Light_KanbanDataSet1.Configuration_Table' table. You can move, or remove it, as needed.
            this.configuration_TableTableAdapter.Fill(this.fog_Light_KanbanDataSet1.Configuration_Table);

        }
    }
}
