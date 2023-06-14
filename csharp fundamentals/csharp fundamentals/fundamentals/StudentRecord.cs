using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_fundamentals.fundamentals
{
    public class StudentRecordSystem
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public int TotalMarks { get; set; }
        public int TotalSubject { get; set; }


        public void ShowAverage()
        {
            Console.WriteLine("THe average is sfddadasdasd :" + (TotalMarks / TotalSubject));
        }




    }
}
