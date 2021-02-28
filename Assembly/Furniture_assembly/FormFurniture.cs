using Furniture_assembly_BusinessLogic.BindingModels;
using Furniture_assembly_BusinessLogic.BusinessLogics;
using Furniture_assembly_BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace Furniture_assembly
{
    public partial class FormFurniture : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private readonly FurnitureLogic logic;
        private int? id;
        private Dictionary<int, (string, int)> furnitureComponents;
        public FormFurniture(FurnitureLogic service)
        {
            InitializeComponent();
            this.logic = service;
        }
        private void FormFurniture_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    FurnitureViewModel view = logic.Read(new FurnitureBindingModel
                    {
                        Id = id.Value
                    })?[0];
                    if (view != null)
                    {
                        textBoxName.Text = view.FurnitureName;
                        textBoxPrice.Text = view.Price.ToString();
                        furnitureComponents = view.FurnitureComponents;
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
            else
            {
                furnitureComponents = new Dictionary<int, (string, int)>();
            }
        }
        private void LoadData()
        {
            try
            {
                if (furnitureComponents != null)
                {
                    dataGridViewComponents.Rows.Clear();
                    foreach (var pc in furnitureComponents)
                    {
                        dataGridViewComponents.Rows.Add(new object[] { pc.Key, pc.Value.Item1, pc.Value.Item2 });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormFurnitureComponent>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (furnitureComponents.ContainsKey(form.Id))
                {
                    furnitureComponents[form.Id] = (form.ComponentName, form.Count);
                }
                else
                {
                    furnitureComponents.Add(form.Id, (form.ComponentName, form.Count));
                }
                LoadData();
            }
        }
        private void ButtonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridViewComponents.SelectedRows.Count == 1)
            {

                var form = Container.Resolve<FormFurnitureComponent>();
                int id = Convert.ToInt32(dataGridViewComponents.SelectedRows[0].Cells[0].Value);
                form.Id = id;
                form.Count = furnitureComponents[id].Item2;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    furnitureComponents[form.Id] = (form.ComponentName, form.Count);
                    LoadData();
                }
            }
        }
        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewComponents.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {

                        furnitureComponents.Remove(Convert.ToInt32(dataGridViewComponents.SelectedRows[0].Cells[0].Value));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }
        private void ButtonRef_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPrice.Text))
            {
                MessageBox.Show("Заполните цену", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (furnitureComponents == null || furnitureComponents.Count == 0)
            {
                MessageBox.Show("Заполните компоненты", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                logic.CreateOrUpdate(new FurnitureBindingModel
                {
                    Id = id,
                    FurnitureName = textBoxName.Text,
                    Price = Convert.ToDecimal(textBoxPrice.Text),
                    FurnitureComponents = furnitureComponents
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
    }
}
