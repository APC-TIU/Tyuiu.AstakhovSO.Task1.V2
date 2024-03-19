namespace Tyuiu.AstakhovSO.Task1.V2
{
    partial class MainForm
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
            this.TableShops = new System.Windows.Forms.DataGridView();
            this.tableShopsLabel = new System.Windows.Forms.Label();
            this.ReadButton = new System.Windows.Forms.Button();
            this.WriteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddingTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ColumnSearchNameTextBox = new System.Windows.Forms.TextBox();
            this.RowSearchValueTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SortButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableShops)).BeginInit();
            this.SuspendLayout();
            // 
            // TableShops
            // 
            this.TableShops.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TableShops.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableShops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableShops.Location = new System.Drawing.Point(12, 315);
            this.TableShops.Name = "TableShops";
            this.TableShops.ReadOnly = true;
            this.TableShops.Size = new System.Drawing.Size(464, 255);
            this.TableShops.TabIndex = 0;
            // 
            // tableShopsLabel
            // 
            this.tableShopsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableShopsLabel.AutoSize = true;
            this.tableShopsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableShopsLabel.Location = new System.Drawing.Point(127, 288);
            this.tableShopsLabel.Name = "tableShopsLabel";
            this.tableShopsLabel.Size = new System.Drawing.Size(233, 24);
            this.tableShopsLabel.TabIndex = 1;
            this.tableShopsLabel.Text = "Таблица сети магазинов";
            this.tableShopsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(12, 12);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(75, 23);
            this.ReadButton.TabIndex = 2;
            this.ReadButton.Text = "Прочитать";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // WriteButton
            // 
            this.WriteButton.Location = new System.Drawing.Point(93, 12);
            this.WriteButton.Name = "WriteButton";
            this.WriteButton.Size = new System.Drawing.Size(75, 23);
            this.WriteButton.TabIndex = 3;
            this.WriteButton.Text = "Сохранить";
            this.WriteButton.UseVisualStyleBackColor = true;
            this.WriteButton.Click += new System.EventHandler(this.WriteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(174, 12);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddingTextBox
            // 
            this.AddingTextBox.Location = new System.Drawing.Point(256, 13);
            this.AddingTextBox.Name = "AddingTextBox";
            this.AddingTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddingTextBox.TabIndex = 5;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(13, 58);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ColumnSearchNameTextBox
            // 
            this.ColumnSearchNameTextBox.Location = new System.Drawing.Point(95, 58);
            this.ColumnSearchNameTextBox.Name = "ColumnSearchNameTextBox";
            this.ColumnSearchNameTextBox.Size = new System.Drawing.Size(115, 20);
            this.ColumnSearchNameTextBox.TabIndex = 7;
            // 
            // RowSearchValueTextBox
            // 
            this.RowSearchValueTextBox.Location = new System.Drawing.Point(216, 58);
            this.RowSearchValueTextBox.Name = "RowSearchValueTextBox";
            this.RowSearchValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.RowSearchValueTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Название колонки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Значение";
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(12, 87);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(75, 23);
            this.SortButton.TabIndex = 11;
            this.SortButton.Text = "Сортировка";
            this.SortButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 582);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RowSearchValueTextBox);
            this.Controls.Add(this.ColumnSearchNameTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.AddingTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.WriteButton);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.tableShopsLabel);
            this.Controls.Add(this.TableShops);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.TableShops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableShops;
        private System.Windows.Forms.Label tableShopsLabel;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Button WriteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AddingTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox ColumnSearchNameTextBox;
        private System.Windows.Forms.TextBox RowSearchValueTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SortButton;
    }
}

