
namespace Furniture_assembly
{
    partial class FormReportFurnitureComponents
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.SaveToExel = new System.Windows.Forms.Button();
            this.Component = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Furniture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Component,
            this.Furniture,
            this.Col});
            this.dataGridView.Location = new System.Drawing.Point(-1, 20);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(534, 274);
            this.dataGridView.TabIndex = 0;
            // 
            // SaveToExel
            // 
            this.SaveToExel.Location = new System.Drawing.Point(9, 1);
            this.SaveToExel.Margin = new System.Windows.Forms.Padding(2);
            this.SaveToExel.Name = "SaveToExel";
            this.SaveToExel.Size = new System.Drawing.Size(119, 21);
            this.SaveToExel.TabIndex = 1;
            this.SaveToExel.Text = "Сохранить в Exel";
            this.SaveToExel.UseVisualStyleBackColor = true;
            this.SaveToExel.Click += new System.EventHandler(this.ButtonSaveToExcel_Click);
            // 
            // Component
            // 
            this.Component.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Component.HeaderText = "Компонент";
            this.Component.MinimumWidth = 8;
            this.Component.Name = "Component";
            // 
            // Furniture
            // 
            this.Furniture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Furniture.HeaderText = "Изделие";
            this.Furniture.MinimumWidth = 8;
            this.Furniture.Name = "Furniture";
            // 
            // Col
            // 
            this.Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col.HeaderText = "Количество";
            this.Col.MinimumWidth = 8;
            this.Col.Name = "Col";
            // 
            // FormReportFurnitureComponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 292);
            this.Controls.Add(this.SaveToExel);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormReportFurnitureComponents";
            this.Text = "FormReportProductComponents";
            this.Load += new System.EventHandler(this.FormReportFurnitureComponents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button SaveToExel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Component;
        private System.Windows.Forms.DataGridViewTextBoxColumn Furniture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
    }
}