

namespace Planning_Glushchenko
{
    public partial class Day
    {
        private string start_date;
        private string end_date;
        private string start_time;
        private string task;
        private string end_time;
        private string status;
        

        public Day(string start_date, string end_date, string start_time, string task, string end_time,string status)
        {
            this.start_date = start_date;
            this.end_date = end_date;
            this.start_time = start_time;
            this.task = task;
            this.end_time = end_time;
            this.status = status;
        }

        public Day(string[] line)
        {
            start_date = line[0];
            start_time = line[1];
            task = line[2];
            end_date = line[3];
            end_time = line[4];
            status = line[5];
        }

        public string get_start_date()
        {
            return start_date;
        }
        public string get_end_date()
        {
            return end_date;
        }
        public string get_start_time()
        {
            return start_time;
        }

        public string get_end_time()
        {
            return end_time;
        }

        public string getTask()
        {
            return task;
        }

        public void set_start_time(string start_time)
        {
            this.start_time = start_time;
        }

        public void set_end_time(string end_time)
        {
            this.end_time= end_time;
        }

        public void set_start_date(string start_date)
        {
            this.start_date = start_date;
        }

        public void set_end_date(string end_date)
        {
            this.end_date = end_date;
        }

        public void setTask(string task)
        {
            this.task = task;
        }

        public void setStatus(string status)
        {
            this.status = status;
        }

        public string getStatus()
        {
            return status;
        }

        public string getLine()
        {
            return start_date+" " 
                + start_time+" "
                + task +" " 
                + end_date+" " 
                + end_time +" "
                +status;
        }
    }
}
