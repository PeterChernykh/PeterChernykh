using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_Homework22122019
{
    
    public class Room4
    {

        public int numberOfStudents { get; set; }
        public int isTeacher { get; set; }

        public int MaxStudents()
        {
            var maxStudents = new Admin();

            this.numberOfStudents = maxStudents.Revision(numberOfStudents);

            return numberOfStudents;
        }

    }

    public class Room3
    {
        public int numberOfStudents { get; set; }
        public int isTeacher { get; set; }

        public int MaxStudents()
        {
            var maxStudents = new Admin();

            this.numberOfStudents = maxStudents.Revision(numberOfStudents);

            return numberOfStudents;
        }
    }

        public class Room2
        {
            public int numberOfStudents { get; set; }
            public int isTeacher { get; set; }

            public int MaxStudents()
            {
                var maxStudents = new Admin();

                this.numberOfStudents = maxStudents.Revision(numberOfStudents);

                return numberOfStudents;
            }
        }

            public class Room1
            {
                public int numberOfStudents { get; set; }
                public int isTeacher { get; set; }

                public int MaxStudents()
                {
                    var maxStudents = new Admin();

                    this.numberOfStudents = maxStudents.Revision(numberOfStudents);

                    return numberOfStudents;
                }
            }
}
