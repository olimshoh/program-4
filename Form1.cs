using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
namespace AbiturientApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateButtonsState();
        }
        private void UpdateButtonsState()
        {
            bool hasItems = listBoxAbits.Items.Count > 0;
            bool hasSelected = listBoxAbits.SelectedIndex >= 0;
            Add_ED(true);     
            Change_ED(hasSelected);
            Del_ED(hasSelected);
            Save_ED(hasItems);
            Load_ED(true);     
            Calc_ED(hasItems);
        }
        private void Add_ED(bool Value)
        {
            Add_TSB.Enabled = Value;
            Add_TSMI.Enabled = Value;
            buttonAdd.Enabled = Value;
        }
        private void Change_ED(bool Value)
        {
            buttonChange.Enabled = Value;
            Change_TSB.Enabled = Value;
            Change_TSMI.Enabled = Value;
        }

        private void Del_ED(bool Value)
        {
            buttonDel.Enabled = Value;
            Del_TSB.Enabled = Value;
            Del_TSMI.Enabled = Value;
        }

        private void Save_ED(bool Value)
        {
            Save_TSB.Enabled = Value;
            Save_TSMI.Enabled = Value;
            save_b.Enabled = Value;
        }

        private void Load_ED(bool Value)
        {
            load_b.Enabled = Value;
            Load_TSB.Enabled = Value;
            Load_TSMI.Enabled = Value;
        }

        private void Calc_ED(bool Value)
        {
            Calc_TSB.Enabled = Value;
            Calc_TSMI.Enabled = Value;
            calc_b.Enabled = Value;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Abiturient_F dialog = new Abiturient_F();
            dialog.Text = "Добавление абитуриента";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TAbiturient abiturient = new TAbiturient
                {
                    Familia = dialog.Familia_TB.Text.Trim(),
                    Shkola = Convert.ToInt32(dialog.Shkola_TB.Text.Trim()),
                    Shifr = Convert.ToInt32(dialog.Shifr_TB.Text.Trim()),
                    Balli = Convert.ToInt32(dialog.Balli_TB.Text.Trim())
                };
                listBoxAbits.Items.Add(abiturient);
                UpdateButtonsState(); 
            }
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (listBoxAbits.Items.Count == 0)
            {
                MessageBox.Show("Нет данных для изменения", "Информация");
                return;
            }
            if (listBoxAbits.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран элемент в списке", "Информация");
                return;
            }
            TAbiturient abiturient = listBoxAbits.SelectedItem as TAbiturient;
            if (abiturient == null) return;
            Abiturient_F dialog = new Abiturient_F();
            dialog.Text = "Изменение данных";
            dialog.Familia_TB.Text = abiturient.Familia;
            dialog.Shkola_TB.Text = abiturient.Shkola.ToString();
            dialog.Shifr_TB.Text = abiturient.Shifr.ToString();
            dialog.Balli_TB.Text = abiturient.Balli.ToString();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                abiturient.Familia = dialog.Familia_TB.Text.Trim();
                abiturient.Shkola = Convert.ToInt32(dialog.Shkola_TB.Text.Trim());
                abiturient.Shifr = Convert.ToInt32(dialog.Shifr_TB.Text.Trim());
                abiturient.Balli = Convert.ToInt32(dialog.Balli_TB.Text.Trim());
                listBoxAbits.Items[listBoxAbits.SelectedIndex] = abiturient;
                listBoxAbits.Refresh();
                UpdateButtonsState();
            }
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (listBoxAbits.SelectedIndex != -1)
            {
                listBoxAbits.Items.RemoveAt(listBoxAbits.SelectedIndex);
                if (listBoxAbits.SelectedIndex == -1)
                {
                    ClearStatusLabels();
                }
                UpdateButtonsState();
            }
            else
            {
                MessageBox.Show("Не выбран элемент в списке", "Информация");
            }
        }
        private void save_b_Click(object sender, EventArgs e)
        {
            if (listBoxAbits.Items.Count > 0)
            {
                Save_D.FileName = "SaveAbitts";
                if (Save_D.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(File.Open(Save_D.FileName, FileMode.Create)))
                        {
                            for (int i = 0; i < listBoxAbits.Items.Count; i++)
                            {
                                TAbiturient abiturient = (TAbiturient)listBoxAbits.Items[i];
                                sw.WriteLine(abiturient.Familia);
                                sw.WriteLine(abiturient.Shkola);
                                sw.WriteLine(abiturient.Shifr);
                                sw.WriteLine(abiturient.Balli);
                            }
                        }
                        MessageBox.Show("Данные успешно сохранены!", "Информация");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при сохранении: " + ex.Message, "Ошибка");
                    }
                }
            }
            else
                MessageBox.Show("Нет элементов для сохранения", "Информация");
        }
        private void load_b_Click(object sender, EventArgs e)
        {
            Open_D.FileName = "";
            if (Open_D.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    listBoxAbits.Items.Clear();
                    ClearStatusLabels();
                    using (StreamReader sr = new StreamReader(File.Open(Open_D.FileName, FileMode.Open)))
                    {
                        while (!sr.EndOfStream)
                        {
                            TAbiturient Abiturient = new TAbiturient();
                            Abiturient.Familia = sr.ReadLine(); 
                            Abiturient.Shkola = Convert.ToInt32(sr.ReadLine());  
                            Abiturient.Shifr = Convert.ToInt32(sr.ReadLine());   
                            Abiturient.Balli = Convert.ToInt32(sr.ReadLine());  
                            listBoxAbits.Items.Add(Abiturient);
                        }
                    }
                    UpdateButtonsState();
                    MessageBox.Show($"Загружено {listBoxAbits.Items.Count} записей", "Информация");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке: " + ex.Message, "Ошибка");
                }
            }
        }
        private void calc_b_Click(object sender, EventArgs e)
        {
            if (listBoxAbits.Items.Count > 0)
            {
                listBox1.Items.Clear();

                for (int i = 0; i < listBoxAbits.Items.Count; i++)
                {
                    TAbiturient abiturient = listBoxAbits.Items[i] as TAbiturient;
                    if (abiturient != null)
                    {
                        listBox1.Items.Add(abiturient.Familia +" Шифр-"+ abiturient.Shifr +" №"+ abiturient.Shkola +" балл-"+ abiturient.Balli);
                    }
                }
            }
            else
                MessageBox.Show("Нет элементов для отображения", "Информация");
        }
        private void listBoxAbits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAbits.SelectedIndex >= 0)
            {
                TAbiturient abiturient = (TAbiturient)listBoxAbits.SelectedItem;
                Familia_TSSL.Text = abiturient.Familia;
                Shkola_TSSL.Text = abiturient.Shkola.ToString(); 
                Shifr_TSSL.Text = abiturient.Shifr.ToString();    
                Ball_TSSL.Text = abiturient.Balli.ToString();   
            }
            else
            {
                ClearStatusLabels();
            }
            UpdateButtonsState();
        }
        private void ClearStatusLabels()
        {
            Familia_TSSL.Text = "";
            Shkola_TSSL.Text = "";
            Shifr_TSSL.Text = "";
            Ball_TSSL.Text = "";
        }
    }
}