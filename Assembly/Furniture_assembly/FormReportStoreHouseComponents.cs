using Furniture_assembly_BusinessLogic.BindingModels;
using Furniture_assembly_BusinessLogic.BusinessLogics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace Furniture_assembly
{
    public partial class FormReportStoreHouseComponents : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly ReportLogic logic;

        public FormReportStoreHouseComponents(ReportLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void FormReportStoreHouseComponents_Load(object sender, EventArgs e)
        {
            try
            {
                var dict = logic.GetStoreHouseComponent();
                if (dict != null)
                {
                    dataGridViewReportStoreHouseComponents.Rows.Clear();
                    foreach (var elem in dict)
                    {
                        dataGridViewReportStoreHouseComponents.Rows.Add(new object[]
                        {
                            elem.StoreHouseName, "", ""
                        });
                        foreach (var listElem in elem.Components)
                        {
                            dataGridViewReportStoreHouseComponents.Rows.Add(new object[]
                            {
                                "", listElem.Item1, listElem.Item2
                            });
                        }
                        dataGridViewReportStoreHouseComponents.Rows.Add(new object[]
                        {
                            "Итого", "", elem.TotalCount
                        });
                        dataGridViewReportStoreHouseComponents.Rows.Add(new object[] { });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
MessageBoxIcon.Error);
            }
        }

        private void buttonSaveToExcel_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog { Filter = "xlsx|*.xlsx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        logic.SaveStoreHouseComponentsToExcel(new ReportBindingModel
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
