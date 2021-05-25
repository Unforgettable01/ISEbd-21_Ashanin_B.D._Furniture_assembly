
namespace Furniture_assembly
{
    partial class FormReportStoreHouseComponents
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewReportStoreHouseComponents = new System.Windows.Forms.DataGridView();
            this.StoreHouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Component = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportStoreHouseComponents)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(13, 13);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(197, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Сохранить в Excel";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSaveToExcel_Click);
            // 
            // dataGridViewReportStoreHouseComponents
            // 
            this.dataGridViewReportStoreHouseComponents.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewReportStoreHouseComponents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReportStoreHouseComponents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StoreHouse,
            this.Component,
            this.Count});
            this.dataGridViewReportStoreHouseComponents.Location = new System.Drawing.Point(13, 66);
            this.dataGridViewReportStoreHouseComponents.Name = "dataGridViewReportStoreHouseComponents";
            this.dataGridViewReportStoreHouseComponents.Size = new System.Drawing.Size(731, 359);
            this.dataGridViewReportStoreHouseComponents.TabIndex = 1;
            // 
            // StoreHouse
            // 
            this.StoreHouse.HeaderText = "Склад";
            this.StoreHouse.Name = "StoreHouse";
            // 
            // Component
            // 
            this.Component.HeaderText = "Компонент";
            this.Component.Name = "Component";
            // 
            // Count
            // 
            this.Count.HeaderText = "количество";
            this.Count.Name = "Count";
            // 
            // FormReportStoreHouseComponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewReportStoreHouseComponents);
            this.Controls.Add(this.buttonSave);
            this.Name = "FormReportStoreHouseComponents";
            this.Text = "FormReportStoreHouseComponents";
            this.Load += new System.EventHandler(this.FormReportStoreHouseComponents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportStoreHouseComponents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridViewReportStoreHouseComponents;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Component;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
    }
}