using System;
using System.Collections.Generic;

namespace student_exercises
{
    class Exercise
    {

        // We don't actually NEED to add our primary and foreign keys right now, but we will eventualy. It won't hurt us to add them now, even if we don't really use them.
        public int Id {get; set;}
        public string Name {get; set;}

        public string Langauge {get; set;}

        // This isn't necessary until you get to the challenges!
        // In the challenges, it asks for a report of which exercises are assigned to which student, which implies that it wants to see an exercise name and then a list of students who are working on it
        // We can add a list of students on exercises, and add a line to our method in instructors that will take care of this for us
        // Go check out the method in instructors to see where we're adding to this list
        public List<Student> assignedStudnets {get; set;} = new List<Student>();
    }
}