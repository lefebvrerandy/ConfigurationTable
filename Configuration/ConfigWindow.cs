using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Configuration
{
    public partial class ConfigWindow : Form
    {
        DataFields df = new DataFields();
        SQL _sql;
        bool connected = false;

        public ConfigWindow()
        {
            InitializeComponent();
            RoundBorderForm(this);
            InitializeSidePanel();
            InitializeHeaderPanel();
            InitializeSideButtonEvents();
            if (LoadConnectionString())
            {
                OpenHomeWindow();
            }
            this.Icon = new Icon("..//..//resources//Configicon.ico");
        }

        // //////////////////////////////////////////////////////////
        //              Moving Form With Drag and Drop
        // //////////////////////////////////////////////////////////

        private bool mouseDown;
        private Point lastLocation;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        // //////////////////////////////////////////////////////////
        //                  Rounded Form Border
        // //////////////////////////////////////////////////////////

        /// <summary>
        /// Gathered from 
        /// https://stackoverflow.com/questions/10674228/form-with-rounded-borders-in-c
        /// </summary>
        /// <param name="frm"></param>
        public static void RoundBorderForm(Form frm)
        {

            Rectangle Bounds = new Rectangle(0, 0, frm.Width, frm.Height);
            int CornerRadius = 20;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(Bounds.X, Bounds.Y, CornerRadius, CornerRadius, 180, 90);
            path.AddArc(Bounds.X + Bounds.Width - CornerRadius, Bounds.Y, CornerRadius, CornerRadius, 270, 90);
            path.AddArc(Bounds.X + Bounds.Width - CornerRadius, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
            path.AddArc(Bounds.X, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
            path.CloseAllFigures();

            frm.Region = new Region(path);
            frm.Show();
        }

        // //////////////////////////////////////////////////////////
        //                   Button Setup
        // //////////////////////////////////////////////////////////

        private void InitializeHeaderPanel()
        {
            // Home button
            btn_Home.FlatStyle = FlatStyle.Flat;
            btn_Home.BackColor = Color.White;
            btn_Home.FlatAppearance.BorderSize = 0;
        }

        private void InitializeSidePanel()
        {
            // Button
            btn_ScaleAndRate.FlatStyle = FlatStyle.Flat;
            btn_ScaleAndRate.BackColor = Color.FromArgb(41, 53, 65);
            btn_ScaleAndRate.ForeColor = Color.White;
            btn_ScaleAndRate.FlatAppearance.BorderSize = 0;

            btn_Defect.FlatStyle = FlatStyle.Flat;
            btn_Defect.BackColor = Color.FromArgb(41, 53, 65);
            btn_Defect.ForeColor = Color.White;
            btn_Defect.FlatAppearance.BorderSize = 0;

            btn_Build.FlatStyle = FlatStyle.Flat;
            btn_Build.BackColor = Color.FromArgb(41, 53, 65);
            btn_Build.ForeColor = Color.White;
            btn_Build.FlatAppearance.BorderSize = 0;

            btn_Bin.FlatStyle = FlatStyle.Flat;
            btn_Bin.BackColor = Color.FromArgb(41, 53, 65);
            btn_Bin.ForeColor = Color.White;
            btn_Bin.FlatAppearance.BorderSize = 0;

            btn_Create.FlatStyle = FlatStyle.Flat;
            btn_Create.BackColor = Color.FromArgb(41, 53, 65);
            btn_Create.ForeColor = Color.White;
            btn_Create.FlatAppearance.BorderSize = 0;

            button2.FlatStyle = FlatStyle.Flat;
            button2.BackColor = Color.FromArgb(41, 53, 65);
            button2.ForeColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
        }

        private void InitializeHeaderButtonEvents()
        {
            btn_Home.MouseEnter += new System.EventHandler(this.buttonHome_mousehover);
            btn_Home.MouseLeave += new System.EventHandler(this.buttonHome_mouseleave);
        }

        private void InitializeSideButtonEvents()
        {
            btn_ScaleAndRate.MouseEnter += new System.EventHandler(this.button_mousehover);
            btn_ScaleAndRate.MouseLeave += new System.EventHandler(this.button_mouseleave);

            btn_Defect.MouseEnter += new System.EventHandler(this.button_mousehover);
            btn_Defect.MouseLeave += new System.EventHandler(this.button_mouseleave);

            btn_Build.MouseEnter += new System.EventHandler(this.button_mousehover);
            btn_Build.MouseLeave += new System.EventHandler(this.button_mouseleave);

            btn_Bin.MouseEnter += new System.EventHandler(this.button_mousehover);
            btn_Bin.MouseLeave += new System.EventHandler(this.button_mouseleave);

            btn_Create.MouseEnter += new System.EventHandler(this.button_mousehover);
            btn_Create.MouseLeave += new System.EventHandler(this.button_mouseleave);

            button2.MouseEnter += new System.EventHandler(this.button_mousehover);
            button2.MouseLeave += new System.EventHandler(this.button_mouseleave);
        }

        // //////////////////////////////////////////////////////////
        //                  Side Button Events
        // //////////////////////////////////////////////////////////
        private void button_mousehover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(41, 58, 70);
            btn.ForeColor = Color.Chocolate;
        }

        private void button_mouseleave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(41, 53, 65);
            btn.ForeColor = Color.LightGray;
        }

        // //////////////////////////////////////////////////////////
        //                  Header Button Events
        // //////////////////////////////////////////////////////////
        private void buttonHome_mousehover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.LightGray;
        }
        private void buttonHome_mouseleave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.White;
        }

        // //////////////////////////////////////////////////////////
        //                  Exit and Minimize
        // //////////////////////////////////////////////////////////
        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lbl_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // //////////////////////////////////////////////////////////
        //                  Logic Handling
        // //////////////////////////////////////////////////////////

        private bool LoadConnectionString()
        {
            bool connected = false;
            _sql = new SQL();
            try
            {
                _sql.TestConnection();
                lbl_Status.Text = "Connection to Server Successful";
                lbl_Status.ForeColor = Color.Green;
                connected = true;
                btn_ScaleAndRate.Enabled = true;
                btn_Defect.Enabled = true;
                btn_Build.Enabled = true;
                btn_Bin.Enabled = true;
            }
            catch (Exception)
            {
                lbl_Status.Text = "No connection to server. Check App.Config Connection String. Buttons will be disabled...";
                lbl_Status.ForeColor = Color.Red;
                btn_ScaleAndRate.Enabled = false;
                btn_Defect.Enabled = false;
                btn_Build.Enabled = false;
                btn_Bin.Enabled = false;
            }
            return connected;
        }

        private void OpenHomeWindow()
        {
            CheckForChildWindow();
            HomeWindow child = new HomeWindow();
            child.MdiParent = this;
            child.Show();
            lbl_Title.Text = "Home";
        }

        // //////////////////////////////////////////////////////////
        //                  Button Click Events
        // //////////////////////////////////////////////////////////
        private void btn_ScaleAndRate_Click(object sender, EventArgs e)
        {
            CheckForChildWindow();
            TimeAndScale child = new TimeAndScale();
            child.MdiParent = this;
            child.Show();
            lbl_Title.Text = "Time and Scale";
        }

        private void btn_Defect_Click(object sender, EventArgs e)
        {
            CheckForChildWindow();
            DefectWindow child = new DefectWindow();
            child.MdiParent = this;
            child.Show();
            lbl_Title.Text = "Defect Rate";
        }

        private void btn_Build_Click(object sender, EventArgs e)
        {
            CheckForChildWindow();
            BuildWindow child = new BuildWindow();
            child.MdiParent = this;
            child.Show();
            lbl_Title.Text = "Build Rate";
        }

        private void btn_Bin_Click(object sender, EventArgs e)
        {
            CheckForChildWindow();
            BinWindow child = new BinWindow();
            child.MdiParent = this;
            child.Show();
            lbl_Title.Text = "Bin Capacity";
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            CheckForChildWindow();
            HomeWindow child = new HomeWindow();
            child.MdiParent = this;
            child.Show();
            lbl_Title.Text = "Home";
        }

        private void CheckForChildWindow()
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            _sql = new SQL();
            try
            {
                _sql.CreateConfigTable();
                if (LoadConnectionString())
                {
                    OpenHomeWindow();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
