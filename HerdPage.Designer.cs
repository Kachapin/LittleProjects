namespace Farm
{
    partial class HerdPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.AddCow = new System.Windows.Forms.Button();
            this.addTable1 = new Farm.AddTable();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.AddCow);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 701);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Cow";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AddCow
            // 
            this.AddCow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.AddCow.FlatAppearance.BorderSize = 0;
            this.AddCow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCow.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddCow.ForeColor = System.Drawing.Color.White;
            this.AddCow.Location = new System.Drawing.Point(0, 0);
            this.AddCow.Name = "AddCow";
            this.AddCow.Size = new System.Drawing.Size(190, 55);
            this.AddCow.TabIndex = 0;
            this.AddCow.Text = "Add Cow";
            this.AddCow.UseVisualStyleBackColor = false;
            this.AddCow.Click += new System.EventHandler(this.button1_Click);
            // 
            // addTable1
            // 
            this.addTable1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.addTable1.Location = new System.Drawing.Point(190, 0);
            this.addTable1.Name = "addTable1";
            this.addTable1.Size = new System.Drawing.Size(863, 701);
            this.addTable1.TabIndex = 1;
            this.addTable1.Load += new System.EventHandler(this.addTable1_Load);
            // 
            // HerdPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addTable1);
            this.Controls.Add(this.panel1);
            this.Name = "HerdPage";
            this.Size = new System.Drawing.Size(1065, 683);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button AddCow;
        private Button button1;
        private AddTable addTable1;
    }
}
