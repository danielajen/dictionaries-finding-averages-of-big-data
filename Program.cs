using System;
using System.IO;
using System.Collections.Generic;

namespace StartFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "studentdata.txt";
            readData(fileName);
            //copy from here
            /*Please do not modify any of the existing code.  
             * You will just be adding code within the subroutines below.*/

            Dictionary<string, List<string>> Grades = new Dictionary<string, List<string>>();
            //in this dictionary, you will have the student names as your key and the student grades by subject on a list as the values

            void readData()
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] studentData = line.Split('-');
                        string name = studentData[0];
                        string[] gradesData = studentData[1].Split(',');

                        List<string> grades = new List<string>();
                        foreach (string grade in gradesData)
                        {
                            grades.Add(grade);
                        }

                        Grades.Add(name, grades);
                    }
                }
                // in this subroutine, you will open the file and read the data inside.  You will then break up that data into the dictionary Grades

            }

            void findHighestAvg()
            {

                //this subroutine will loop through the dictionary and calculate the average of each student.
                //It will then write the name and average of the student with the highest average.
                //this subroutine will loop through the dictionary and calculate the average of each student.
                //It will then write the name and average of the student with the highest average.
                string highestAvgStudent = "";
                // decimals?
                double highestAvg = 0.0;
                //foreach key in dic
                foreach (KeyValuePair<string, List<string>> student in Grades)
                {
                    double sum = 0.0;
                    int count = 0;

                    // loop thru each subject
                    foreach (string gradeInfo in student.Value)
                    {
                        string[] parts = gradeInfo.Split(':');
                        double grade = double.Parse(parts[1]);
                        sum += grade;
                        count++;
                    }

                    // avg
                    double avg = sum / count;

                    // check if the current student has the highest average so far
                    if (avg > highestAvg)
                    {
                        highestAvgStudent = student.Key;
                        highestAvg = avg;
                    }
                }

                // print 
                Console.WriteLine("Student with the highest average " + highestAvgStudent + " with an oustanding " highestAvg);

            }

        }

        void findLowestAvg()
        {
            //this subroutine will loop through the dictionary and calculate the average of each student.
            //It will then write the name and average of the student with the lowest average.
            string lowestAvgStudent = "";
            // decimals?
            double lowestAvg = 0.0;
            //foreach key in dic
            foreach (KeyValuePair<string, List<string>> student in Grades)
            {
                double sum = 0.0;
                int count = 0;

                // loop thru each subject
                foreach (string gradeInfo in student.Value)
                {
                    string[] parts = gradeInfo.Split(':');
                    double grade = double.Parse(parts[1]);
                    sum += grade;
                    count++;
                }

                // avg
                double avg = sum / count;

                // low avg
                if (avg < lowestAvg)
                {
                    lowestAvgStudent = student.Key;
                    lowestAvg = avg;
                }

                // print 
                Console.WriteLine("Student with the lowest average " + lowestAvgStudent + " with an unfortanate " lowestAvg);


                //this subroutine will loop through the dictionary and calculate the average of each student.
                //It will then write the name and average of the student with the lowest average.

            }

            void findAwardWinner(string subject)
            {
                //this subroutine will take in a subject and find the winner of that subject award.
                double highestAvg = 0;
                string highestAvgName = "";

                foreach (KeyValuePair<string, List<string>> student in Grades)
                {
                    string name = student.Key;
                    List<string> grades = student.Value;

                    double subjectTotal = 0;
                    int subjectCount = 0;

                    // loop 
                    foreach (string grade in grades)
                    {
                        string[] gradez = grade.Split(':');
                        string gradeSubject = gradez[0];
                        double gradenum = double.Parse(gradez[1]);

                        if (gradeSubject == subject)
                        {
                            subjectTotal += gradenum;
                            subjectCount++;
                        }
                    }

                    if (subjectCount > 0)
                    {
                        double subjectAvg = subjectTotal / subjectCount;
                        if (subjectAvg > highestAvg)
                        {
                            highestAvg = subjectAvg;
                            highestAvgName = name;
                        }
                    }
                    Console.WriteLine("award winners for highest average per subject " + subject + highest)
    
            }

                readData();
                findHighestAvg();
                findLowestAvg();
                Console.WriteLine();
                Console.WriteLine("Here are the Winners of the following Awards");
                Console.WriteLine();
                findAwardWinner("Math");
                findAwardWinner("Computers");
                findAwardWinner("Art");
                findAwardWinner("Physics");
                Console.WriteLine("Press Any Key To Exit");
                Console.ReadKey();

                //stop copying here
            }
        }
    }
