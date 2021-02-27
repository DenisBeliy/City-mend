
namespace City_mend.Forms
{
    partial class Residents
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meaning_of_life = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.информацияОКлассеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.информацияОКлассеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.информацияОКлассеToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.информацияОКлассеToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.contextMenuStrip5 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.информацияОКлассеToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timerMoney = new System.Windows.Forms.Timer(this.components);
            this.button10 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip6 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.информацияОКлассеToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip7 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.информацияОКлассеToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip8 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.информацияОКлассеToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip9 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.информацияОКлассеToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.contextMenuStrip4.SuspendLayout();
            this.contextMenuStrip5.SuspendLayout();
            this.contextMenuStrip6.SuspendLayout();
            this.contextMenuStrip7.SuspendLayout();
            this.contextMenuStrip8.SuspendLayout();
            this.contextMenuStrip9.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1237, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.name,
            this.specialty,
            this.meaning_of_life,
            this.temperament,
            this.endurance});
            this.dataGridView1.Location = new System.Drawing.Point(34, -3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(1197, 467);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // number
            // 
            this.number.Frozen = true;
            this.number.HeaderText = "Номер";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 104;
            // 
            // name
            // 
            this.name.Frozen = true;
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 210;
            // 
            // specialty
            // 
            this.specialty.Frozen = true;
            this.specialty.HeaderText = "Специальность";
            this.specialty.Name = "specialty";
            this.specialty.ReadOnly = true;
            this.specialty.Width = 210;
            // 
            // meaning_of_life
            // 
            this.meaning_of_life.Frozen = true;
            this.meaning_of_life.HeaderText = "Смысл жизни";
            this.meaning_of_life.Name = "meaning_of_life";
            this.meaning_of_life.ReadOnly = true;
            this.meaning_of_life.Width = 210;
            // 
            // temperament
            // 
            this.temperament.Frozen = true;
            this.temperament.HeaderText = "Темперамент";
            this.temperament.Name = "temperament";
            this.temperament.ReadOnly = true;
            this.temperament.Width = 210;
            // 
            // endurance
            // 
            this.endurance.Frozen = true;
            this.endurance.HeaderText = "Выносливость";
            this.endurance.Name = "endurance";
            this.endurance.ReadOnly = true;
            this.endurance.Width = 210;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.ContextMenuStrip = this.contextMenuStrip1;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(142, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 83);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сталкер";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Leave += new System.EventHandler(this.button1_Leave);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияОКлассеToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // информацияОКлассеToolStripMenuItem
            // 
            this.информацияОКлассеToolStripMenuItem.Name = "информацияОКлассеToolStripMenuItem";
            this.информацияОКлассеToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.информацияОКлассеToolStripMenuItem.Text = "Информация о классе";
            this.информацияОКлассеToolStripMenuItem.Click += new System.EventHandler(this.информацияОКлассеToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.ContextMenuStrip = this.contextMenuStrip2;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(254, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 83);
            this.button2.TabIndex = 4;
            this.button2.Text = "Охотник за головами";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияОКлассеToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(199, 26);
            // 
            // информацияОКлассеToolStripMenuItem1
            // 
            this.информацияОКлассеToolStripMenuItem1.Name = "информацияОКлассеToolStripMenuItem1";
            this.информацияОКлассеToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.информацияОКлассеToolStripMenuItem1.Text = "Информация о классе";
            this.информацияОКлассеToolStripMenuItem1.Click += new System.EventHandler(this.информацияОКлассеToolStripMenuItem1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Brown;
            this.button3.ContextMenuStrip = this.contextMenuStrip3;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(366, 470);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 83);
            this.button3.TabIndex = 5;
            this.button3.Text = "Ученый";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияОКлассеToolStripMenuItem2});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(199, 26);
            // 
            // информацияОКлассеToolStripMenuItem2
            // 
            this.информацияОКлассеToolStripMenuItem2.Name = "информацияОКлассеToolStripMenuItem2";
            this.информацияОКлассеToolStripMenuItem2.Size = new System.Drawing.Size(198, 22);
            this.информацияОКлассеToolStripMenuItem2.Text = "Информация о классе";
            this.информацияОКлассеToolStripMenuItem2.Click += new System.EventHandler(this.информацияОКлассеToolStripMenuItem2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RosyBrown;
            this.button4.ContextMenuStrip = this.contextMenuStrip4;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(478, 470);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 83);
            this.button4.TabIndex = 8;
            this.button4.Text = "Пастух";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияОКлассеToolStripMenuItem3});
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(199, 26);
            // 
            // информацияОКлассеToolStripMenuItem3
            // 
            this.информацияОКлассеToolStripMenuItem3.Name = "информацияОКлассеToolStripMenuItem3";
            this.информацияОКлассеToolStripMenuItem3.Size = new System.Drawing.Size(198, 22);
            this.информацияОКлассеToolStripMenuItem3.Text = "Информация о классе";
            this.информацияОКлассеToolStripMenuItem3.Click += new System.EventHandler(this.информацияОКлассеToolStripMenuItem3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.OrangeRed;
            this.button5.ContextMenuStrip = this.contextMenuStrip5;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(590, 470);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 83);
            this.button5.TabIndex = 7;
            this.button5.Text = "Каменщик";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseEnter += new System.EventHandler(this.button5_MouseEnter);
            this.button5.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button5.MouseHover += new System.EventHandler(this.button5_MouseHover);
            // 
            // contextMenuStrip5
            // 
            this.contextMenuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияОКлассеToolStripMenuItem4});
            this.contextMenuStrip5.Name = "contextMenuStrip5";
            this.contextMenuStrip5.Size = new System.Drawing.Size(199, 26);
            // 
            // информацияОКлассеToolStripMenuItem4
            // 
            this.информацияОКлассеToolStripMenuItem4.Name = "информацияОКлассеToolStripMenuItem4";
            this.информацияОКлассеToolStripMenuItem4.Size = new System.Drawing.Size(198, 22);
            this.информацияОКлассеToolStripMenuItem4.Text = "Информация о классе";
            this.информацияОКлассеToolStripMenuItem4.Click += new System.EventHandler(this.информацияОКлассеToolStripMenuItem4_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.RoyalBlue;
            this.button6.ContextMenuStrip = this.contextMenuStrip6;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(702, 470);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 83);
            this.button6.TabIndex = 6;
            this.button6.Text = "Кузнец";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button6.MouseHover += new System.EventHandler(this.button6_MouseHover);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Bisque;
            this.button7.ContextMenuStrip = this.contextMenuStrip7;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(814, 470);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 83);
            this.button7.TabIndex = 11;
            this.button7.Text = "Священник";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            this.button7.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button7.MouseHover += new System.EventHandler(this.button7_MouseHover);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.SeaShell;
            this.button8.ContextMenuStrip = this.contextMenuStrip8;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(926, 470);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(106, 83);
            this.button8.TabIndex = 10;
            this.button8.Text = "Монах";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            this.button8.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button8.MouseHover += new System.EventHandler(this.button8_MouseHover);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button9.ContextMenuStrip = this.contextMenuStrip9;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(1038, 470);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(106, 83);
            this.button9.TabIndex = 9;
            this.button9.Text = "Торговец";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            this.button9.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button9.MouseHover += new System.EventHandler(this.button9_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 670);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 42);
            this.label2.TabIndex = 12;
            this.label2.Text = "money";
            // 
            // timerMoney
            // 
            this.timerMoney.Enabled = true;
            this.timerMoney.Interval = 1000;
            this.timerMoney.Tick += new System.EventHandler(this.timerMoney_Tick);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(1159, 486);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(106, 51);
            this.button10.TabIndex = 13;
            this.button10.Text = "test";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(571, 693);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // contextMenuStrip6
            // 
            this.contextMenuStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияОКлассеToolStripMenuItem5});
            this.contextMenuStrip6.Name = "contextMenuStrip6";
            this.contextMenuStrip6.Size = new System.Drawing.Size(199, 26);
            // 
            // информацияОКлассеToolStripMenuItem5
            // 
            this.информацияОКлассеToolStripMenuItem5.Name = "информацияОКлассеToolStripMenuItem5";
            this.информацияОКлассеToolStripMenuItem5.Size = new System.Drawing.Size(198, 22);
            this.информацияОКлассеToolStripMenuItem5.Text = "Информация о классе";
            this.информацияОКлассеToolStripMenuItem5.Click += new System.EventHandler(this.информацияОКлассеToolStripMenuItem5_Click);
            // 
            // contextMenuStrip7
            // 
            this.contextMenuStrip7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияОКлассеToolStripMenuItem6});
            this.contextMenuStrip7.Name = "contextMenuStrip7";
            this.contextMenuStrip7.Size = new System.Drawing.Size(199, 26);
            // 
            // информацияОКлассеToolStripMenuItem6
            // 
            this.информацияОКлассеToolStripMenuItem6.Name = "информацияОКлассеToolStripMenuItem6";
            this.информацияОКлассеToolStripMenuItem6.Size = new System.Drawing.Size(198, 22);
            this.информацияОКлассеToolStripMenuItem6.Text = "Информация о классе";
            this.информацияОКлассеToolStripMenuItem6.Click += new System.EventHandler(this.информацияОКлассеToolStripMenuItem6_Click);
            // 
            // contextMenuStrip8
            // 
            this.contextMenuStrip8.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияОКлассеToolStripMenuItem7});
            this.contextMenuStrip8.Name = "contextMenuStrip8";
            this.contextMenuStrip8.Size = new System.Drawing.Size(199, 26);
            // 
            // информацияОКлассеToolStripMenuItem7
            // 
            this.информацияОКлассеToolStripMenuItem7.Name = "информацияОКлассеToolStripMenuItem7";
            this.информацияОКлассеToolStripMenuItem7.Size = new System.Drawing.Size(198, 22);
            this.информацияОКлассеToolStripMenuItem7.Text = "Информация о классе";
            this.информацияОКлассеToolStripMenuItem7.Click += new System.EventHandler(this.информацияОКлассеToolStripMenuItem7_Click);
            // 
            // contextMenuStrip9
            // 
            this.contextMenuStrip9.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияОКлассеToolStripMenuItem8});
            this.contextMenuStrip9.Name = "contextMenuStrip9";
            this.contextMenuStrip9.Size = new System.Drawing.Size(199, 26);
            // 
            // информацияОКлассеToolStripMenuItem8
            // 
            this.информацияОКлассеToolStripMenuItem8.Name = "информацияОКлассеToolStripMenuItem8";
            this.информацияОКлассеToolStripMenuItem8.Size = new System.Drawing.Size(198, 22);
            this.информацияОКлассеToolStripMenuItem8.Text = "Информация о классе";
            this.информацияОКлассеToolStripMenuItem8.Click += new System.EventHandler(this.информацияОКлассеToolStripMenuItem8_Click);
            // 
            // Residents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = global::City_mend.Properties.Resources.backImage_;
            this.ClientSize = new System.Drawing.Size(1277, 721);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Residents";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Residents";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Residents_FormClosed);
            this.Load += new System.EventHandler(this.Residents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.contextMenuStrip4.ResumeLayout(false);
            this.contextMenuStrip5.ResumeLayout(false);
            this.contextMenuStrip6.ResumeLayout(false);
            this.contextMenuStrip7.ResumeLayout(false);
            this.contextMenuStrip8.ResumeLayout(false);
            this.contextMenuStrip9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn meaning_of_life;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperament;
        private System.Windows.Forms.DataGridViewTextBoxColumn endurance;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem информацияОКлассеToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem информацияОКлассеToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem информацияОКлассеToolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ToolStripMenuItem информацияОКлассеToolStripMenuItem3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip5;
        private System.Windows.Forms.ToolStripMenuItem информацияОКлассеToolStripMenuItem4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip6;
        private System.Windows.Forms.ToolStripMenuItem информацияОКлассеToolStripMenuItem5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip7;
        private System.Windows.Forms.ToolStripMenuItem информацияОКлассеToolStripMenuItem6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip8;
        private System.Windows.Forms.ToolStripMenuItem информацияОКлассеToolStripMenuItem7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip9;
        private System.Windows.Forms.ToolStripMenuItem информацияОКлассеToolStripMenuItem8;
    }
}