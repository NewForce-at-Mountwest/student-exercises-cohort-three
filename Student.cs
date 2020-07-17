using System;
using System.Collections.Generic;

namespace student_exercises
{
    class Student
    {

        public Student(string firstNameParam){
            FirstName = firstNameParam;
        }


          // We don't actually NEED to add our primary and foreign keys right now, but we will eventualy. It won't hurt us to add them now, even if we don't really use them.
        public int Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string SlackHandle {get; set;}

        public int Grade {get; set;}
         public int CohortId{get; set;}

        // Even if we add a CohortId property, we should ALSO add a property of type Cohort so that we could display the student's name alongisde the name of their cohort
        public Cohort Cohort {get; set;}

        // We don't need to represent our join table with our C# classes right now, although we would if we were building a database! We can represent the many-to-many relationship with lists of exercises on students and lists of students on exercises. If that doesn't make any sense, don't worry about it too much-- we'll deal with this a lot :)
        public List<Exercise> AssignedExercises {get; set;} = new List<Exercise>();

    }
}