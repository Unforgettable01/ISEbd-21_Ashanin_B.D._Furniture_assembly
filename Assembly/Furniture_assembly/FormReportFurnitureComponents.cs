using Furniture_assembly_BusinessLogic.BindingModels;
using Furniture_assembly_BusinessLogic.BusinessLogics;
using System;
using System.Windows.Forms;
using Unity;

namespace Furniture_assembly
{
    public partial class FormReportFurnitureComponents : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ReportLogic logic;
        public FormReportFurnitureComponents(ReportLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }
        private void FormReportSecureComponents_Load(object sender, EventArgs e)
        {
            try
            {
                var furnitureComponents = logic.GetFurnitureComponent();
                if (furnitureComponents != null)
                {
                    dataGridViewReportFurnitureComponents.Rows.Clear();
                    foreach (var furnitureComponent in furnitureComponents)
                    {
                        dataGridViewReportFurnitureComponents.Rows.Add(new object[]
                        {
                            furnitureComponent.FurnitureName, "", ""
                        });
                        foreach (var listElem in furnitureComponent.Components)
                        {
                            dataGridViewReportFurnitureComponents.Rows.Add(new object[]
                            {
                                "", listElem.Item1, listElem.Item2
                            });
                        }
                        dataGridViewReportFurnitureComponents.Rows.Add(new object[]
                        {
                            "Итого", "", furnitureComponent.TotalCount
                        });
                        dataGridViewReportFurnitureComponents.Rows.Add(new object[] { });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ButtonSaveToExcel_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog { Filter = "xlsx|*.xlsx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        logic.SaveFurnitureComponentToExcelFile(new ReportBindingModel
                        {
                            FileName = dialog.FileName
                        });
                        MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
