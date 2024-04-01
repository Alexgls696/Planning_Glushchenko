namespace Planning_Glushchenko
{


    public partial class Form1 : Form
    {

        private List<Day>calendar_days = new List<Day>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 7;
            set_calendar_days();
            fill_table();
            dataGridView1.Columns[0].HeaderText = "Месяц";
            dataGridView1.Columns[1].HeaderText = "День";
            dataGridView1.Columns[2].HeaderText = "Время";
            dataGridView1.Columns[3].HeaderText = "Задача";
            dataGridView1.Columns[4].HeaderText = "Месяц";
            dataGridView1.Columns[5].HeaderText = "День";
            dataGridView1.Columns[6].HeaderText = "Задача";
        }

        private void fill_table()
        {
            dataGridView1.RowCount = calendar_days.Count+1;
            for(int i = 0; i < calendar_days.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = calendar_days[i].start_month;
                dataGridView1.Rows[i].Cells[1].Value = calendar_days[i].start_day;
                if (calendar_days[i].start_day > DateTime.Now.Day)
                {
                    dataGridView1[1, i].Style.BackColor = Color.Red;
                }
                dataGridView1.Rows[i].Cells[2].Value = calendar_days[i].start_time;
                if ((int.Parse(calendar_days[i].start_time.Split(':')[0]) < DateTime.Now.Hour)
                    &&(calendar_days[i].start_day > DateTime.Now.Day))
                {
                    dataGridView1[2, i].Style.BackColor = Color.Red;
                }
 
                dataGridView1.Rows[i].Cells[3].Value = calendar_days[i].task;
                dataGridView1.Rows[i].Cells[4].Value = calendar_days[i].last_month;
                dataGridView1.Rows[i].Cells[5].Value = calendar_days[i].last_day;
                dataGridView1.Rows[i].Cells[6].Value = calendar_days[i].last_time;
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
                    string[] arr = line.Split(' ');
                    Day day = new Day(arr[0], int.Parse(arr[1]), arr[2], arr[3], arr[4], int.Parse(arr[5]), arr[6]);
                    calendar_days.Add(day);
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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
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
                        + " " + dataGridView1.Rows[i].Cells[5].Value
                        + " " + dataGridView1.Rows[i].Cells[6].Value;
                    if (dataGridView1.Rows[i].Cells[0].Value==null){
                        continue;
                    }
                   /* string tmp = calendar_days[i].start_month + " "
                        + calendar_days[i].start_day + " "
                        + calendar_days[i].start_time + " "
                        + calendar_days[i].task + " "
                        + calendar_days[i].last_month + " "
                        + calendar_days[i].last_day + " "
                        + calendar_days[i].last_time + " ";
                   */
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
            //dataGridView1.AllowUserToAddRows = false;
            DataGridViewRow row = new DataGridViewRow();
            dataGridView1.Rows.Add(row);
        }
    }

    
}