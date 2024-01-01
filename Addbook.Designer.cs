namespace OOPFinalProject_1
{
    partial class Addbook
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radnonfiction = new System.Windows.Forms.RadioButton();
            this.radfiction = new System.Windows.Forms.RadioButton();
            this.radacad = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbookname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtauthor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtisbn = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtpublisher = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtcopyright = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radreserve = new System.Windows.Forms.RadioButton();
            this.radreturned = new System.Windows.Forms.RadioButton();
            this.radborrowed = new System.Windows.Forms.RadioButton();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 43);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(442, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add Book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Book name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Author:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radnonfiction);
            this.groupBox1.Controls.Add(this.radfiction);
            this.groupBox1.Controls.Add(this.radacad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 63);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category:";
            // 
            // radnonfiction
            // 
            this.radnonfiction.AutoSize = true;
            this.radnonfiction.Location = new System.Drawing.Point(284, 27);
            this.radnonfiction.Name = "radnonfiction";
            this.radnonfiction.Size = new System.Drawing.Size(144, 26);
            this.radnonfiction.TabIndex = 2;
            this.radnonfiction.TabStop = true;
            this.radnonfiction.Text = "Non-fictional";
            this.radnonfiction.UseVisualStyleBackColor = true;
            // 
            // radfiction
            // 
            this.radfiction.AutoSize = true;
            this.radfiction.Location = new System.Drawing.Point(152, 27);
            this.radfiction.Name = "radfiction";
            this.radfiction.Size = new System.Drawing.Size(107, 26);
            this.radfiction.TabIndex = 1;
            this.radfiction.TabStop = true;
            this.radfiction.Text = "Fictional";
            this.radfiction.UseVisualStyleBackColor = true;
            // 
            // radacad
            // 
            this.radacad.AutoSize = true;
            this.radacad.Checked = true;
            this.radacad.Location = new System.Drawing.Point(6, 27);
            this.radacad.Name = "radacad";
            this.radacad.Size = new System.Drawing.Size(117, 26);
            this.radacad.TabIndex = 0;
            this.radacad.TabStop = true;
            this.radacad.Text = "Academic";
            this.radacad.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "ISBN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Publisher:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Copy right:";
            // 
            // txtbookname
            // 
            this.txtbookname.AutoRoundedCorners = true;
            this.txtbookname.BorderRadius = 11;
            this.txtbookname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbookname.DefaultText = "";
            this.txtbookname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbookname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbookname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbookname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbookname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbookname.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtbookname.ForeColor = System.Drawing.Color.Black;
            this.txtbookname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbookname.Location = new System.Drawing.Point(164, 64);
            this.txtbookname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.PasswordChar = '\0';
            this.txtbookname.PlaceholderText = "";
            this.txtbookname.SelectedText = "";
            this.txtbookname.Size = new System.Drawing.Size(640, 25);
            this.txtbookname.TabIndex = 11;
            // 
            // txtauthor
            // 
            this.txtauthor.AutoRoundedCorners = true;
            this.txtauthor.BorderRadius = 11;
            this.txtauthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtauthor.DefaultText = "";
            this.txtauthor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtauthor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtauthor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtauthor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtauthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtauthor.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtauthor.ForeColor = System.Drawing.Color.Black;
            this.txtauthor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtauthor.Location = new System.Drawing.Point(164, 97);
            this.txtauthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtauthor.Name = "txtauthor";
            this.txtauthor.PasswordChar = '\0';
            this.txtauthor.PlaceholderText = "";
            this.txtauthor.SelectedText = "";
            this.txtauthor.Size = new System.Drawing.Size(640, 25);
            this.txtauthor.TabIndex = 12;
            // 
            // txtisbn
            // 
            this.txtisbn.AutoRoundedCorners = true;
            this.txtisbn.BorderRadius = 11;
            this.txtisbn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtisbn.DefaultText = "";
            this.txtisbn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtisbn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtisbn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtisbn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtisbn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtisbn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtisbn.ForeColor = System.Drawing.Color.Black;
            this.txtisbn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtisbn.Location = new System.Drawing.Point(164, 129);
            this.txtisbn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtisbn.Name = "txtisbn";
            this.txtisbn.PasswordChar = '\0';
            this.txtisbn.PlaceholderText = "";
            this.txtisbn.SelectedText = "";
            this.txtisbn.Size = new System.Drawing.Size(640, 25);
            this.txtisbn.TabIndex = 13;
            // 
            // txtpublisher
            // 
            this.txtpublisher.AutoRoundedCorners = true;
            this.txtpublisher.BorderRadius = 11;
            this.txtpublisher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpublisher.DefaultText = "";
            this.txtpublisher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpublisher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpublisher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpublisher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpublisher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpublisher.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtpublisher.ForeColor = System.Drawing.Color.Black;
            this.txtpublisher.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpublisher.Location = new System.Drawing.Point(164, 160);
            this.txtpublisher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpublisher.Name = "txtpublisher";
            this.txtpublisher.PasswordChar = '\0';
            this.txtpublisher.PlaceholderText = "";
            this.txtpublisher.SelectedText = "";
            this.txtpublisher.Size = new System.Drawing.Size(640, 25);
            this.txtpublisher.TabIndex = 14;
            // 
            // txtcopyright
            // 
            this.txtcopyright.AutoRoundedCorners = true;
            this.txtcopyright.BorderRadius = 11;
            this.txtcopyright.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcopyright.DefaultText = "";
            this.txtcopyright.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcopyright.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcopyright.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcopyright.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcopyright.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcopyright.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtcopyright.ForeColor = System.Drawing.Color.Black;
            this.txtcopyright.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcopyright.Location = new System.Drawing.Point(164, 191);
            this.txtcopyright.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcopyright.Name = "txtcopyright";
            this.txtcopyright.PasswordChar = '\0';
            this.txtcopyright.PlaceholderText = "";
            this.txtcopyright.SelectedText = "";
            this.txtcopyright.Size = new System.Drawing.Size(640, 25);
            this.txtcopyright.TabIndex = 15;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 14;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Gray;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(877, 80);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(95, 30);
            this.guna2Button1.TabIndex = 16;
            this.guna2Button1.Text = "Add";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radreserve);
            this.groupBox2.Controls.Add(this.radreturned);
            this.groupBox2.Controls.Add(this.radborrowed);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 63);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status:";
            // 
            // radreserve
            // 
            this.radreserve.AutoSize = true;
            this.radreserve.Location = new System.Drawing.Point(303, 27);
            this.radreserve.Name = "radreserve";
            this.radreserve.Size = new System.Drawing.Size(105, 26);
            this.radreserve.TabIndex = 2;
            this.radreserve.TabStop = true;
            this.radreserve.Text = "Reserve";
            this.radreserve.UseVisualStyleBackColor = true;
            // 
            // radreturned
            // 
            this.radreturned.AutoSize = true;
            this.radreturned.Checked = true;
            this.radreturned.Location = new System.Drawing.Point(6, 27);
            this.radreturned.Name = "radreturned";
            this.radreturned.Size = new System.Drawing.Size(113, 26);
            this.radreturned.TabIndex = 1;
            this.radreturned.TabStop = true;
            this.radreturned.Text = "Returned";
            this.radreturned.UseVisualStyleBackColor = true;
            // 
            // radborrowed
            // 
            this.radborrowed.AutoSize = true;
            this.radborrowed.Location = new System.Drawing.Point(152, 27);
            this.radborrowed.Name = "radborrowed";
            this.radborrowed.Size = new System.Drawing.Size(116, 26);
            this.radborrowed.TabIndex = 0;
            this.radborrowed.Text = "Borrowed";
            this.radborrowed.UseVisualStyleBackColor = true;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 14;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Gray;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(877, 119);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(95, 30);
            this.guna2Button2.TabIndex = 18;
            this.guna2Button2.Text = "Clear";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 14;
            this.guna2Button3.BorderThickness = 1;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Gray;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(877, 158);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(95, 30);
            this.guna2Button3.TabIndex = 19;
            this.guna2Button3.Text = "Close";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // Addbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 425);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txtcopyright);
            this.Controls.Add(this.txtpublisher);
            this.Controls.Add(this.txtisbn);
            this.Controls.Add(this.txtauthor);
            this.Controls.Add(this.txtbookname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Addbook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Addbook";
            this.Load += new System.EventHandler(this.Addbook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radnonfiction;
        private System.Windows.Forms.RadioButton radfiction;
        private System.Windows.Forms.RadioButton radacad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtbookname;
        private Guna.UI2.WinForms.Guna2TextBox txtauthor;
        private Guna.UI2.WinForms.Guna2TextBox txtisbn;
        private Guna.UI2.WinForms.Guna2TextBox txtpublisher;
        private Guna.UI2.WinForms.Guna2TextBox txtcopyright;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radreserve;
        private System.Windows.Forms.RadioButton radreturned;
        private System.Windows.Forms.RadioButton radborrowed;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}