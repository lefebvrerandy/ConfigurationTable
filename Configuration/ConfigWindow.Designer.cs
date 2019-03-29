namespace Configuration
{
    partial class ConfigWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btn_Bin = new System.Windows.Forms.Button();
            this.btn_Build = new System.Windows.Forms.Button();
            this.btn_Defect = new System.Windows.Forms.Button();
            this.btn_ScaleAndRate = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Home = new System.Windows.Forms.Button();
            this.lbl_Minimize = new System.Windows.Forms.Label();
            this.lbl_Exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.divider = new System.Windows.Forms.Label();
            this.sidePanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.sidePanel.Controls.Add(this.divider);
            this.sidePanel.Controls.Add(this.button2);
            this.sidePanel.Controls.Add(this.btn_Create);
            this.sidePanel.Controls.Add(this.btn_Bin);
            this.sidePanel.Controls.Add(this.btn_Build);
            this.sidePanel.Controls.Add(this.btn_Defect);
            this.sidePanel.Controls.Add(this.btn_ScaleAndRate);
            this.sidePanel.Controls.Add(this.logoPanel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(175, 450);
            this.sidePanel.TabIndex = 0;
            // 
            // btn_Bin
            // 
            this.btn_Bin.Location = new System.Drawing.Point(0, 199);
            this.btn_Bin.Name = "btn_Bin";
            this.btn_Bin.Size = new System.Drawing.Size(175, 53);
            this.btn_Bin.TabIndex = 3;
            this.btn_Bin.Text = "Bin Capacity";
            this.btn_Bin.UseVisualStyleBackColor = true;
            this.btn_Bin.Click += new System.EventHandler(this.btn_Bin_Click);
            // 
            // btn_Build
            // 
            this.btn_Build.Location = new System.Drawing.Point(0, 153);
            this.btn_Build.Name = "btn_Build";
            this.btn_Build.Size = new System.Drawing.Size(175, 53);
            this.btn_Build.TabIndex = 2;
            this.btn_Build.Text = "Build Rate";
            this.btn_Build.UseVisualStyleBackColor = true;
            this.btn_Build.Click += new System.EventHandler(this.btn_Build_Click);
            // 
            // btn_Defect
            // 
            this.btn_Defect.Location = new System.Drawing.Point(0, 104);
            this.btn_Defect.Name = "btn_Defect";
            this.btn_Defect.Size = new System.Drawing.Size(175, 53);
            this.btn_Defect.TabIndex = 2;
            this.btn_Defect.Text = "Defect Rate";
            this.btn_Defect.UseVisualStyleBackColor = true;
            this.btn_Defect.Click += new System.EventHandler(this.btn_Defect_Click);
            // 
            // btn_ScaleAndRate
            // 
            this.btn_ScaleAndRate.Location = new System.Drawing.Point(0, 57);
            this.btn_ScaleAndRate.Name = "btn_ScaleAndRate";
            this.btn_ScaleAndRate.Size = new System.Drawing.Size(175, 53);
            this.btn_ScaleAndRate.TabIndex = 1;
            this.btn_ScaleAndRate.Text = "Scale and Rates";
            this.btn_ScaleAndRate.UseVisualStyleBackColor = true;
            this.btn_ScaleAndRate.Click += new System.EventHandler(this.btn_ScaleAndRate_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.Chocolate;
            this.logoPanel.Controls.Add(this.label1);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(175, 51);
            this.logoPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kanban Configuration Editor";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.lbl_Title);
            this.headerPanel.Controls.Add(this.btn_Home);
            this.headerPanel.Controls.Add(this.lbl_Minimize);
            this.headerPanel.Controls.Add(this.lbl_Exit);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(175, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(625, 51);
            this.headerPanel.TabIndex = 1;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.White;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Title.Location = new System.Drawing.Point(79, 17);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(56, 20);
            this.lbl_Title.TabIndex = 4;
            this.lbl_Title.Text = "Home";
            this.lbl_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.lbl_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.lbl_Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.Transparent;
            this.btn_Home.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Home.Image = global::Configuration.Properties.Resources.home;
            this.btn_Home.Location = new System.Drawing.Point(6, 1);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(43, 45);
            this.btn_Home.TabIndex = 3;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // lbl_Minimize
            // 
            this.lbl_Minimize.AutoSize = true;
            this.lbl_Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Minimize.Location = new System.Drawing.Point(574, 15);
            this.lbl_Minimize.Name = "lbl_Minimize";
            this.lbl_Minimize.Size = new System.Drawing.Size(16, 16);
            this.lbl_Minimize.TabIndex = 1;
            this.lbl_Minimize.Text = "_";
            this.lbl_Minimize.Click += new System.EventHandler(this.lbl_Minimize_Click);
            // 
            // lbl_Exit
            // 
            this.lbl_Exit.AutoSize = true;
            this.lbl_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Exit.Location = new System.Drawing.Point(593, 17);
            this.lbl_Exit.Name = "lbl_Exit";
            this.lbl_Exit.Size = new System.Drawing.Size(17, 16);
            this.lbl_Exit.TabIndex = 0;
            this.lbl_Exit.Text = "X";
            this.lbl_Exit.Click += new System.EventHandler(this.lbl_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_Status);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(175, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 26);
            this.panel1.TabIndex = 2;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(6, 8);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(35, 13);
            this.lbl_Status.TabIndex = 0;
            this.lbl_Status.Text = "label2";
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(0, 424);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(89, 26);
            this.btn_Create.TabIndex = 4;
            this.btn_Create.Text = "Create Config";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "PlaceHolder";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // divider
            // 
            this.divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider.Location = new System.Drawing.Point(0, 422);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(175, 2);
            this.divider.TabIndex = 6;
            // 
            // ConfigWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "ConfigWindow";
            this.Text = "Form1";
            this.sidePanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btn_ScaleAndRate;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button btn_Build;
        private System.Windows.Forms.Button btn_Defect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Minimize;
        private System.Windows.Forms.Label lbl_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Button btn_Bin;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Label divider;
    }
}

