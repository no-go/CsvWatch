using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CsvWatch
{

	public partial class MainForm : Form
	{
		int columnSelect = 0;
			
		public MainForm()
		{
			InitializeComponent();
			string[] args = Environment.GetCommandLineArgs();
			if (args.Length > 1) {
				loadCsv(args[1]);
			}
		}
		
		void loadCsv(string filepath) {
			bool firstline = true;
			string[] lines = System.IO.File.ReadAllLines(filepath);
			
			DataTable data = new DataTable();
			
			foreach (string a in lines) {
				if (a.Contains(",")) {
					string[] columns = a.Split(',');
					
					if (firstline) {
						firstline = false;
						// Header
						foreach (string column in columns) {
							data.Columns.Add(column);
							//Console.WriteLine(column);
						}
					} else {
						// Body
						DataRow R = data.NewRow();
						//Console.WriteLine("{0}, ", R.ItemArray.Length);
						for (int i = 0; i < columns.Length; i++) {
							R[i] = columns[i];
						}
						data.Rows.Add(R);
					}
				}
			}
			tb_zeilen.Text = string.Format("{0}", lines.Length - 1);
			this.Text = OpenFileDialog1.FileName;
			tb_mit.Text = "";
			tb_min.Text = "";
			tb_max.Text = "";
			tb_med.Text = "";
			tb_sqrtvar.Text = "";
			DataGridView1.DataSource = data;
		}
		
		void TxtOderCsvToolStripMenuItemClick(object sender, EventArgs e) {
			if (OpenFileDialog1.ShowDialog() != DialogResult.OK) return;
			loadCsv(OpenFileDialog1.FileName);
			DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
		}
		
		void KonfigurationToolStripMenuItemClick(object sender, EventArgs e) {
			if (OpenFileDialog2.ShowDialog() != DialogResult.OK) return;
			string[] lines = System.IO.File.ReadAllLines(OpenFileDialog2.FileName);
			if (lines.Length < 8) return;
			tb_pro1.Text = lines[0];
			tb_pro2.Text = lines[1];
			tb_pro3.Text = lines[2];
			tb_pro4.Text = lines[3];
			tb_pro5.Text = lines[4];
			tb_pro6.Text = lines[5];
			tb_pro7.Text = lines[6];
			tb_pro8.Text = lines[7];
		}
	
		double Median(double[] YourArray) {
			int size = YourArray.Length;
			if (size == 0) return 0;
			
			if (size % 2 == 0) {
				return (YourArray[(int)(size / (double)2) - 1] + YourArray[(int)(size / (double)2)]) / 2;
			} else {
				return YourArray[(int) (Math.Floor(size / (double)2))];
			}
		}
		
		void BeendenToolStripMenuItemClick(object sender, EventArgs e) {
			Close();
		}
		
		void DataGridView1CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var vals = new double[DataGridView1.RowCount - 1];
			double sum = 0.0;
			double mit;
			try
			{
				for (int i = 0; i < (DataGridView1.RowCount - 1); i++)
				{
					if (DataGridView1.Rows[i].Cells[e.ColumnIndex].Value is object)
					{
						vals[i] = Double.Parse(DataGridView1.Rows[i].Cells[e.ColumnIndex].Value.ToString());
						sum += vals[i];
					}
				}
		
				Array.Sort(vals);
				mit = sum / (DataGridView1.RowCount - 1);
				tb_mit.Text = string.Format("{0}", mit);
				tb_min.Text = string.Format("{0}", vals[0]);
				tb_max.Text = string.Format("{0}", vals[vals.Length - 1]);
				tb_med.Text = string.Format("{0}", Median(vals));
				sum = 0.0;
				foreach (double val in vals) sum += Math.Pow(val - mit, 2);
				tb_sqrtvar.Text = string.Format("{0}", Math.Sqrt(sum / (DataGridView1.RowCount - 2))); // sqrt(sum((xi-x)^2)/n-1)
				columnSelect = e.ColumnIndex;
			}
			catch (Exception )
			{
				// dummy
			}
		}
		
		void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
		{
			columnSelect = e.ColumnIndex;
		}
		
		public void mark(TextBox sender, TextBox tb)
		{
			int count = 0;
			try
			{
				string[] words = tb.Text.Split(',');
				for (int i = 0; i < (DataGridView1.RowCount - 1); i++)
				{
					if (DataGridView1.Rows[i].Cells[columnSelect].Value is object)
					{
						foreach (string wor in words)
						{
							if (DataGridView1.Rows[i].Cells[columnSelect].Value.ToString().IndexOf(wor) >= 0)
							{
								DataGridView1.Rows[i].Cells[columnSelect].Style.BackColor = sender.BackColor;
								count += 1;
								continue;
							}
						}
					}
				}
		
				sender.Text = string.Format("{0}", count);
				DataGridView1.Refresh();
			}
			catch (Exception)
			{
				// dummy
			}
		}
		
		void Tb_krit1DoubleClick(object sender, EventArgs e) {
			mark((TextBox) sender, tb_pro1);
		}
		void Tb_krit2DoubleClick(object sender, EventArgs e) {
			mark((TextBox) sender, tb_pro2);
		}
		void Tb_krit3DoubleClick(object sender, EventArgs e) {
			mark((TextBox) sender, tb_pro3);
		}
		void Tb_krit4DoubleClick(object sender, EventArgs e) {
			mark((TextBox) sender, tb_pro4);
		}
		void Tb_krit5DoubleClick(object sender, EventArgs e) {
			mark((TextBox) sender, tb_pro5);
		}
		void Tb_krit6DoubleClick(object sender, EventArgs e) {
			mark((TextBox) sender, tb_pro6);
		}
		void Tb_krit7DoubleClick(object sender, EventArgs e) {
			mark((TextBox) sender, tb_pro7);
		}
		void Tb_krit8DoubleClick(object sender, EventArgs e) {
			mark((TextBox) sender, tb_pro8);
		}
	}
}
