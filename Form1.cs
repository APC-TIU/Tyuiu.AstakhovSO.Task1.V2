using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;



namespace Tyuiu.AstakhovSO.Task1.V2
{
    public partial class MainForm : Form
    {
        const string PATH = "../db.csv";
        private List<string[]> dbValues = new List<string[]>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            var csvReader = new CSVReader(PATH);
            this.dbValues = csvReader.ReadCSVFile();

            this.refreshTable(this.dbValues);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var newValues = this.AddingTextBox.Text.Split(' ');

            this.dbValues.Add(newValues);

            this.refreshTable(this.dbValues);
        }


        private void refreshTable(List<string[]> values)
        {
            this.TableShops.Columns.Clear();
            this.TableShops.Rows.Clear();

            try
            {

                for (int i = 0; i < values.Count; i++)
                {
                    if (i == 0)
                    {
                        for (int j = 0; j < values[i].Length; j++)
                        {
                            var column = new DataGridViewTextBoxColumn();
                            column.Name = values[i][j];
                            column.HeaderText = values[i][j];
                            column.Name = values[i][j];
                            this.TableShops.Columns.Add(column);
                        }
                    }
                    else
                    {
                        this.TableShops.Rows.Add();
                        for (int j = 0; j < values[i].Length; j++)
                        {
                            this.TableShops.Rows[i - 1].Cells[j].Value = values[i][j];
                        }
                    }
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(this, error.Message, "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            var newValues = this.AddingTextBox.Text.Split(' ');

            var csvWriter = new CSVWriter(PATH, this.dbValues);
            csvWriter.WriteCSV();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var filterColumn = this.ColumnSearchNameTextBox.Text;
            var filterRowValue = this.RowSearchValueTextBox.Text;

            var filterValues = new List<string[]>();

            filterValues.Add(this.dbValues[0]);

            for (int i = 0; i < this.TableShops.RowCount - 1; i++)
            {
                if (this.TableShops[filterColumn, i].Value.ToString() == filterRowValue)
                {
                    var values = new List<string>();
                    foreach (DataGridViewCell cell in this.TableShops.Rows[i].Cells)
                    {
                        values.Add(cell.Value != null ? cell.Value.ToString() : "");
                    }

                    filterValues.Add(values.ToArray());
                }
            }

            this.refreshTable(filterValues);
        }
    }
}
