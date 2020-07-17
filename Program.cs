using System;
using System.Collections.Generic;

namespace student_exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            // Let's create some exercises!
            Exercise chickenMonkey = new Exercise(){
                Name = "Chicken Monkey",
                Langauge= "JavaScript"
            };

            Exercise battleOfTheBands = new Exercise(){
                Name = "Battle of the Bands",
                Langauge= "JavaScript"
            };

            Exercise kennel = new Exercise(){
                Name = "Kennel",
                Langauge= "JavaScript"
            };

            // Create some cohorts
            Cohort cohortOne = new Cohort(){
                Name = "Cohort One"
            };

             Cohort cohortTwo = new Cohort(){
                Name = "Cohort Two"
            };

            Cohort cohortThree = new Cohort(){
                Name = "Cohort Three"
            };

            // Create some students
            Student sydney = new Student("Sydney"){
                LastName = "Wait",
                Cohort = cohortOne // Assign sydney's cohort
            };

            cohortOne.Students.Add(sydney); // add sydney to cohort one's list of students

            Student daryl = new Student("Daryl"){
                LastName = "Adkins",
                Cohort = cohortTwo,
                CohortId = 1
            };

            cohortTwo.Students.Add(daryl);

            Student caleb = new Student("Caleb"){
                LastName = "Meadows",
                Cohort = cohortTwo
            };

            cohortTwo.Students.Add(caleb);

            // Create some instructors
            Instructor tommy = new Instructor(){
                FirstName = "Tommy",
                LastName = "Spurlock",
                Specialty = "Pep talks",
                Cohort = cohortThree

            };

            Instructor jordan = new Instructor(){
                FirstName = "Jordan",
                LastName = "Castelloe",
                Specialty = "SUFFERING",
                Cohort = cohortThree
            };

            // We can use .AddRange() instead of .Add() to add both of our instructors at once
            cohortThree.Instructors.AddRange(new List<Instructor>(){tommy, jordan});

            // Assign some exercises!
            tommy.AssignExerciseToStudent(daryl, chickenMonkey);
            tommy.AssignExerciseToStudent(caleb, kennel);
            jordan.AssignExerciseToStudent(daryl, battleOfTheBands);
            jordan.AssignExerciseToStudent(sydney, kennel);


            // ------------- CHALLENGES ---------------------//
            List<Student> allTheStudents = new List<Student>(){daryl, caleb, sydney};

            List<Exercise> allTheExercises = new List<Exercise>(){chickenMonkey, battleOfTheBands, kennel};

            Console.WriteLine("Welcome! What would you like to do?");
            Console.WriteLine("1. See a report of which students are working on which exercise");
            Console.WriteLine("2. Create a student");
            Console.WriteLine("3. Exit");
            string response = Console.ReadLine();
            if(response == "1"){
                allTheExercises.ForEach(exercise => {
                    Console.WriteLine(exercise.Name);
                    Console.WriteLine("---------------");
                    exercise.assignedStudnets.ForEach(student => Console.WriteLine($"{student.FirstName} {student.LastName}"));
                    Console.WriteLine();
                });
            } else if (response == "2"){
                Console.WriteLine("Let's create a student!");
                Console.WriteLine("What's the student's first name?");
                string firstNameInput = Console.ReadLine();
                Console.WriteLine("What's the student's last name?");
                string lastNameInput = Console.ReadLine();

                Console.WriteLine("What's the student's grade");

                 // instantiate a new student with the info the user entered
                Student userInputStudent = new Student(firstNameInput){
                    LastName = lastNameInput
                };

                try {
                    userInputStudent.Grade = Int32.Parse(Console.ReadLine());
                } catch (FormatException){
                    Console.WriteLine("Please enter a number for the student's grade");
                }

                Console.WriteLine($"Your student's name is {userInputStudent.FirstName} {userInputStudent.LastName} and their grade is {userInputStudent.Grade}");
            }

















        }
    }
}
