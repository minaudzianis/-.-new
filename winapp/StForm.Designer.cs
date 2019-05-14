namespace winapp
{
    partial class StForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StForm));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.TButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Snow;
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Items.AddRange(new object[] {
            "название файла 1",
            "название файла 2",
            "название файла 3",
            "название файла 4",
            "название файла 5",
            "название файла 6",
            "название файла 7",
            "название файла 8",
            "название файла 9",
            "название файла 10",
            "название файла 11",
            "название файла 12"});
            this.listBox1.Location = new System.Drawing.Point(11, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(330, 175);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.LightGreen;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Swis721 Ex BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(350, 13);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(55, 55);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Visible = false;
            this.AddButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // DelButton
            // 
            this.DelButton.BackColor = System.Drawing.Color.LightPink;
            this.DelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelButton.FlatAppearance.BorderSize = 0;
            this.DelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleVioletRed;
            this.DelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.DelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelButton.Font = new System.Drawing.Font("Swis721 Ex BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.DelButton.Location = new System.Drawing.Point(350, 131);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(55, 55);
            this.DelButton.TabIndex = 17;
            this.DelButton.Text = "🛇";
            this.DelButton.UseVisualStyleBackColor = false;
            this.DelButton.Visible = false;
            this.DelButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Lavender;
            this.EditButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue;
            this.EditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Swis721 Ex BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.EditButton.Location = new System.Drawing.Point(350, 72);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(55, 55);
            this.EditButton.TabIndex = 18;
            this.EditButton.Text = "✎";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Visible = false;
            this.EditButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Swis721 Ex BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(50, 261);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(250, 40);
            this.BackButton.TabIndex = 19;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TButton
            // 
            this.TButton.BackColor = System.Drawing.Color.Snow;
            this.TButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TButton.FlatAppearance.BorderSize = 0;
            this.TButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Snow;
            this.TButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Snow;
            this.TButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TButton.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.TButton.Location = new System.Drawing.Point(274, 184);
            this.TButton.Name = "TButton";
            this.TButton.Size = new System.Drawing.Size(28, 27);
            this.TButton.TabIndex = 20;
            this.TButton.Text = "✎";
            this.TButton.UseVisualStyleBackColor = false;
            this.TButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // StForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(350, 313);
            this.ControlBox = false;
            this.Controls.Add(this.TButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Материалы для обучения";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.Button AddButton;
        public System.Windows.Forms.Button DelButton;
        public System.Windows.Forms.Button EditButton;
        public System.Windows.Forms.Button BackButton;
        public System.Windows.Forms.Button TButton;
    }
}