namespace Configuration
{
    partial class TimeAndScale
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
            this.components = new System.ComponentModel.Container();
            this.fog_Light_KanbanDataSet = new Configuration.Fog_Light_KanbanDataSet();
            this.configurationTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.configuration_TableTableAdapter = new Configuration.Fog_Light_KanbanDataSetTableAdapters.Configuration_TableTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Time = new System.Windows.Forms.TextBox();
            this.txt_Refill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Refill_Help = new System.Windows.Forms.Button();
            this.btn_Time_Help = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Refill = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.btn_Store = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fog_Light_KanbanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fog_Light_KanbanDataSet
            // 
            this.fog_Light_KanbanDataSet.DataSetName = "Fog_Light_KanbanDataSet";
            this.fog_Light_KanbanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // configurationTableBindingSource
            // 
            this.configurationTableBindingSource.DataMember = "Configuration_Table";
            this.configurationTableBindingSource.DataSource = this.fog_Light_KanbanDataSet;
            // 
            // configuration_TableTableAdapter
            // 
            this.configuration_TableTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Scale";
            // 
            // txt_Time
            // 
            this.txt_Time.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_Time.Location = new System.Drawing.Point(79, 10);
            this.txt_Time.Name = "txt_Time";
            this.txt_Time.Size = new System.Drawing.Size(100, 20);
            this.txt_Time.TabIndex = 1;
            // 
            // txt_Refill
            // 
            this.txt_Refill.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_Refill.Location = new System.Drawing.Point(79, 36);
            this.txt_Refill.Name = "txt_Refill";
            this.txt_Refill.Size = new System.Drawing.Size(100, 20);
            this.txt_Refill.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Refill Rate";
            // 
            // MyToolTip
            // 
            this.MyToolTip.AutoPopDelay = 5000;
            this.MyToolTip.InitialDelay = 500;
            this.MyToolTip.ReshowDelay = 100;
            // 
            // btn_Refill_Help
            // 
            this.btn_Refill_Help.Image = global::Configuration.Properties.Resources.help;
            this.btn_Refill_Help.Location = new System.Drawing.Point(185, 35);
            this.btn_Refill_Help.Name = "btn_Refill_Help";
            this.btn_Refill_Help.Size = new System.Drawing.Size(22, 22);
            this.btn_Refill_Help.TabIndex = 5;
            this.btn_Refill_Help.UseVisualStyleBackColor = true;
            // 
            // btn_Time_Help
            // 
            this.btn_Time_Help.Image = global::Configuration.Properties.Resources.help;
            this.btn_Time_Help.Location = new System.Drawing.Point(185, 9);
            this.btn_Time_Help.Name = "btn_Time_Help";
            this.btn_Time_Help.Size = new System.Drawing.Size(22, 22);
            this.btn_Time_Help.TabIndex = 4;
            this.btn_Time_Help.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Currently set to: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Currently set to: ";
            // 
            // lbl_Refill
            // 
            this.lbl_Refill.AutoSize = true;
            this.lbl_Refill.Location = new System.Drawing.Point(289, 39);
            this.lbl_Refill.Name = "lbl_Refill";
            this.lbl_Refill.Size = new System.Drawing.Size(41, 13);
            this.lbl_Refill.TabIndex = 58;
            this.lbl_Refill.Text = "label13";
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Location = new System.Drawing.Point(289, 13);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(41, 13);
            this.lbl_Time.TabIndex = 57;
            this.lbl_Time.Text = "label13";
            // 
            // btn_Store
            // 
            this.btn_Store.Location = new System.Drawing.Point(79, 63);
            this.btn_Store.Name = "btn_Store";
            this.btn_Store.Size = new System.Drawing.Size(75, 23);
            this.btn_Store.TabIndex = 59;
            this.btn_Store.Text = "Store";
            this.btn_Store.UseVisualStyleBackColor = true;
            this.btn_Store.Click += new System.EventHandler(this.btn_Store_Click);
            // 
            // TimeAndScale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 369);
            this.Controls.Add(this.btn_Store);
            this.Controls.Add(this.lbl_Refill);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Refill_Help);
            this.Controls.Add(this.btn_Time_Help);
            this.Controls.Add(this.txt_Refill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Time);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimeAndScale";
            this.Text = "TimeAndScale";
            ((System.ComponentModel.ISupportInitialize)(this.fog_Light_KanbanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Fog_Light_KanbanDataSet fog_Light_KanbanDataSet;
        private System.Windows.Forms.BindingSource configurationTableBindingSource;
        private Fog_Light_KanbanDataSetTableAdapters.Configuration_TableTableAdapter configuration_TableTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Time;
        private System.Windows.Forms.TextBox txt_Refill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Time_Help;
        private System.Windows.Forms.Button btn_Refill_Help;
        private System.Windows.Forms.ToolTip MyToolTip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Refill;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Button btn_Store;
    }
}