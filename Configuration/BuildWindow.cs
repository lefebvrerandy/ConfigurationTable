using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Configuration
{
    public partial class BuildWindow : Form
    {
        SQL _sql;
        List<Control> textBoxList;
        public BuildWindow()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            SetUpTextBoxes();
            SetUpHelpBoxes();
            SetUpToolTip();
            textBoxList = GetTextBoxes();
        }

        private void SetUpToolTip()
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(this.btn_Rookie_Help, ConfigurationManager.AppSettings["rookieBuildToolTip"].ToString());
            tp.SetToolTip(this.btn_Normal_Help, ConfigurationManager.AppSettings["normalBuildToolTip"].ToString());
            tp.SetToolTip(this.btn_Super_Help, ConfigurationManager.AppSettings["superBuildToolTip"].ToString());
        }

        private void SetUpTextBoxes()
        {
            _sql = new SQL();
            // Get value for rookie
            // store current value for rookie in text box
            ReloadRookie();

            // Get value for normal
            // store current value for normal in text box
            ReloadNormal();

            // Get value for super
            // store current value for super in text box
            ReloadSuper();
        }

        private void SetUpHelpBoxes()
        {
            btn_Rookie_Help.FlatStyle = FlatStyle.Flat;
            btn_Rookie_Help.BackColor = Color.White;
            btn_Rookie_Help.FlatAppearance.BorderSize = 0;

            btn_Normal_Help.FlatStyle = FlatStyle.Flat;
            btn_Normal_Help.BackColor = Color.White;
            btn_Normal_Help.FlatAppearance.BorderSize = 0;

            btn_Super_Help.FlatStyle = FlatStyle.Flat;
            btn_Super_Help.BackColor = Color.White;
            btn_Super_Help.FlatAppearance.BorderSize = 0;
        }

        public List<Control> GetTextBoxes()
        {
            var textBoxes = new List<Control>();
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    textBoxes.Add(c);
                }
            }
            return textBoxes;
        }

        private void btn_Store_Click(object sender, EventArgs e)
        {
            _sql = new SQL();
            bool somethingChanged = false;
            foreach (Control c in textBoxList)
            {
                Double.TryParse(c.Text, out double txtNumber);
                // Check that the text box isnt empty
                if (c.Text != "")
                {
                    if ((txtNumber >= 0.1) && (txtNumber <= 2.0))
                    {
                        if (c.Name == "txt_Rookie")
                        {
                            double converted = Double.Parse(txt_Rookie.Text) / 100;
                            _sql.StoreData("RookieBuildRate", converted.ToString());
                        }
                        else if (c.Name == "txt_Normal")
                        {
                            double converted = Double.Parse(txt_Normal.Text) / 100;
                            _sql.StoreData("NormalBuildRate", converted.ToString());
                        }
                        else if (c.Name == "txt_Super")
                        {
                            double converted = Double.Parse(txt_Super.Text) / 100;
                            _sql.StoreData("SuperBuildRate", converted.ToString());
                        }
                        somethingChanged = true;
                    }
                }
            }
            if (somethingChanged)
            {
                ReloadData();
            }
        }

        private void ReloadData()
        {
            ReloadRookie();
            ReloadNormal();
            ReloadSuper();
        }

        private void ReloadRookie()
        {
            _sql = new SQL();
            // Get value for rookie
            string rookie = _sql.GetData("RookieBuildRate");
            double rookieFinal = Double.Parse(rookie) * 100;

            // store current value for rookie in text box
            lbl_Rookie.Text = rookieFinal.ToString() + "%";
        }

        private void ReloadNormal()
        {
            _sql = new SQL();
            // Get value for normal
            string normal = _sql.GetData("NormalBuildRate");
            double normalFinal = Double.Parse(normal) * 100;

            // store current value for normal in text box
            lbl_Normal.Text = normalFinal.ToString() + "%";
        }

        private void ReloadSuper()
        {
            _sql = new SQL();
            // Get value for super
            string super = _sql.GetData("SuperBuildRate");
            double superFinal = Double.Parse(super) * 100;

            // store current value for super in text box
            lbl_Super.Text = superFinal.ToString() + "%";
        }
    }
}
