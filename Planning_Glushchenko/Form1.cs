using System;

namespace Planning_Glushchenko
{


    public partial class Form1 : Form
    {
        private int SelectedRowIndex = -1; //Для изменения значений
        private int SelectedRowIndex2 = -1; //Для удаления значений
        private List<Day> calendar_days = new List<Day>();
        string last_value = string.Empty;
        public Form1()
        {

            InitializeComponent();
            dataGridView1.ColumnCount = 6;
            dataGridView1.AllowUserToAddRows = false;
            set_calendar_days();
            fill_table();
            add_rows_index();
            check_cells();
            SelectedRowIndex = -1;
        }

        private void add_rows_index()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = string.Format((i + 1).ToString(), "0");
            }
            dataGridView1.Columns[0].HeaderText = "Дата";
            dataGridView1.Columns[1].HeaderText = "Время";
            dataGridView1.Columns[2].HeaderText = "Задача";
            dataGridView1.Columns[3].HeaderText = "Дата ок.";
            dataGridView1.Columns[4].HeaderText = "Время ок.";
            dataGridView1.Columns[5].HeaderText = "Статус";
        }

        private void fill_table()
        {
            dataGridView1.RowCount = calendar_days.Count;
            for (int i = 0; i < calendar_days.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = calendar_days[i].get_start_date();
                dataGridView1.Rows[i].Cells[1].Value = calendar_days[i].get_start_time();
                dataGridView1.Rows[i].Cells[2].Value = calendar_days[i].getTask();
                dataGridView1.Rows[i].Cells[3].Value = calendar_days[i].get_end_date();
                dataGridView1.Rows[i].Cells[4].Value = calendar_days[i].get_end_time();
                dataGridView1.Rows[i].Cells[5].Value = calendar_days[i].getStatus();
            }
        }
        private void set_calendar_days()
        {
            try
            {
                StreamReader reader = new StreamReader("Calendar_day.txt");
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    calendar_days.Add(new Day(line.Split(' ')));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка открытия файла"); return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                StreamWriter reader = new StreamWriter("Calendar_day.txt");
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string tmp = dataGridView1.Rows[i].Cells[0].Value
                        + " " + dataGridView1.Rows[i].Cells[1].Value
                        + " " + dataGridView1.Rows[i].Cells[2].Value
                        + " " + dataGridView1.Rows[i].Cells[3].Value
                        + " " + dataGridView1.Rows[i].Cells[4].Value
                        + " " + dataGridView1.Rows[i].Cells[5].Value;
                    if (dataGridView1.Rows[i].Cells[0].Value == null)
                    {
                        continue;
                    }
                    reader.WriteLine(tmp);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка открытия файла"); return;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            dataGridView1.Rows.Add(row);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = string.Format((i + 1).ToString(), "0");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectedRowIndex2 = e.RowIndex;
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            if (SelectedRowIndex2 >= 0 && SelectedRowIndex2 < dataGridView1.Rows.Count - 1)
            {
                dataGridView1.Rows.RemoveAt(SelectedRowIndex);
                error_label.Visible = false;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].HeaderCell.Value = string.Format((i + 1).ToString(), "0");
                }
            }
            else
            {
                error_label.Text = "Выберите строку"; error_label.Visible = true;
            }
        }


        private void time_check(string[] time_split, int index)
        {
            if (int.Parse(time_split[0]) < DateTime.Now.Hour)
            {
                dataGridView1.Rows[index].Cells[4].Style.BackColor = Color.Red; return;
            }
            if (int.Parse(time_split[1]) < DateTime.Now.Minute)
            {
                dataGridView1.Rows[index].Cells[4].Style.BackColor = Color.Red; return;
            }
            dataGridView1.Rows[index].Cells[4].Style.BackColor = Color.Green;
        }
        private void status_check(string value, string time, int index)//Проверка даты и времени завершения
        {
            string[] split = value.Split('.');
            string[] time_split = time.Split(":");
            if (dataGridView1.Rows[index].Cells[5].Value.Equals("NO"))
            {
                dataGridView1.Rows[index].Cells[5].Style.BackColor = Color.Red;
            }
            else
            {
                if (dataGridView1.Rows[index].Cells[5].Value.Equals("OK"))
                {
                    dataGridView1.Rows[index].Cells[5].Style.BackColor = Color.Green;
                }
            }
            if (int.Parse(split[2]) < DateTime.Now.Year)
            {
                dataGridView1.Rows[index].Cells[3].Style.BackColor = Color.Red; time_check(time_split, index); return;
            }
            if (int.Parse(split[1]) < DateTime.Now.Month)
            {
                dataGridView1.Rows[index].Cells[3].Style.BackColor = Color.Red; time_check(time_split, index); return;
            }
            if (int.Parse(split[0]) < DateTime.Now.Day)
            {
                dataGridView1.Rows[index].Cells[3].Style.BackColor = Color.Red; time_check(time_split, index); return;
            }
            dataGridView1.Rows[index].Cells[3].Style.BackColor = Color.Green;
            dataGridView1.Rows[index].Cells[4].Style.BackColor = Color.Green;
        }
        private void check_cells()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                status_check(dataGridView1.Rows[i].Cells[3].Value.ToString(), dataGridView1.Rows[i].Cells[4].Value.ToString(), i);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //Обработка событий изменения ячейки
        {
            SelectedRowIndex = e.RowIndex;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e) //Изменение содержимого в столбцах
        {
            if (SelectedRowIndex != -1)
            {
                if (e.ColumnIndex == 0) //Изменение даты начала
                {
                    string alp = "0123456789.";
                    int count = 0;
                    string line = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (alp.Contains(line[i]))
                        {
                            count++;
                        }
                    }
                    if (count != last_value.Length)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = last_value;
                    }
                }
                if (e.ColumnIndex == 1)
                {
                    string alp = "0123456789:";
                    int count = 0;
                    string line = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (alp.Contains(line[i]))
                        {
                            count++;
                        }
                    }
                    if (count != last_value.Length)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = last_value;
                    }
                    string[]split = line.Split(':');
                    if (int.Parse(split[0])>23|| int.Parse(split[1]) >= 60)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = last_value;
                    }
                }
                if (e.ColumnIndex == 4)
                {
                    string alp = "0123456789:";
                    int count = 0;
                    string line = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (alp.Contains(line[i]))
                        {
                            count++;
                        }
                    }
                    if (count != last_value.Length)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = last_value;
                    }
                    string[] split = line.Split(':');
                    if (int.Parse(split[0]) > 23 || int.Parse(split[1]) >= 60)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = last_value;
                    }
                }
                if (e.ColumnIndex == 5)
                {
                    string alp = "0123456789:";
                    int count = 0;
                    string line = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    if (!line.Equals("OK"))
                    {
                        if (line.Equals("NO"))
                        {
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red; return;
                        }
                        else
                        {
                            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = last_value; return;
                        }
                    }
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Green;
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRowIndex = e.ColumnIndex;
            last_value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (e.ColumnIndex != -1)
            {
                SelectedRowIndex = e.ColumnIndex;
                last_value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }
    }
}