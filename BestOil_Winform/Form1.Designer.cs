namespace BestOil_Winform
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFuelPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbFuel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAzn = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLiter = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbAzn = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbLiter = new Guna.UI2.WinForms.Guna2RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFuelAmount = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudSpriteCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtSpritePrice = new System.Windows.Forms.TextBox();
            this.cbSprite = new Guna.UI2.WinForms.Guna2CheckBox();
            this.nudCocaColaCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtCocaColaPrice = new System.Windows.Forms.TextBox();
            this.cbCocaCola = new Guna.UI2.WinForms.Guna2CheckBox();
            this.nudGamburgerCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtGamburgerPrice = new System.Windows.Forms.TextBox();
            this.cbGamburger = new Guna.UI2.WinForms.Guna2CheckBox();
            this.nudHotDogCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtHotDogPrice = new System.Windows.Forms.TextBox();
            this.cbHotDog = new Guna.UI2.WinForms.Guna2CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFoodAmount = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnPayAmount = new Guna.UI2.WinForms.Guna2Button();
            this.pbFuel = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpriteCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCocaColaCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGamburgerCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHotDogCount)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuel)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFuelPrice);
            this.groupBox1.Controls.Add(this.cmbFuel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAzn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLiter);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox1.Location = new System.Drawing.Point(10, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 456);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fuel Station";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fuel";
            // 
            // txtFuelPrice
            // 
            this.txtFuelPrice.BackColor = System.Drawing.Color.Gray;
            this.txtFuelPrice.BorderColor = System.Drawing.Color.White;
            this.txtFuelPrice.BorderRadius = 20;
            this.txtFuelPrice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtFuelPrice.DefaultText = "";
            this.txtFuelPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFuelPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFuelPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFuelPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFuelPrice.Enabled = false;
            this.txtFuelPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFuelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.txtFuelPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtFuelPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFuelPrice.Location = new System.Drawing.Point(100, 114);
            this.txtFuelPrice.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtFuelPrice.Name = "txtFuelPrice";
            this.txtFuelPrice.PasswordChar = '\0';
            this.txtFuelPrice.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtFuelPrice.PlaceholderText = "";
            this.txtFuelPrice.SelectedText = "";
            this.txtFuelPrice.Size = new System.Drawing.Size(135, 35);
            this.txtFuelPrice.TabIndex = 11;
            // 
            // cmbFuel
            // 
            this.cmbFuel.BackColor = System.Drawing.Color.Transparent;
            this.cmbFuel.BorderRadius = 20;
            this.cmbFuel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFuel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFuel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbFuel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbFuel.ItemHeight = 30;
            this.cmbFuel.Location = new System.Drawing.Point(100, 50);
            this.cmbFuel.Name = "cmbFuel";
            this.cmbFuel.Size = new System.Drawing.Size(135, 36);
            this.cmbFuel.TabIndex = 8;
            this.cmbFuel.SelectedIndexChanged += new System.EventHandler(this.cmbFuel_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(263, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "AZN";
            // 
            // txtAzn
            // 
            this.txtAzn.BorderRadius = 20;
            this.txtAzn.BorderThickness = 4;
            this.txtAzn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAzn.DefaultText = "";
            this.txtAzn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAzn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAzn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAzn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAzn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAzn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAzn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAzn.Location = new System.Drawing.Point(151, 221);
            this.txtAzn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAzn.Name = "txtAzn";
            this.txtAzn.PasswordChar = '\0';
            this.txtAzn.PlaceholderText = "";
            this.txtAzn.SelectedText = "";
            this.txtAzn.ShortcutsEnabled = false;
            this.txtAzn.Size = new System.Drawing.Size(106, 41);
            this.txtAzn.TabIndex = 6;
            this.txtAzn.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            this.txtAzn.Click += new System.EventHandler(this.txtBox_Click);
            this.txtAzn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(263, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "L";
            // 
            // txtLiter
            // 
            this.txtLiter.BorderRadius = 20;
            this.txtLiter.BorderThickness = 4;
            this.txtLiter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLiter.DefaultText = "";
            this.txtLiter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLiter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLiter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLiter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLiter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLiter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLiter.Location = new System.Drawing.Point(151, 170);
            this.txtLiter.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtLiter.Name = "txtLiter";
            this.txtLiter.PasswordChar = '\0';
            this.txtLiter.PlaceholderText = "";
            this.txtLiter.SelectedText = "";
            this.txtLiter.ShortcutsEnabled = false;
            this.txtLiter.Size = new System.Drawing.Size(106, 41);
            this.txtLiter.TabIndex = 4;
            this.txtLiter.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            this.txtLiter.Click += new System.EventHandler(this.txtBox_Click);
            this.txtLiter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbAzn);
            this.panel1.Controls.Add(this.rbLiter);
            this.panel1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Location = new System.Drawing.Point(6, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 110);
            this.panel1.TabIndex = 3;
            // 
            // rbAzn
            // 
            this.rbAzn.AutoSize = true;
            this.rbAzn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbAzn.CheckedState.BorderThickness = 0;
            this.rbAzn.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.rbAzn.CheckedState.InnerColor = System.Drawing.Color.Cyan;
            this.rbAzn.CheckedState.InnerOffset = -4;
            this.rbAzn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbAzn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.rbAzn.ForeColor = System.Drawing.Color.White;
            this.rbAzn.Location = new System.Drawing.Point(16, 64);
            this.rbAzn.Name = "rbAzn";
            this.rbAzn.Size = new System.Drawing.Size(81, 33);
            this.rbAzn.TabIndex = 1;
            this.rbAzn.Text = "AZN";
            this.rbAzn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbAzn.UncheckedState.BorderThickness = 2;
            this.rbAzn.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbAzn.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbAzn.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbLiter
            // 
            this.rbLiter.AutoSize = true;
            this.rbLiter.Checked = true;
            this.rbLiter.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbLiter.CheckedState.BorderThickness = 0;
            this.rbLiter.CheckedState.FillColor = System.Drawing.Color.Lime;
            this.rbLiter.CheckedState.InnerColor = System.Drawing.Color.Cyan;
            this.rbLiter.CheckedState.InnerOffset = -4;
            this.rbLiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbLiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.rbLiter.ForeColor = System.Drawing.Color.White;
            this.rbLiter.Location = new System.Drawing.Point(16, 13);
            this.rbLiter.Name = "rbLiter";
            this.rbLiter.Size = new System.Drawing.Size(81, 33);
            this.rbLiter.TabIndex = 0;
            this.rbLiter.TabStop = true;
            this.rbLiter.Text = "Liter";
            this.rbLiter.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbLiter.UncheckedState.BorderThickness = 2;
            this.rbLiter.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbLiter.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbLiter.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.lblFuelAmount);
            this.groupBox4.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox4.Location = new System.Drawing.Point(6, 311);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(276, 121);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fuel Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(210, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "AZN";
            // 
            // lblFuelAmount
            // 
            this.lblFuelAmount.AutoSize = true;
            this.lblFuelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFuelAmount.ForeColor = System.Drawing.Color.Lime;
            this.lblFuelAmount.Location = new System.Drawing.Point(107, 41);
            this.lblFuelAmount.Name = "lblFuelAmount";
            this.lblFuelAmount.Size = new System.Drawing.Size(97, 46);
            this.lblFuelAmount.TabIndex = 0;
            this.lblFuelAmount.Text = "0,00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudSpriteCount);
            this.groupBox2.Controls.Add(this.txtSpritePrice);
            this.groupBox2.Controls.Add(this.cbSprite);
            this.groupBox2.Controls.Add(this.nudCocaColaCount);
            this.groupBox2.Controls.Add(this.txtCocaColaPrice);
            this.groupBox2.Controls.Add(this.cbCocaCola);
            this.groupBox2.Controls.Add(this.nudGamburgerCount);
            this.groupBox2.Controls.Add(this.txtGamburgerPrice);
            this.groupBox2.Controls.Add(this.cbGamburger);
            this.groupBox2.Controls.Add(this.nudHotDogCount);
            this.groupBox2.Controls.Add(this.txtHotDogPrice);
            this.groupBox2.Controls.Add(this.cbHotDog);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox2.Location = new System.Drawing.Point(354, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 456);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mini-Cafe";
            // 
            // nudSpriteCount
            // 
            this.nudSpriteCount.BackColor = System.Drawing.Color.Transparent;
            this.nudSpriteCount.BorderRadius = 20;
            this.nudSpriteCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudSpriteCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudSpriteCount.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.nudSpriteCount.Location = new System.Drawing.Point(241, 221);
            this.nudSpriteCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudSpriteCount.Name = "nudSpriteCount";
            this.nudSpriteCount.Size = new System.Drawing.Size(75, 35);
            this.nudSpriteCount.TabIndex = 12;
            this.nudSpriteCount.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            this.nudSpriteCount.Enter += new System.EventHandler(this.numericUpDown_Enter);
            this.nudSpriteCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown_KeyDown);
            this.nudSpriteCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown_KeyPress);
            // 
            // txtSpritePrice
            // 
            this.txtSpritePrice.Enabled = false;
            this.txtSpritePrice.Location = new System.Drawing.Point(152, 222);
            this.txtSpritePrice.Name = "txtSpritePrice";
            this.txtSpritePrice.Size = new System.Drawing.Size(71, 34);
            this.txtSpritePrice.TabIndex = 11;
            // 
            // cbSprite
            // 
            this.cbSprite.AutoSize = true;
            this.cbSprite.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSprite.CheckedState.BorderRadius = 0;
            this.cbSprite.CheckedState.BorderThickness = 0;
            this.cbSprite.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSprite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSprite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSprite.ForeColor = System.Drawing.Color.White;
            this.cbSprite.Location = new System.Drawing.Point(16, 222);
            this.cbSprite.Name = "cbSprite";
            this.cbSprite.Size = new System.Drawing.Size(85, 29);
            this.cbSprite.TabIndex = 10;
            this.cbSprite.Text = "Sprite";
            this.cbSprite.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbSprite.UncheckedState.BorderRadius = 0;
            this.cbSprite.UncheckedState.BorderThickness = 0;
            this.cbSprite.UncheckedState.FillColor = System.Drawing.Color.White;
            this.cbSprite.CheckedChanged += new System.EventHandler(this.cbCheckedChanged);
            // 
            // nudCocaColaCount
            // 
            this.nudCocaColaCount.BackColor = System.Drawing.Color.Transparent;
            this.nudCocaColaCount.BorderRadius = 20;
            this.nudCocaColaCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudCocaColaCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudCocaColaCount.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.nudCocaColaCount.Location = new System.Drawing.Point(241, 163);
            this.nudCocaColaCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudCocaColaCount.Name = "nudCocaColaCount";
            this.nudCocaColaCount.Size = new System.Drawing.Size(75, 35);
            this.nudCocaColaCount.TabIndex = 9;
            this.nudCocaColaCount.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            this.nudCocaColaCount.Enter += new System.EventHandler(this.numericUpDown_Enter);
            this.nudCocaColaCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown_KeyDown);
            this.nudCocaColaCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown_KeyPress);
            // 
            // txtCocaColaPrice
            // 
            this.txtCocaColaPrice.Enabled = false;
            this.txtCocaColaPrice.Location = new System.Drawing.Point(152, 165);
            this.txtCocaColaPrice.Name = "txtCocaColaPrice";
            this.txtCocaColaPrice.Size = new System.Drawing.Size(71, 34);
            this.txtCocaColaPrice.TabIndex = 8;
            // 
            // cbCocaCola
            // 
            this.cbCocaCola.AutoSize = true;
            this.cbCocaCola.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCocaCola.CheckedState.BorderRadius = 0;
            this.cbCocaCola.CheckedState.BorderThickness = 0;
            this.cbCocaCola.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCocaCola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCocaCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCocaCola.ForeColor = System.Drawing.Color.White;
            this.cbCocaCola.Location = new System.Drawing.Point(16, 165);
            this.cbCocaCola.Name = "cbCocaCola";
            this.cbCocaCola.Size = new System.Drawing.Size(129, 29);
            this.cbCocaCola.TabIndex = 7;
            this.cbCocaCola.Text = "Coca-Cola";
            this.cbCocaCola.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbCocaCola.UncheckedState.BorderRadius = 0;
            this.cbCocaCola.UncheckedState.BorderThickness = 0;
            this.cbCocaCola.UncheckedState.FillColor = System.Drawing.Color.White;
            this.cbCocaCola.CheckedChanged += new System.EventHandler(this.cbCheckedChanged);
            // 
            // nudGamburgerCount
            // 
            this.nudGamburgerCount.BackColor = System.Drawing.Color.Transparent;
            this.nudGamburgerCount.BorderRadius = 20;
            this.nudGamburgerCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudGamburgerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudGamburgerCount.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.nudGamburgerCount.Location = new System.Drawing.Point(241, 106);
            this.nudGamburgerCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudGamburgerCount.Name = "nudGamburgerCount";
            this.nudGamburgerCount.Size = new System.Drawing.Size(75, 35);
            this.nudGamburgerCount.TabIndex = 6;
            this.nudGamburgerCount.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            this.nudGamburgerCount.Enter += new System.EventHandler(this.numericUpDown_Enter);
            this.nudGamburgerCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown_KeyDown);
            this.nudGamburgerCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown_KeyPress);
            // 
            // txtGamburgerPrice
            // 
            this.txtGamburgerPrice.Enabled = false;
            this.txtGamburgerPrice.Location = new System.Drawing.Point(152, 107);
            this.txtGamburgerPrice.Name = "txtGamburgerPrice";
            this.txtGamburgerPrice.Size = new System.Drawing.Size(71, 34);
            this.txtGamburgerPrice.TabIndex = 5;
            // 
            // cbGamburger
            // 
            this.cbGamburger.AutoSize = true;
            this.cbGamburger.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGamburger.CheckedState.BorderRadius = 0;
            this.cbGamburger.CheckedState.BorderThickness = 0;
            this.cbGamburger.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGamburger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbGamburger.ForeColor = System.Drawing.Color.White;
            this.cbGamburger.Location = new System.Drawing.Point(16, 107);
            this.cbGamburger.Name = "cbGamburger";
            this.cbGamburger.Size = new System.Drawing.Size(132, 29);
            this.cbGamburger.TabIndex = 4;
            this.cbGamburger.Text = "Gamburger";
            this.cbGamburger.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbGamburger.UncheckedState.BorderRadius = 0;
            this.cbGamburger.UncheckedState.BorderThickness = 0;
            this.cbGamburger.UncheckedState.FillColor = System.Drawing.Color.White;
            this.cbGamburger.CheckedChanged += new System.EventHandler(this.cbCheckedChanged);
            // 
            // nudHotDogCount
            // 
            this.nudHotDogCount.BackColor = System.Drawing.Color.Transparent;
            this.nudHotDogCount.BorderRadius = 20;
            this.nudHotDogCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudHotDogCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudHotDogCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nudHotDogCount.Location = new System.Drawing.Point(241, 49);
            this.nudHotDogCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudHotDogCount.Name = "nudHotDogCount";
            this.nudHotDogCount.Size = new System.Drawing.Size(75, 35);
            this.nudHotDogCount.TabIndex = 3;
            this.nudHotDogCount.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            this.nudHotDogCount.Enter += new System.EventHandler(this.numericUpDown_Enter);
            this.nudHotDogCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUpDown_KeyDown);
            this.nudHotDogCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown_KeyPress);
            // 
            // txtHotDogPrice
            // 
            this.txtHotDogPrice.Enabled = false;
            this.txtHotDogPrice.Location = new System.Drawing.Point(152, 50);
            this.txtHotDogPrice.Name = "txtHotDogPrice";
            this.txtHotDogPrice.Size = new System.Drawing.Size(71, 34);
            this.txtHotDogPrice.TabIndex = 3;
            // 
            // cbHotDog
            // 
            this.cbHotDog.AutoSize = true;
            this.cbHotDog.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbHotDog.CheckedState.BorderRadius = 0;
            this.cbHotDog.CheckedState.BorderThickness = 0;
            this.cbHotDog.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbHotDog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbHotDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbHotDog.ForeColor = System.Drawing.Color.White;
            this.cbHotDog.Location = new System.Drawing.Point(16, 50);
            this.cbHotDog.Name = "cbHotDog";
            this.cbHotDog.Size = new System.Drawing.Size(107, 29);
            this.cbHotDog.TabIndex = 2;
            this.cbHotDog.Text = "Hot-Dog";
            this.cbHotDog.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbHotDog.UncheckedState.BorderRadius = 0;
            this.cbHotDog.UncheckedState.BorderThickness = 0;
            this.cbHotDog.UncheckedState.FillColor = System.Drawing.Color.White;
            this.cbHotDog.CheckedChanged += new System.EventHandler(this.cbCheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.lblFoodAmount);
            this.groupBox5.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox5.Location = new System.Drawing.Point(6, 311);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(277, 121);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Food Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(202, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "AZN";
            // 
            // lblFoodAmount
            // 
            this.lblFoodAmount.AutoSize = true;
            this.lblFoodAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFoodAmount.ForeColor = System.Drawing.Color.Lime;
            this.lblFoodAmount.Location = new System.Drawing.Point(99, 41);
            this.lblFoodAmount.Name = "lblFoodAmount";
            this.lblFoodAmount.Size = new System.Drawing.Size(97, 46);
            this.lblFoodAmount.TabIndex = 9;
            this.lblFoodAmount.Text = "0,00";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lblTotalAmount);
            this.groupBox3.Controls.Add(this.btnPayAmount);
            this.groupBox3.Controls.Add(this.pbFuel);
            this.groupBox3.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox3.Location = new System.Drawing.Point(10, 518);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(670, 142);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(552, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "AZN";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Lime;
            this.lblTotalAmount.Location = new System.Drawing.Point(449, 63);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(97, 46);
            this.lblTotalAmount.TabIndex = 9;
            this.lblTotalAmount.Text = "0,00";
            // 
            // btnPayAmount
            // 
            this.btnPayAmount.BorderRadius = 30;
            this.btnPayAmount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayAmount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPayAmount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPayAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPayAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPayAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPayAmount.ForeColor = System.Drawing.Color.White;
            this.btnPayAmount.Location = new System.Drawing.Point(173, 46);
            this.btnPayAmount.Name = "btnPayAmount";
            this.btnPayAmount.Size = new System.Drawing.Size(142, 79);
            this.btnPayAmount.TabIndex = 1;
            this.btnPayAmount.Text = "Pay the Amount";
            this.btnPayAmount.Click += new System.EventHandler(this.btnPayAmount_Click);
            // 
            // pbFuel
            // 
            this.pbFuel.Image = global::BestOil_Winform.Properties.Resources.cash;
            this.pbFuel.ImageRotate = 0F;
            this.pbFuel.Location = new System.Drawing.Point(22, 33);
            this.pbFuel.Name = "pbFuel";
            this.pbFuel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbFuel.Size = new System.Drawing.Size(104, 92);
            this.pbFuel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFuel.TabIndex = 0;
            this.pbFuel.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(692, 672);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BestOil";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpriteCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCocaColaCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGamburgerCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHotDogCount)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudHotDogCount;
        private Guna.UI2.WinForms.Guna2RadioButton rbLiter;
        private Guna.UI2.WinForms.Guna2TextBox txtLiter;
        private Guna.UI2.WinForms.Guna2RadioButton rbAzn;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtAzn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFuelAmount;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFuel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFoodAmount;
        private Guna.UI2.WinForms.Guna2TextBox txtFuelPrice;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudSpriteCount;
        private System.Windows.Forms.TextBox txtSpritePrice;
        private Guna.UI2.WinForms.Guna2CheckBox cbSprite;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudCocaColaCount;
        private System.Windows.Forms.TextBox txtCocaColaPrice;
        private Guna.UI2.WinForms.Guna2CheckBox cbCocaCola;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudGamburgerCount;
        private System.Windows.Forms.TextBox txtGamburgerPrice;
        private Guna.UI2.WinForms.Guna2CheckBox cbGamburger;
        private System.Windows.Forms.TextBox txtHotDogPrice;
        private Guna.UI2.WinForms.Guna2CheckBox cbHotDog;
        private Guna.UI2.WinForms.Guna2Button btnPayAmount;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbFuel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}

