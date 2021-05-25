
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
            this.dataGridViewReportFurnitureComponents = new System.Windows.Forms.DataGridView();
            this.Component = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Furniture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveToExel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportFurnitureComponents)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReportFurnitureComponents
            // 
            this.dataGridViewReportFurnitureComponents.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewReportFurnitureComponents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReportFurnitureComponents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Component,
            this.Furniture,
            this.Col});
            this.dataGridViewReportFurnitureComponents.Location = new System.Drawing.Point(-1, 71);
            this.dataGridViewReportFurnitureComponents.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewReportFurnitureComponents.Name = "dataGridViewReportFurnitureComponents";
            this.dataGridViewReportFurnitureComponents.RowHeadersWidth = 62;
            this.dataGridViewReportFurnitureComponents.RowTemplate.Height = 28;
            this.dataGridViewReportFurnitureComponents.Size = new System.Drawing.Size(534, 223);
            this.dataGridViewReportFurnitureComponents.TabIndex = 0;
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
            // FormReportFurnitureComponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 292);
            this.Controls.Add(this.SaveToExel);
            this.Controls.Add(this.dataGridViewReportFurnitureComponents);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormReportFurnitureComponents";
            this.Text = "FormReportProductComponents";
            this.Load += new System.EventHandler(this.FormReportSecureComponents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportFurnitureComponents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReportFurnitureComponents;
        private System.Windows.Forms.Button SaveToExel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Component;
        private System.Windows.Forms.DataGridViewTextBoxColumn Furniture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
    }
}