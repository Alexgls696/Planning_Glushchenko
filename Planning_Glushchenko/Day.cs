

namespace Planning_Glushchenko
{
    public partial class Day
    {
        public string start_month;
        public string start_time;
        public int start_day;
        public string task;

        public string last_month;
        public string last_time;
        public int last_day;

        public Day(string start_month,int start_day,string start_time, string task, string last_month, int last_day, string last_time) 
        {
            this.start_month = start_month;
            this.start_time = start_time;
            this.task = task;
            this.last_month = last_month;
            this.last_time = last_time;
            this.start_day=start_day;
            this.last_day=last_day;
        }


    }
}
