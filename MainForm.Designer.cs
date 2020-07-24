/*
 * Created by SharpDevelop 4.4
 * User: unknown
 * Date: 16.07.2020
 * Time: 11:46
 */
namespace CsvWatch
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.tb_sqrtvar = new System.Windows.Forms.TextBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.tb_med = new System.Windows.Forms.TextBox();
			this.tb_mit = new System.Windows.Forms.TextBox();
			this.tb_min = new System.Windows.Forms.TextBox();
			this.Lab8 = new System.Windows.Forms.Label();
			this.tb_max = new System.Windows.Forms.TextBox();
			this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
			this.DateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LadenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TxtOderCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.KonfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BeendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Lab7 = new System.Windows.Forms.Label();
			this.tb_pro8 = new System.Windows.Forms.TextBox();
			this.tb_pro7 = new System.Windows.Forms.TextBox();
			this.tb_pro6 = new System.Windows.Forms.TextBox();
			this.tb_pro5 = new System.Windows.Forms.TextBox();
			this.tb_pro2 = new System.Windows.Forms.TextBox();
			this.tb_pro1 = new System.Windows.Forms.TextBox();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.tb_pro4 = new System.Windows.Forms.TextBox();
			this.tb_pro3 = new System.Windows.Forms.TextBox();
			this.tb_krit8 = new System.Windows.Forms.TextBox();
			this.tb_krit7 = new System.Windows.Forms.TextBox();
			this.tb_krit5 = new System.Windows.Forms.TextBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.tb_krit6 = new System.Windows.Forms.TextBox();
			this.tb_krit4 = new System.Windows.Forms.TextBox();
			this.tb_krit3 = new System.Windows.Forms.TextBox();
			this.tb_krit2 = new System.Windows.Forms.TextBox();
			this.tb_krit1 = new System.Windows.Forms.TextBox();
			this.tb_zeilen = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Lab6 = new System.Windows.Forms.Label();
			this.Lab5 = new System.Windows.Forms.Label();
			this.Lab4 = new System.Windows.Forms.Label();
			this.Lab3 = new System.Windows.Forms.Label();
			this.Lab2 = new System.Windows.Forms.Label();
			this.Lab1 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.OpenFileDialog2 = new System.Windows.Forms.OpenFileDialog();
			this.MenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tb_sqrtvar
			// 
			this.tb_sqrtvar.Location = new System.Drawing.Point(198, 391);
			this.tb_sqrtvar.Name = "tb_sqrtvar";
			this.tb_sqrtvar.Size = new System.Drawing.Size(99, 20);
			this.tb_sqrtvar.TabIndex = 35;
			// 
			// tb_med
			// 
			this.tb_med.Location = new System.Drawing.Point(198, 365);
			this.tb_med.Name = "tb_med";
			this.tb_med.Size = new System.Drawing.Size(99, 20);
			this.tb_med.TabIndex = 33;
			// 
			// tb_mit
			// 
			this.tb_mit.Location = new System.Drawing.Point(198, 339);
			this.tb_mit.Name = "tb_mit";
			this.tb_mit.Size = new System.Drawing.Size(99, 20);
			this.tb_mit.TabIndex = 32;
			// 
			// tb_min
			// 
			this.tb_min.Location = new System.Drawing.Point(198, 287);
			this.tb_min.Name = "tb_min";
			this.tb_min.Size = new System.Drawing.Size(99, 20);
			this.tb_min.TabIndex = 30;
			// 
			// tb_max
			// 
			this.tb_max.Location = new System.Drawing.Point(198, 313);
			this.tb_max.Name = "tb_max";
			this.tb_max.Size = new System.Drawing.Size(99, 20);
			this.tb_max.TabIndex = 31;
			// 
			// MenuStrip1
			// 
			this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.DateiToolStripMenuItem});
			this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip1.Name = "MenuStrip1";
			this.MenuStrip1.Size = new System.Drawing.Size(1122, 24);
			this.MenuStrip1.TabIndex = 3;
			this.MenuStrip1.Text = "MenuStrip1";
			// 
			// DateiToolStripMenuItem
			// 
			this.DateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.LadenToolStripMenuItem,
									this.BeendenToolStripMenuItem});
			this.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem";
			this.DateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.DateiToolStripMenuItem.Text = "File";
			// 
			// LadenToolStripMenuItem
			// 
			this.LadenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.TxtOderCsvToolStripMenuItem,
									this.KonfigurationToolStripMenuItem});
			this.LadenToolStripMenuItem.Name = "LadenToolStripMenuItem";
			this.LadenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.LadenToolStripMenuItem.Text = "load";
			// 
			// TxtOderCsvToolStripMenuItem
			// 
			this.TxtOderCsvToolStripMenuItem.Name = "TxtOderCsvToolStripMenuItem";
			this.TxtOderCsvToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.TxtOderCsvToolStripMenuItem.Text = "txt or csv...";
			this.TxtOderCsvToolStripMenuItem.Click += new System.EventHandler(this.TxtOderCsvToolStripMenuItemClick);
			// 
			// KonfigurationToolStripMenuItem
			// 
			this.KonfigurationToolStripMenuItem.Name = "KonfigurationToolStripMenuItem";
			this.KonfigurationToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.KonfigurationToolStripMenuItem.Text = "load config...";
			this.KonfigurationToolStripMenuItem.Click += new System.EventHandler(this.KonfigurationToolStripMenuItemClick);
			// 
			// BeendenToolStripMenuItem
			// 
			this.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem";
			this.BeendenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.BeendenToolStripMenuItem.Text = "end";
			this.BeendenToolStripMenuItem.Click += new System.EventHandler(this.BeendenToolStripMenuItemClick);
			// 
			// tb_pro8
			// 
			this.tb_pro8.Location = new System.Drawing.Point(78, 232);
			this.tb_pro8.Name = "tb_pro8";
			this.tb_pro8.Size = new System.Drawing.Size(158, 20);
			this.tb_pro8.TabIndex = 27;
			this.tb_pro8.Text = "FCS No Ack";
			// 
			// tb_pro7
			// 
			this.tb_pro7.Location = new System.Drawing.Point(78, 206);
			this.tb_pro7.Name = "tb_pro7";
			this.tb_pro7.Size = new System.Drawing.Size(158, 20);
			this.tb_pro7.TabIndex = 26;
			this.tb_pro7.Text = "FCS Ack Error,fatal error";
			// 
			// tb_pro6
			// 
			this.tb_pro6.Location = new System.Drawing.Point(78, 180);
			this.tb_pro6.Name = "tb_pro6";
			this.tb_pro6.Size = new System.Drawing.Size(158, 20);
			this.tb_pro6.TabIndex = 25;
			this.tb_pro6.Text = "invalid Parameter,ARQ failure";
			// 
			// tb_pro5
			// 
			this.tb_pro5.Location = new System.Drawing.Point(78, 154);
			this.tb_pro5.Name = "tb_pro5";
			this.tb_pro5.Size = new System.Drawing.Size(158, 20);
			this.tb_pro5.TabIndex = 24;
			this.tb_pro5.Text = "FCS Ack";
			// 
			// tb_pro2
			// 
			this.tb_pro2.Location = new System.Drawing.Point(78, 76);
			this.tb_pro2.Name = "tb_pro2";
			this.tb_pro2.Size = new System.Drawing.Size(158, 20);
			this.tb_pro2.TabIndex = 21;
			this.tb_pro2.Text = "Ack OK,Success";
			// 
			// tb_pro1
			// 
			this.tb_pro1.Location = new System.Drawing.Point(78, 50);
			this.tb_pro1.Name = "tb_pro1";
			this.tb_pro1.Size = new System.Drawing.Size(158, 20);
			this.tb_pro1.TabIndex = 20;
			this.tb_pro1.Text = "Ack missing,Addr Error";
			// 
			// DataGridView1
			// 
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.AllowUserToResizeRows = false;
			this.DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new System.Drawing.Point(325, 33);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.RowHeadersVisible = false;
			this.DataGridView1.Size = new System.Drawing.Size(785, 455);
			this.DataGridView1.TabIndex = 5;
			this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellClick);
			this.DataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellDoubleClick);
			// 
			// tb_pro4
			// 
			this.tb_pro4.Location = new System.Drawing.Point(78, 128);
			this.tb_pro4.Name = "tb_pro4";
			this.tb_pro4.Size = new System.Drawing.Size(158, 20);
			this.tb_pro4.TabIndex = 23;
			this.tb_pro4.Text = "invalid PHY,FCS NACK";
			// 
			// tb_pro3
			// 
			this.tb_pro3.Location = new System.Drawing.Point(78, 102);
			this.tb_pro3.Name = "tb_pro3";
			this.tb_pro3.Size = new System.Drawing.Size(158, 20);
			this.tb_pro3.TabIndex = 22;
			this.tb_pro3.Text = "CSMA/CA fail,Buffer full,NACK";
			// 
			// tb_krit8
			// 
			this.tb_krit8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.tb_krit8.Location = new System.Drawing.Point(242, 232);
			this.tb_krit8.Name = "tb_krit8";
			this.tb_krit8.ReadOnly = true;
			this.tb_krit8.Size = new System.Drawing.Size(55, 20);
			this.tb_krit8.TabIndex = 19;
			this.tb_krit8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tb_krit8.DoubleClick += new System.EventHandler(this.Tb_krit8DoubleClick);
			// 
			// tb_krit7
			// 
			this.tb_krit7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.tb_krit7.Location = new System.Drawing.Point(242, 206);
			this.tb_krit7.Name = "tb_krit7";
			this.tb_krit7.ReadOnly = true;
			this.tb_krit7.Size = new System.Drawing.Size(55, 20);
			this.tb_krit7.TabIndex = 18;
			this.tb_krit7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tb_krit7.DoubleClick += new System.EventHandler(this.Tb_krit7DoubleClick);
			// 
			// tb_krit5
			// 
			this.tb_krit5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.tb_krit5.Location = new System.Drawing.Point(242, 154);
			this.tb_krit5.Name = "tb_krit5";
			this.tb_krit5.ReadOnly = true;
			this.tb_krit5.Size = new System.Drawing.Size(55, 20);
			this.tb_krit5.TabIndex = 16;
			this.tb_krit5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tb_krit5.DoubleClick += new System.EventHandler(this.Tb_krit5DoubleClick);
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.tb_sqrtvar);
			this.GroupBox1.Controls.Add(this.Label12);
			this.GroupBox1.Controls.Add(this.tb_med);
			this.GroupBox1.Controls.Add(this.tb_mit);
			this.GroupBox1.Controls.Add(this.tb_max);
			this.GroupBox1.Controls.Add(this.tb_min);
			this.GroupBox1.Controls.Add(this.Lab8);
			this.GroupBox1.Controls.Add(this.Lab7);
			this.GroupBox1.Controls.Add(this.tb_pro8);
			this.GroupBox1.Controls.Add(this.tb_pro7);
			this.GroupBox1.Controls.Add(this.tb_pro6);
			this.GroupBox1.Controls.Add(this.tb_pro5);
			this.GroupBox1.Controls.Add(this.tb_pro4);
			this.GroupBox1.Controls.Add(this.tb_pro3);
			this.GroupBox1.Controls.Add(this.tb_pro2);
			this.GroupBox1.Controls.Add(this.tb_pro1);
			this.GroupBox1.Controls.Add(this.tb_krit8);
			this.GroupBox1.Controls.Add(this.tb_krit7);
			this.GroupBox1.Controls.Add(this.tb_krit6);
			this.GroupBox1.Controls.Add(this.tb_krit5);
			this.GroupBox1.Controls.Add(this.tb_krit4);
			this.GroupBox1.Controls.Add(this.tb_krit3);
			this.GroupBox1.Controls.Add(this.tb_krit2);
			this.GroupBox1.Controls.Add(this.tb_krit1);
			this.GroupBox1.Controls.Add(this.tb_zeilen);
			this.GroupBox1.Controls.Add(this.Label11);
			this.GroupBox1.Controls.Add(this.Label10);
			this.GroupBox1.Controls.Add(this.Label9);
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Controls.Add(this.Lab6);
			this.GroupBox1.Controls.Add(this.Lab5);
			this.GroupBox1.Controls.Add(this.Lab4);
			this.GroupBox1.Controls.Add(this.Lab3);
			this.GroupBox1.Controls.Add(this.Lab2);
			this.GroupBox1.Controls.Add(this.Lab1);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Location = new System.Drawing.Point(12, 27);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(307, 431);
			this.GroupBox1.TabIndex = 4;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Statistics";
			// 
			// tb_krit6
			// 
			this.tb_krit6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.tb_krit6.Location = new System.Drawing.Point(242, 180);
			this.tb_krit6.Name = "tb_krit6";
			this.tb_krit6.ReadOnly = true;
			this.tb_krit6.Size = new System.Drawing.Size(55, 20);
			this.tb_krit6.TabIndex = 17;
			this.tb_krit6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tb_krit6.DoubleClick += new System.EventHandler(this.Tb_krit6DoubleClick);
			// 
			// tb_krit4
			// 
			this.tb_krit4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.tb_krit4.Location = new System.Drawing.Point(242, 128);
			this.tb_krit4.Name = "tb_krit4";
			this.tb_krit4.ReadOnly = true;
			this.tb_krit4.Size = new System.Drawing.Size(55, 20);
			this.tb_krit4.TabIndex = 15;
			this.tb_krit4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tb_krit4.DoubleClick += new System.EventHandler(this.Tb_krit4DoubleClick);
			// 
			// tb_krit3
			// 
			this.tb_krit3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.tb_krit3.Location = new System.Drawing.Point(242, 102);
			this.tb_krit3.Name = "tb_krit3";
			this.tb_krit3.ReadOnly = true;
			this.tb_krit3.Size = new System.Drawing.Size(55, 20);
			this.tb_krit3.TabIndex = 14;
			this.tb_krit3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tb_krit3.DoubleClick += new System.EventHandler(this.Tb_krit3DoubleClick);
			// 
			// tb_krit2
			// 
			this.tb_krit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tb_krit2.Location = new System.Drawing.Point(242, 76);
			this.tb_krit2.Name = "tb_krit2";
			this.tb_krit2.ReadOnly = true;
			this.tb_krit2.Size = new System.Drawing.Size(55, 20);
			this.tb_krit2.TabIndex = 13;
			this.tb_krit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tb_krit2.DoubleClick += new System.EventHandler(this.Tb_krit2DoubleClick);
			// 
			// tb_krit1
			// 
			this.tb_krit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.tb_krit1.Location = new System.Drawing.Point(242, 50);
			this.tb_krit1.Name = "tb_krit1";
			this.tb_krit1.ReadOnly = true;
			this.tb_krit1.Size = new System.Drawing.Size(55, 20);
			this.tb_krit1.TabIndex = 12;
			this.tb_krit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.tb_krit1.DoubleClick += new System.EventHandler(this.Tb_krit1DoubleClick);
			// 
			// tb_zeilen
			// 
			this.tb_zeilen.Location = new System.Drawing.Point(242, 24);
			this.tb_zeilen.Name = "tb_zeilen";
			this.tb_zeilen.Size = new System.Drawing.Size(55, 20);
			this.tb_zeilen.TabIndex = 11;
			this.tb_zeilen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Label12
			// 
			this.Label12.AutoSize = true;
			this.Label12.Location = new System.Drawing.Point(6, 394);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(105, 13);
			this.Label12.TabIndex = 34;
			this.Label12.Text = "empirical variance (sqrt)";
			// 
			// Label11
			// 
			this.Label11.AutoSize = true;
			this.Label11.Location = new System.Drawing.Point(6, 368);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(51, 13);
			this.Label11.TabIndex = 10;
			this.Label11.Text = "median";
			// 
			// Label10
			// 
			this.Label10.AutoSize = true;
			this.Label10.Location = new System.Drawing.Point(6, 342);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(52, 13);
			this.Label10.TabIndex = 9;
			this.Label10.Text = "arithmetic mean";
			// 
			// Label9
			// 
			this.Label9.AutoSize = true;
			this.Label9.Location = new System.Drawing.Point(6, 316);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(27, 13);
			this.Label9.TabIndex = 8;
			this.Label9.Text = "max";
			// 
			// Label8
			// 
			this.Label8.AutoSize = true;
			this.Label8.Location = new System.Drawing.Point(6, 290);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(24, 13);
			this.Label8.TabIndex = 7;
			this.Label8.Text = "min";
			// 
			// Lab8
			// 
			this.Lab8.AutoSize = true;
			this.Lab8.Location = new System.Drawing.Point(6, 235);
			this.Lab8.Name = "Lab8";
			this.Lab8.Size = new System.Drawing.Size(56, 13);
			this.Lab8.TabIndex = 29;
			this.Lab8.Text = "Counter 8";
			// 
			// Lab7
			// 
			this.Lab7.AutoSize = true;
			this.Lab7.Location = new System.Drawing.Point(6, 209);
			this.Lab7.Name = "Lab7";
			this.Lab7.Size = new System.Drawing.Size(56, 13);
			this.Lab7.TabIndex = 28;
			this.Lab7.Text = "Counter 7";
			// 
			// Lab6
			// 
			this.Lab6.AutoSize = true;
			this.Lab6.Location = new System.Drawing.Point(6, 183);
			this.Lab6.Name = "Lab6";
			this.Lab6.Size = new System.Drawing.Size(56, 13);
			this.Lab6.TabIndex = 6;
			this.Lab6.Text = "Counter 6";
			// 
			// Lab5
			// 
			this.Lab5.AutoSize = true;
			this.Lab5.Location = new System.Drawing.Point(6, 157);
			this.Lab5.Name = "Lab5";
			this.Lab5.Size = new System.Drawing.Size(56, 13);
			this.Lab5.TabIndex = 5;
			this.Lab5.Text = "Counter 5";
			// 
			// Lab4
			// 
			this.Lab4.AutoSize = true;
			this.Lab4.Location = new System.Drawing.Point(6, 131);
			this.Lab4.Name = "Lab4";
			this.Lab4.Size = new System.Drawing.Size(56, 13);
			this.Lab4.TabIndex = 4;
			this.Lab4.Text = "Counter 4";
			// 
			// Lab3
			// 
			this.Lab3.AutoSize = true;
			this.Lab3.Location = new System.Drawing.Point(6, 105);
			this.Lab3.Name = "Lab3";
			this.Lab3.Size = new System.Drawing.Size(56, 13);
			this.Lab3.TabIndex = 3;
			this.Lab3.Text = "Counter 3";
			// 
			// Lab2
			// 
			this.Lab2.AutoSize = true;
			this.Lab2.Location = new System.Drawing.Point(6, 79);
			this.Lab2.Name = "Lab2";
			this.Lab2.Size = new System.Drawing.Size(56, 13);
			this.Lab2.TabIndex = 2;
			this.Lab2.Text = "Counter 2";
			// 
			// Lab1
			// 
			this.Lab1.AutoSize = true;
			this.Lab1.Location = new System.Drawing.Point(6, 53);
			this.Lab1.Name = "Lab1";
			this.Lab1.Size = new System.Drawing.Size(56, 13);
			this.Lab1.TabIndex = 1;
			this.Lab1.Text = "Counter 1";
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(6, 27);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(36, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "rows";
			// 
			// OpenFileDialog1
			// 
			this.OpenFileDialog1.Filter = "CSV files|*.csv|Text files|*.txt";
			this.OpenFileDialog1.FilterIndex = 2;
			this.OpenFileDialog1.Title = "select a TXT or CSV file...";
			// 
			// OpenFileDialog2
			// 
			this.OpenFileDialog2.Filter = "Config files|*.conf";
			this.OpenFileDialog2.FilterIndex = 1;
			this.OpenFileDialog2.Title = "select a Config file...";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1122, 500);
			this.Controls.Add(this.MenuStrip1);
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.GroupBox1);
			this.Name = "MainForm";
			this.Text = "CsvWatch";
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
		internal System.Windows.Forms.OpenFileDialog OpenFileDialog2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Lab1;
		internal System.Windows.Forms.Label Lab2;
		internal System.Windows.Forms.Label Lab3;
		internal System.Windows.Forms.Label Lab4;
		internal System.Windows.Forms.Label Lab5;
		internal System.Windows.Forms.Label Lab6;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.TextBox tb_zeilen;
		internal System.Windows.Forms.TextBox tb_krit1;
		internal System.Windows.Forms.TextBox tb_krit2;
		internal System.Windows.Forms.TextBox tb_krit3;
		internal System.Windows.Forms.TextBox tb_krit4;
		internal System.Windows.Forms.TextBox tb_krit5;
		internal System.Windows.Forms.TextBox tb_krit6;
		internal System.Windows.Forms.TextBox tb_krit7;
		internal System.Windows.Forms.TextBox tb_krit8;
		internal System.Windows.Forms.TextBox tb_pro3;
		internal System.Windows.Forms.TextBox tb_pro4;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.DataGridView DataGridView1;
		internal System.Windows.Forms.TextBox tb_pro1;
		internal System.Windows.Forms.TextBox tb_pro2;
		internal System.Windows.Forms.TextBox tb_pro5;
		internal System.Windows.Forms.TextBox tb_pro6;
		internal System.Windows.Forms.TextBox tb_pro7;
		internal System.Windows.Forms.TextBox tb_pro8;
		internal System.Windows.Forms.Label Lab7;
		internal System.Windows.Forms.ToolStripMenuItem BeendenToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem KonfigurationToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem TxtOderCsvToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem LadenToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem DateiToolStripMenuItem;
		internal System.Windows.Forms.MenuStrip MenuStrip1;
		internal System.Windows.Forms.TextBox tb_max;
		internal System.Windows.Forms.Label Lab8;
		internal System.Windows.Forms.TextBox tb_min;
		internal System.Windows.Forms.TextBox tb_mit;
		internal System.Windows.Forms.TextBox tb_med;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.TextBox tb_sqrtvar;
	}
}
