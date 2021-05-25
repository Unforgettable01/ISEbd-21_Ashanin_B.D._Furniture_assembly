namespace Furniture_assembly
{
    partial class FormMain
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
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.buttonCreateOrder = new System.Windows.Forms.Button();
            this.buttonOrderReady = new System.Windows.Forms.Button();
            this.buttonPayOrder = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изделияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.компонентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.компонентыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изделияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.складыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пополнитьСкладToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокКомпонентовПоСкладамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокИнформацииОЗаказахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокСкладовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(3, 25);
            this.dataGridViewMain.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersWidth = 62;
            this.dataGridViewMain.RowTemplate.Height = 28;
            this.dataGridViewMain.Size = new System.Drawing.Size(1014, 286);
            this.dataGridViewMain.TabIndex = 0;
            // 
            // buttonCreateOrder
            // 
            this.buttonCreateOrder.Location = new System.Drawing.Point(1019, 18);
            this.buttonCreateOrder.Margin = new System.Windows.Forms.Padding(1);
            this.buttonCreateOrder.Name = "buttonCreateOrder";
            this.buttonCreateOrder.Size = new System.Drawing.Size(82, 39);
            this.buttonCreateOrder.TabIndex = 1;
            this.buttonCreateOrder.Text = "Создать заказ";
            this.buttonCreateOrder.UseVisualStyleBackColor = true;
            this.buttonCreateOrder.Click += new System.EventHandler(this.ButtonCreateOrder_Click);
            // 
            // buttonOrderReady
            // 
            this.buttonOrderReady.Location = new System.Drawing.Point(1019, 59);
            this.buttonOrderReady.Margin = new System.Windows.Forms.Padding(1);
            this.buttonOrderReady.Name = "buttonOrderReady";
            this.buttonOrderReady.Size = new System.Drawing.Size(82, 39);
            this.buttonOrderReady.TabIndex = 3;
            this.buttonOrderReady.Text = "Заказ готов";
            this.buttonOrderReady.UseVisualStyleBackColor = true;
            this.buttonOrderReady.Click += new System.EventHandler(this.ButtonOrderReady_Click);
            // 
            // buttonPayOrder
            // 
            this.buttonPayOrder.Location = new System.Drawing.Point(1019, 100);
            this.buttonPayOrder.Margin = new System.Windows.Forms.Padding(1);
            this.buttonPayOrder.Name = "buttonPayOrder";
            this.buttonPayOrder.Size = new System.Drawing.Size(82, 39);
            this.buttonPayOrder.TabIndex = 4;
            this.buttonPayOrder.Text = "Заказ оплачен";
            this.buttonPayOrder.UseVisualStyleBackColor = true;
            this.buttonPayOrder.Click += new System.EventHandler(this.ButtonPayOrder_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(1019, 141);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(1);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(82, 39);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Обновить заказ";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.ButtonRef_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изделияToolStripMenuItem,
            this.компонентыToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // изделияToolStripMenuItem
            // 
            this.изделияToolStripMenuItem.Name = "изделияToolStripMenuItem";
            this.изделияToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.изделияToolStripMenuItem.Text = "Изделия";
            this.изделияToolStripMenuItem.Click += new System.EventHandler(this.ИзделияToolStripMenuItem_Click);
            // 
            // компонентыToolStripMenuItem
            // 
            this.компонентыToolStripMenuItem.Name = "компонентыToolStripMenuItem";
            this.компонентыToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.компонентыToolStripMenuItem.Text = "Компоненты";
            this.компонентыToolStripMenuItem.Click += new System.EventHandler(this.КомпонентыToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem1,
            this.пополнитьСкладToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1135, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem1
            // 
            this.справочникиToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.компонентыToolStripMenuItem1,
            this.изделияToolStripMenuItem1,
            this.складыToolStripMenuItem});
            this.справочникиToolStripMenuItem1.Name = "справочникиToolStripMenuItem1";
            this.справочникиToolStripMenuItem1.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem1.Text = "Справочники";
            // 
            // компонентыToolStripMenuItem1
            // 
            this.компонентыToolStripMenuItem1.Name = "компонентыToolStripMenuItem1";
            this.компонентыToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.компонентыToolStripMenuItem1.Text = "Компоненты";
            this.компонентыToolStripMenuItem1.Click += new System.EventHandler(this.КомпонентыToolStripMenuItem_Click);
            // 
            // изделияToolStripMenuItem1
            // 
            this.изделияToolStripMenuItem1.Name = "изделияToolStripMenuItem1";
            this.изделияToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.изделияToolStripMenuItem1.Text = "Изделия";
            this.изделияToolStripMenuItem1.Click += new System.EventHandler(this.ИзделияToolStripMenuItem_Click);
            // 
            // складыToolStripMenuItem
            // 
            this.складыToolStripMenuItem.Name = "складыToolStripMenuItem";
            this.складыToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.складыToolStripMenuItem.Text = "Склады";
            this.складыToolStripMenuItem.Click += new System.EventHandler(this.складыToolStripMenuItem_Click);
            // 
            // пополнитьСкладToolStripMenuItem
            // 
            this.пополнитьСкладToolStripMenuItem.Name = "пополнитьСкладToolStripMenuItem";
            this.пополнитьСкладToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.пополнитьСкладToolStripMenuItem.Text = "Пополнить склад";
            this.пополнитьСкладToolStripMenuItem.Click += new System.EventHandler(this.пополнениеСкладаToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordОтчетToolStripMenuItem,
            this.excelОтчетToolStripMenuItem,
            this.pDFОтчетToolStripMenuItem,
            this.списокКомпонентовПоСкладамToolStripMenuItem,
            this.списокИнформацииОЗаказахToolStripMenuItem,
            this.списокСкладовToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // wordОтчетToolStripMenuItem
            // 
            this.wordОтчетToolStripMenuItem.Name = "wordОтчетToolStripMenuItem";
            this.wordОтчетToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.wordОтчетToolStripMenuItem.Text = "Список изделий";
            this.wordОтчетToolStripMenuItem.Click += new System.EventHandler(this.списокИзделийToolStripMenuItem_Click);
            // 
            // excelОтчетToolStripMenuItem
            // 
            this.excelОтчетToolStripMenuItem.Name = "excelОтчетToolStripMenuItem";
            this.excelОтчетToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.excelОтчетToolStripMenuItem.Text = "Изделия по компонентам";
            this.excelОтчетToolStripMenuItem.Click += new System.EventHandler(this.ComponentFurnitureToolStripMenuItem_Click);
            // 
            // pDFОтчетToolStripMenuItem
            // 
            this.pDFОтчетToolStripMenuItem.Name = "pDFОтчетToolStripMenuItem";
            this.pDFОтчетToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.pDFОтчетToolStripMenuItem.Text = "Список заказов";
            this.pDFОтчетToolStripMenuItem.Click += new System.EventHandler(this.OrdersToolStripMenuItem_Click);
            // 
            // списокКомпонентовПоСкладамToolStripMenuItem
            // 
            this.списокКомпонентовПоСкладамToolStripMenuItem.Name = "списокКомпонентовПоСкладамToolStripMenuItem";
            this.списокКомпонентовПоСкладамToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.списокКомпонентовПоСкладамToolStripMenuItem.Text = "Список компонентов по складам";
            this.списокКомпонентовПоСкладамToolStripMenuItem.Click += new System.EventHandler(this.списокКомпонентовВСкладахToolStripMenuItem_Click);
            // 
            // списокИнформацииОЗаказахToolStripMenuItem
            // 
            this.списокИнформацииОЗаказахToolStripMenuItem.Name = "списокИнформацииОЗаказахToolStripMenuItem";
            this.списокИнформацииОЗаказахToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.списокИнформацииОЗаказахToolStripMenuItem.Text = "Список информации о заказах";
            this.списокИнформацииОЗаказахToolStripMenuItem.Click += new System.EventHandler(this.списокИнформацииОЗаказахToolStripMenuItem_Click);
            // 
            // списокСкладовToolStripMenuItem
            // 
            this.списокСкладовToolStripMenuItem.Name = "списокСкладовToolStripMenuItem";
            this.списокСкладовToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.списокСкладовToolStripMenuItem.Text = "Список складов";
            this.списокСкладовToolStripMenuItem.Click += new System.EventHandler(this.списокСкладовToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 332);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonPayOrder);
            this.Controls.Add(this.buttonOrderReady);
            this.Controls.Add(this.buttonCreateOrder);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FormMain";
            this.Text = "Сборка мебели";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button buttonCreateOrder;
        private System.Windows.Forms.Button buttonOrderReady;
        private System.Windows.Forms.Button buttonPayOrder;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изделияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem компонентыToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem компонентыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem изделияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem складыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пополнитьСкладToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordОтчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelОтчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFОтчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокКомпонентовПоСкладамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокИнформацииОЗаказахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокСкладовToolStripMenuItem;
    }
}