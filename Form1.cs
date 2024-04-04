using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
using NUnit.Framework.Internal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Logger = NLog.Logger;

namespace homework_15
{
    public partial class Form1 : Form
    {
        private static Logger Logger = LogManager.GetCurrentClassLogger();

        private Timer timer;

        Form2 newForm = new Form2();        

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GuestTable.CellDoubleClick += GuestTable_CellDoubleClick;
        }

        private void FillDataGridView(string status)
        {
            try
            {
                string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string databasePath = currentDirectory + "Database.mdf";
                string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databasePath};Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "";
                    switch (status)
                    {
                        case "free":
                            query = "SELECT id, name, arrivaldate, departuredate, dateofbirth, number, payment, pet, picture FROM Guests WHERE Status = 'free'";
                            break;
                        case "busy":
                            query = "SELECT id, name, arrivaldate, departuredate, dateofbirth, number, payment, pet, picture  FROM Guests WHERE Status = 'busy'";
                            break;
                        case "registered":
                            query = "SELECT id, name, arrivaldate, departuredate, dateofbirth, number, payment, pet, picture FROM Guests WHERE Status = 'registered'";
                            break;
                        case "discharged":
                            query = "SELECT id, name, arrivaldate, departuredate, dateofbirth, number, payment, pet, picture  FROM Guests WHERE Status = 'discharged'";
                            break;
                        case "all":
                            query = "SELECT id, name, arrivaldate, departuredate, dateofbirth, number, payment, pet, picture  FROM Guests";
                            break;
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    GuestTable.DataSource = dataTable;

                    GuestTable.Columns[1].HeaderText = "Имя";
                    GuestTable.Columns[4].HeaderText = "День рождения";
                    GuestTable.Columns[5].HeaderText = "Номер";

                    GuestTable.Columns["id"].Visible = false;
                    GuestTable.Columns["arrivaldate"].Visible = false;
                    GuestTable.Columns["departuredate"].Visible = false;
                    GuestTable.Columns["payment"].Visible = false;
                    GuestTable.Columns["pet"].Visible = false;
                    GuestTable.Columns["picture"].Visible = false;
                }

                Logger.Info($"Таблица GuestTable заполнена данными");
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "В методе FillDataGridView произошла ошибка");
            }            
        }

        private void registered_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView("registered");
                Logger.Info("Флажок 'Зарезервировано' установлен");
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Произошла ошибка в registered_CheckedChanged_1");
            }
        }

        private void busy_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView("busy");
                Logger.Info("Флажок 'Зарезервировано' установлен");
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Произошла ошибка в registered_CheckedChanged_1");
            }
        }

        private void free_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView("free");
                Logger.Info("Флажок 'Зарезервировано' установлен");
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Произошла ошибка в registered_CheckedChanged_1");
            }
        }

        private void discharged_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView("discharged");
                Logger.Info("Флажок 'Зарезервировано' установлен");
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Произошла ошибка в registered_CheckedChanged_1");
            }
        }

        private void all_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView("all");
                Logger.Info("Флажок 'Зарезервировано' установлен");
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Произошла ошибка в registered_CheckedChanged_1");
            }            
        }

        private void GuestTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    object cellValue1 = GuestTable.Rows[e.RowIndex].Cells["number"].Value;
                    Number.Text = $"Номер №: {cellValue1}";

                    object cellValue2 = GuestTable.Rows[e.RowIndex].Cells["name"].Value;
                    FIO.Text = $"{cellValue2}";
                    newForm.FIO.Text = $"{cellValue2}";

                    object cellValue3 = GuestTable.Rows[e.RowIndex].Cells["dateofbirth"].Value;
                    newForm.dateofbirth.Text = $"{FormatDate1(cellValue3)}";

                    object cellValue4 = GuestTable.Rows[e.RowIndex].Cells["arrivaldate"].Value;
                    arrivaldate.Text = $"Дата заезда: {FormatDate(cellValue4)}";

                    object cellValue5 = GuestTable.Rows[e.RowIndex].Cells["departuredate"].Value;
                    departuredate.Text = $"Дата выезда: {FormatDate(cellValue5)}";

                    DateTime arrival = Convert.ToDateTime(cellValue4);
                    DateTime departure = Convert.ToDateTime(cellValue5);
                    int days = (int)(departure - arrival).TotalDays;
                    newForm.days.Text = $"Продолжительность пребывания: {days} дней";

                    object cellValue6 = GuestTable.Rows[e.RowIndex].Cells["payment"].Value;
                    newForm.payment.Text = $"Оплата: {cellValue6}";

                    object cellValue7 = GuestTable.Rows[e.RowIndex].Cells["pet"].Value;
                    string changedcellValue7 = Convert.ToString(cellValue7);
                    string newcellValue7 = RemoveSpaces(changedcellValue7);

                    if (newcellValue7 == "YES")
                    {
                        newForm.pet.Checked = true;
                    }

                    if (newcellValue7 == "NO")
                    {
                        newForm.pet.Checked = false;
                    }

                    newForm.pet.Enabled = false;

                    object cellValue8 = GuestTable.Rows[e.RowIndex].Cells["picture"].Value;
                    string changedcellValue8 = Convert.ToString(cellValue8);
                    string newcellValue8 = RemoveSpaces(changedcellValue8);
                    string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                    string picture = Path.GetDirectoryName(path);
                    string picture1 = Path.GetDirectoryName(picture);
                    string picture2 = Path.Combine(picture1, newcellValue8);
                    Image image = Image.FromFile(picture2);
                    pictureBox2.BackgroundImage = image;
                }

                if (registered.Checked)
                {
                    Status.Text = $"Статус: Зарезервировано";
                }

                if (free.Checked)
                {
                    Status.Text = $"Статус: Свободно";
                }

                if (busy.Checked)
                {
                    Status.Text = $"Статус: Занято";
                }

                if (discharged.Checked)
                {
                    Status.Text = $"Статус: Выписываются";
                }
                Logger.Info("Информация из таблицы успешно передана");
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "В методе GuestTable_CellDoubleClick произошла ошибка");
            }            
        }

        private string FormatDate(object dateValue)
        {
            DateTime date;
            if (DateTime.TryParse(dateValue.ToString(), out date))
            {
                return date.ToString("dd.MM.yy");
            }
            else
            {
                return string.Empty;
            }
        }

        public string RemoveSpaces(string input)
        {
            return input.Replace(" ", string.Empty);
        }

        private string FormatDate1(object dateValue)
        {
            DateTime date;
            if (DateTime.TryParse(dateValue.ToString(), out date))
            {
                return date.ToString("dd.MM.yyyy");
            }
            else
            {
                return string.Empty;
            }
        }

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Find_Click(object sender, EventArgs e)
        {
            try
            {
                string userInput = SearchBar.Text;

                DataTable dt = (DataTable)GuestTable.DataSource;

                DataTable filteredTable = new DataTable();
                filteredTable = dt.Clone();

                foreach (DataRow row in dt.Rows)
                {
                    bool found = false;

                    foreach (DataColumn col in dt.Columns)
                    {
                        if (GuestTable.Columns[col.ColumnName].Visible && row[col.ColumnName].ToString().IndexOf(userInput, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            found = true;
                            break;
                        }
                    }

                    if (found)
                    {
                        filteredTable.ImportRow(row);
                    }
                }

                GuestTable.DataSource = null;
                GuestTable.Rows.Clear();
                GuestTable.Columns.Clear();

                GuestTable.DataSource = filteredTable;

                GuestTable.Columns[1].HeaderText = "Имя";
                GuestTable.Columns[4].HeaderText = "День рождения";
                GuestTable.Columns[5].HeaderText = "Номер";

                GuestTable.Columns["id"].Visible = false;
                GuestTable.Columns["arrivaldate"].Visible = false;
                GuestTable.Columns["departuredate"].Visible = false;
                GuestTable.Columns["payment"].Visible = false;
                GuestTable.Columns["pet"].Visible = false;
                GuestTable.Columns["picture"].Visible = false;
                Logger.Info("Произведен поиск гостя");
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Произошла ошибка в Find_Click");
            }
            
        }

        private void ViewCard_Click(object sender, EventArgs e)
        {
            newForm.Show();
        }
    
        private void SearchBar_Click(object sender, EventArgs e)
        {
            indicator.Text = "";
        }             
    }
}
