using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class DateRec : MenuItemCore
    {

        private Recursiondate recursiondate;

        public override string Title { get { return "Date parse"; } }

        public override void Execute()
        {
            recursiondate = new Recursiondate();
            try
            {
                int H = 0;
                DateTime from1 = IOUtils.SafeReadDate("d1st","Enter Date from1:");
                DateTime to1 = IOUtils.SafeReadDate("d1end","Enter Date to1:");
                DateTime from2 = IOUtils.SafeReadDate("d2st","Enter Date from2:");
                DateTime to2 = IOUtils.SafeReadDate("d2end","Enter Date to2:");
                var intersectionFrom = from1 > from2 ? from1 : from2; // начало пересечения
                var intersectionTo = to1 < to2 ? to1 : to2; // конец пересечения
                if (intersectionFrom > intersectionTo)
                {

                    Console.WriteLine("NO");
                }
                else
                {
                    // можно отнять даты и найти временной промежуток между ними
                    TimeSpan N = intersectionTo - intersectionFrom;
                    H = N.Days + 1;
                    Console.WriteLine(H);
                    recursiondate.Recursion(H);
                    // ну а ваше N это timeSpan.TotalDays + 1

                }
            }
            catch 
            {
                Console.WriteLine("Такого месяца или дня не существует");
            }
        }
    }
}
