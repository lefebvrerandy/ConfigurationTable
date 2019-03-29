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
    public partial class TimeAndScale : Form
    {
        SQL _sql;
        List<Control> textBoxList;
        public TimeAndScale()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            SetUpTextBoxes();
            SetUpHelpBoxes();
            SetUpToolTip();
            textBoxList = GetTextBoxes();
        }

        private void SetUpTextBoxes()
        {
            _sql = new SQL();
            // Get value for time scale
            // store current value for time scale in text box
            ReloadTimeScale();

            // Get value for refill rate
            // store current value for refill rate in text box
            ReloadRefillRate();
        }

        private void SetUpHelpBoxes()
        {
            btn_Time_Help.FlatStyle = FlatStyle.Flat;
            btn_Time_Help.BackColor = Color.White;
            btn_Time_Help.FlatAppearance.BorderSize = 0;

            btn_Refill_Help.FlatStyle = FlatStyle.Flat;
            btn_Refill_Help.BackColor = Color.White;
            btn_Refill_Help.FlatAppearance.BorderSize = 0;
        }

        // Event for time scale
        // check for change from default value
        // check for range (validation)
        // if valid - update database with the new value
        // if not valid - reset current value back in the text box and display an error

        // Event for refill rate
        // check for change from default value
        // check for range (validation)
        // if valid - update database with the new value
        // if not valid - reset current value back in the text box and display an error

        // Validation method for time scale
        // keep the range between 0.1 and 10.0
        // return validation

        // Validation method for refill rate
        // keep the range between 0.1 and 10.0
        // return validation



        private void SetUpToolTip()
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(this.btn_Time_Help, ConfigurationManager.AppSettings["timeScaleToolTip"].ToString());
            tp.SetToolTip(this.btn_Refill_Help, ConfigurationManager.AppSettings["refillToolTip"].ToString());
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
                    if ((txtNumber >= 0.1) && (txtNumber <= 100.0))
                    {
                        if (c.Name == "txt_Time")
                        {
                            _sql.StoreData("TimeScale", txt_Time.Text);
                        }
                        else if (c.Name == "txt_Refill")
                        {
                            _sql.StoreData("RefillRate", txt_Refill.Text);
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
            ReloadTimeScale();
            ReloadRefillRate();
        }

        private void ReloadTimeScale()
        {
            _sql = new SQL();
            // Get value for time scale
            string timeScale = _sql.GetData("TimeScale");

            // store current value for time scale in text box
            lbl_Time.Text = timeScale;
        }

        private void ReloadRefillRate()
        {
            _sql = new SQL();
            // Get value for refill rate
            string refillRate = _sql.GetData("RefillRate");

            // store current value for refill rate in text box
            lbl_Refill.Text = refillRate;
        }
    }
}
