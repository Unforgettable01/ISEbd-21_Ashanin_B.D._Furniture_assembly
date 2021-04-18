using Furniture_assembly_BusinessLogic.BindingModels;
using Furniture_assembly_BusinessLogic.BusinessLogics;
using Furniture_assembly_BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace Furniture_assembly
{
    public partial class FormCreateOrder : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly FurnitureLogic _logicP;
        private readonly OrderLogic _logicO;
        private readonly ClientLogic _logicClient;

        public FormCreateOrder(FurnitureLogic logicP, OrderLogic logicO, ClientLogic logicClient)
        {
            InitializeComponent();
            _logicP = logicP;
            _logicO = logicO;
            _logicClient = logicClient;
        }
        private void FormCreateOrder_Load(object sender, EventArgs e)
        {
            try
            {
                var furnitures = _logicP.Read(null);
                var clients = _logicClient.Read(null);
                comboBoxFurniture.DataSource = furnitures;
                comboBoxFurniture.DisplayMember = "FurnitureName";
                comboBoxFurniture.ValueMember = "Id";
                comboBoxClient.DataSource = clients;
                comboBoxClient.DisplayMember = "ClientFIO";
                comboBoxClient.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcSum()
        {
            if (comboBoxFurniture.SelectedValue != null &&
           !string.IsNullOrEmpty(textBoxCount.Text))
            {
                try
                {
                    int id = Convert.ToInt32(comboBoxFurniture.SelectedValue);
                    FurnitureViewModel product = _logicP.Read(new FurnitureBindingModel
                    { Id = id})?[0];
                    int count = Convert.ToInt32(textBoxCount.Text);
                    textBoxSum.Text = (count * product?.Price ?? 0).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
        private void TextBoxCount_TextChanged(object sender, EventArgs e)
        {
            CalcSum();
        }
        private void ComboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcSum();
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(textBoxCount.Text))
            {
                MessageBox.Show("Заполните поле Количество", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxFurniture.SelectedValue == null)
            {
                MessageBox.Show("Выберите изделие", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                _logicO.CreateOrder(new CreateOrderBindingModel
                {
                    FurnitureId = Convert.ToInt32(comboBoxFurniture.SelectedValue),
                    Count = Convert.ToInt32(textBoxCount.Text),
                    ClientId = Convert.ToInt32(comboBoxClient.SelectedValue),
                    Sum = Convert.ToDecimal(textBoxSum.Text)
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void textBoxSum_TextChanged(object sender, EventArgs e)
        {
            CalcSum();
        }
    }
}
