
namespace Furniture_assembly
{
    partial class FormImplementer
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
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.textBoxWorkingTime = new System.Windows.Forms.TextBox();
            this.textBoxPauseTime = new System.Windows.Forms.TextBox();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelWorkingTime = new System.Windows.Forms.Label();
            this.labelPauseTime = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(236, 23);
            this.textBoxFIO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(148, 26);
            this.textBoxFIO.TabIndex = 0;
            // 
            // textBoxWorkingTime
            // 
            this.textBoxWorkingTime.Location = new System.Drawing.Point(236, 58);
            this.textBoxWorkingTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxWorkingTime.Name = "textBoxWorkingTime";
            this.textBoxWorkingTime.Size = new System.Drawing.Size(148, 26);
            this.textBoxWorkingTime.TabIndex = 1;
            // 
            // textBoxPauseTime
            // 
            this.textBoxPauseTime.Location = new System.Drawing.Point(236, 98);
            this.textBoxPauseTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPauseTime.Name = "textBoxPauseTime";
            this.textBoxPauseTime.Size = new System.Drawing.Size(148, 26);
            this.textBoxPauseTime.TabIndex = 2;
            // 
            // labelFIO
            // 
            this.labelFIO.Location = new System.Drawing.Point(137, 26);
            this.labelFIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(52, 23);
            this.labelFIO.TabIndex = 3;
            this.labelFIO.Text = "ФИО";
            // 
            // labelWorkingTime
            // 
            this.labelWorkingTime.Location = new System.Drawing.Point(74, 58);
            this.labelWorkingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWorkingTime.Name = "labelWorkingTime";
            this.labelWorkingTime.Size = new System.Drawing.Size(128, 23);
            this.labelWorkingTime.TabIndex = 4;
            this.labelWorkingTime.Text = "Время работы";
            // 
            // labelPauseTime
            // 
            this.labelPauseTime.Location = new System.Drawing.Point(58, 101);
            this.labelPauseTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPauseTime.Name = "labelPauseTime";
            this.labelPauseTime.Size = new System.Drawing.Size(170, 23);
            this.labelPauseTime.TabIndex = 5;
            this.labelPauseTime.Text = "Время перерыва";
            // 
            // buttonSave
            // 
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSave.Location = new System.Drawing.Point(61, 149);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(128, 50);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCancel.Location = new System.Drawing.Point(226, 149);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(128, 50);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormImplementer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 229);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelPauseTime);
            this.Controls.Add(this.labelWorkingTime);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.textBoxPauseTime);
            this.Controls.Add(this.textBoxWorkingTime);
            this.Controls.Add(this.textBoxFIO);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormImplementer";
            this.Text = "FormImplementer";
            this.Load += new System.EventHandler(this.FormImplementer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.TextBox textBoxWorkingTime;
        private System.Windows.Forms.TextBox textBoxPauseTime;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelWorkingTime;
        private System.Windows.Forms.Label labelPauseTime;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}