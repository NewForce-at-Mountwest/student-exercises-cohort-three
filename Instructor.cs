using System;
using System.Collections.Generic;

namespace student_exercises
{
    class Instructor
    {

          // We don't actually NEED to add our primary and foreign keys right now, but we will eventualy. It won't hurt us to add them now, even if we don't really use them.
        public int Id {get; set;}
        // These properties are very similar to what's on student. We should probably use inheritance here to make our code less verbose!
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }

        public int CohortId{get; set;}

        // Even if we add a CohortId property, we should ALSO add a property of type Cohort so that we could display the Instructor's name alongisde the name of their cohort
        public Cohort Cohort { get; set; }

        public string Specialty {get; set;}

        // Method that accepts a student and an exercise, and adds the exercise to the student's list of assigned exercises
        
        public void AssignExerciseToStudent(Student victim, Exercise exerciseToAssign){
            // This is all you need for the first part of the practice!
            victim.AssignedExercises.Add(exerciseToAssign);

            //Once you get to the challenge, it asks for a report organized by exercise, so we added a list of students on exercise and we'll add to that too. Again, you don't need this for the practice part, just the challenge
            exerciseToAssign.assignedStudnets.Add(victim);
        }

    }
}