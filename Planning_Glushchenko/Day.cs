

namespace Planning_Glushchenko
{
    public partial class Day
    {
        private string end_date;
        private string task;
        private string end_time;
        private string status;
        

        public Day(string end_date,string task, string end_time,string status)
        { 
            this.end_date = end_date;
            this.task = task;
            this.end_time = end_time;
            this.status = status;
        }

        public Day(string[] line)
        {
            task = line[0];
            end_date = line[1];
            end_time = line[2];
            status = line[3];
        }


        public string get_end_date()
        {
            return end_date;
        }

        public string get_end_time()
        {
            return end_time;
        }

        public string getTask()
        {
            return task;
        }



        public void set_end_time(string end_time)
        {
            this.end_time= end_time;
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
            return task +" " 
                + end_date+" " 
                + end_time +" "
                +status;
        }
    }
}
