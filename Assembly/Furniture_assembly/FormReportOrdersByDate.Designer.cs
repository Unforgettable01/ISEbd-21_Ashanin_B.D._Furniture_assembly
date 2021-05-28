
namespace Furniture_assembly
{
    partial class FormReportOrdersByDate
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
            this.ReportOrderByDateViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportOrdersViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerOrders = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReportOrderByDateViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportOrdersViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportOrderByDateViewModelBindingSource
            // 
            this.ReportOrderByDateViewModelBindingSource.DataSource = typeof(Furniture_assembly_BusinessLogic.ViewModels.ReportOrderByDateViewModel);
            // 
            // ReportOrdersViewModelBindingSource
            // 
            this.ReportOrdersViewModelBindingSource.DataSource = typeof(Furniture_assembly_BusinessLogic.ViewModels.ReportOrdersViewModel);
            // 
            // reportViewerOrders
            // 
            this.reportViewerOrders.LocalReport.ReportEmbeddedResource = "Furniture_assembly.ReportOrderByData.rdlc";
            this.reportViewerOrders.Location = new System.Drawing.Point(28, 77);
            this.reportViewerOrders.Name = "reportViewerOrders";
            this.reportViewerOrders.ServerReport.BearerToken = null;
            this.reportViewerOrders.Size = new System.Drawing.Size(644, 253);
            this.reportViewerOrders.TabIndex = 0;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(12, 31);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(93, 31);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormReportOrdersByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.reportViewerOrders);
            this.Name = "FormReportOrdersByDate";
            this.Text = "Заказы по датам";
            this.Load += new System.EventHandler(this.FormReportOrdersByDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportOrderByDateViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportOrdersViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerOrders;
        private System.Windows.Forms.BindingSource ReportOrdersViewModelBindingSource;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.BindingSource ReportOrderByDateViewModelBindingSource;
    }
}