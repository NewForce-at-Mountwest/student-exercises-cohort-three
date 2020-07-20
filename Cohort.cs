using System;
using System.Collections.Generic;

namespace student_exercises
{
    class Cohort
    {

        // We don't actually NEED to add our primary and foreign keys right now, but we will eventualy. It won't hurt us to add them now, even if we don't really use them.
        public int Id {get; set;}
        public string Name {get; set;}

        public List<Student> Students {get; set;} = new List<Student>();
        public List<Instructor> Instructors {get; set;} = new List<Instructor>();

        
    }
}