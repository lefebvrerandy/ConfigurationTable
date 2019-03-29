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
    public partial class BinWindow : Form
    {
        SQL _sql;
        List<Control> textBoxList;
        public BinWindow()
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
            tp.SetToolTip(this.btn_Harness_Help, ConfigurationManager.AppSettings["binHarnessToolTip"].ToString());
            tp.SetToolTip(this.btn_Reflector_Help, ConfigurationManager.AppSettings["binReflectorToolTip"].ToString());
            tp.SetToolTip(this.btn_Housing_Help, ConfigurationManager.AppSettings["binHousingToolTip"].ToString());
            tp.SetToolTip(this.btn_Lens_Help, ConfigurationManager.AppSettings["binLensToolTip"].ToString());
            tp.SetToolTip(this.btn_Bulb_Help, ConfigurationManager.AppSettings["binBulbToolTip"].ToString());
            tp.SetToolTip(this.btn_Bezel_Help, ConfigurationManager.AppSettings["binBezelToolTip"].ToString());
        }

        private void SetUpTextBoxes()
        {
            _sql = new SQL();
            // Get value for harness
            // store current value for harness in text box
            ReloadHarness();

            // Get value for reflector
            // store current value for reflector in text box
            ReloadReflector();

            // Get value for Housing
            // store current value for housing in text box
            ReloadHousing();

            // Get value for Lens
            // store current value for lens in text box
            ReloadLens();

            // Get value for bulb
            // store current value for bulb in text box
            ReloadBulb();

            // Get value for bezel
            // store current value for bezel in text box
            ReloadBezel();
        }

        private void SetUpHelpBoxes()
        {
            btn_Harness_Help.FlatStyle = FlatStyle.Flat;
            btn_Harness_Help.BackColor = Color.White;
            btn_Harness_Help.FlatAppearance.BorderSize = 0;

            btn_Reflector_Help.FlatStyle = FlatStyle.Flat;
            btn_Reflector_Help.BackColor = Color.White;
            btn_Reflector_Help.FlatAppearance.BorderSize = 0;

            btn_Housing_Help.FlatStyle = FlatStyle.Flat;
            btn_Housing_Help.BackColor = Color.White;
            btn_Housing_Help.FlatAppearance.BorderSize = 0;

            btn_Lens_Help.FlatStyle = FlatStyle.Flat;
            btn_Lens_Help.BackColor = Color.White;
            btn_Lens_Help.FlatAppearance.BorderSize = 0;

            btn_Bulb_Help.FlatStyle = FlatStyle.Flat;
            btn_Bulb_Help.BackColor = Color.White;
            btn_Bulb_Help.FlatAppearance.BorderSize = 0;

            btn_Bezel_Help.FlatStyle = FlatStyle.Flat;
            btn_Bezel_Help.BackColor = Color.White;
            btn_Bezel_Help.FlatAppearance.BorderSize = 0;
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
                    if ((txtNumber >= 1) && (txtNumber <= 100.0))
                    {
                        if (c.Name == "txt_Harness")
                        {
                            _sql.StoreData("BinHarness", txt_Harness.Text);
                        }
                        else if (c.Name == "txt_Reflector")
                        {
                            _sql.StoreData("BinReflector", txt_Reflector.Text);
                        }
                        else if (c.Name == "txt_Housing")
                        {
                            _sql.StoreData("BinHousing", txt_Housing.Text);
                        }
                        else if (c.Name == "txt_Lens")
                        {
                            _sql.StoreData("BinLens", txt_Lens.Text);
                        }
                        else if (c.Name == "txt_Bulb")
                        {
                            _sql.StoreData("BinBulb", txt_Bulb.Text);
                        }
                        else if (c.Name == "txt_Bezel")
                        {
                            _sql.StoreData("BinBezel", txt_Bezel.Text);
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
            ReloadHarness();
            ReloadReflector();
            ReloadHousing();
            ReloadLens();
            ReloadBulb();
            ReloadBezel();
        }

        private void ReloadHarness()
        {
            _sql = new SQL();
            // Get value for time scale
            string harness = _sql.GetData("BinHarness");

            // store current value for time scale in text box
            lbl_Harness.Text = harness;
        }

        private void ReloadReflector()
        {
            _sql = new SQL();
            // Get value for refill rate
            string reflector = _sql.GetData("BinReflector");

            // store current value for refill rate in text box
            lbl_Reflector.Text = reflector;
        }

        private void ReloadHousing()
        {
            _sql = new SQL();
            // Get value for time scale
            string housing = _sql.GetData("BinHousing");

            // store current value for time scale in text box
            lbl_Housing.Text = housing;
        }

        private void ReloadLens()
        {
            _sql = new SQL();
            // Get value for refill rate
            string lens = _sql.GetData("BinLens");

            // store current value for refill rate in text box
            lbl_Lens.Text = lens;
        }

        private void ReloadBulb()
        {
            _sql = new SQL();
            // Get value for time scale
            string bulb = _sql.GetData("BinBulb");

            // store current value for time scale in text box
            lbl_Bulb.Text = bulb;
        }

        private void ReloadBezel()
        {
            _sql = new SQL();
            // Get value for refill rate
            string bezel = _sql.GetData("BinBezel");

            // store current value for refill rate in text box
            lbl_Bezel.Text = bezel;
        }
    }
}
