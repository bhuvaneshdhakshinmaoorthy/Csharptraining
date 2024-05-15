using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;

namespace LinqAssignment1
{
    public class Operation
    {
        public static void Menu()
        {
            TraineeData obj = new TraineeData();
            List<TraineeDetails> traineeDetailsList = obj.GetTraineeDetails();
            System.Console.WriteLine("Enter the number to perform the action");
            int userDecision = int.Parse(Console.ReadLine());
            switch (userDecision)
            {
                // Show the list of Trainee Id
                case 1:
                    {
                        var traineeID = from x in traineeDetailsList
                                        select x;
                        foreach (var i in traineeID)
                        {
                            System.Console.WriteLine(i.TraineeId);
                        }
                        break;
                    }
                // Show the first 3 Trainee Id using Take
                case 2:
                    {
                        var traineeDetailsList1 = traineeDetailsList.Take(3);
                        foreach (var i in traineeDetailsList1)
                        {
                            System.Console.WriteLine(i.TraineeId);
                        }
                        break;
                    }
                //show the last 2 Trainee Id using Skip
                case 3:
                    {
                        var traineeDetailsList1 = traineeDetailsList.Skip(3);
                        foreach (var i in traineeDetailsList1)
                        {
                            System.Console.WriteLine(i.TraineeId);
                        }
                        break;
                    }
                // show the count of Trainee
                case 4:
                    {
                        var traineeDetailsList1 = from x in traineeDetailsList
                                        select x;
                        // foreach (var i in traineeDetailsList1)
                        // {
                        //     System.Console.WriteLine(i);
                        // }
                        System.Console.WriteLine(traineeDetailsList1.Count());
                        break;
                    }
                // show the Trainee Name who are all passed out 2019 or later
                case 5:
                    {
                        var traineeList = from x in traineeDetailsList
                                        where x.YearPassedOut>=2019
                                        select x;
                        foreach (var i in traineeList)
                        {
                            System.Console.WriteLine(i.TraineeName);
                        }
                        break;
                    }
                // show the Trainee Id and Trainee Name by alphabetic order of the trainee name.
                case 6:
                    {
                        var traineeList = from x in traineeDetailsList
                                        orderby x.TraineeName
                                        select x;
                        foreach (var i in traineeList)
                        {
                            System.Console.WriteLine($"{i.TraineeName,-10} {i.TraineeId}" );
                        }
                        break;
                    }
                // show the Trainee Id, Trainee Name, Topic Name, Exercise Name and Mark who are all scores the more than or equal to 4 mark
                case 7:
                    {
                        var traineeList = from x in traineeDetailsList
                                        // where x.ScoreDetails[].Mark>=4
                                        select x;
                        foreach (var i in traineeList)
                        {
                            System.Console.WriteLine($"{i.TraineeName,-10} {i.TraineeId}");
                        }
                        break;
                    }
                // show the unique passed out year using distinct
                case 8:
                    {
                        var traineeList = (from x in traineeDetailsList
                                             select x.YearPassedOut).Distinct();
                        foreach (var i in traineeList)
                        {
                            System.Console.WriteLine(i);
                        }
                        break;
                    }
                // show the total marks of single user (get the Trainee Id from User), if Trainee Id does not exist, show the invalid message
                case 9:
                    {
                        System.Console.WriteLine("Enter trainee ID");
                        string traineeID = Console.ReadLine();
                        var trainee = traineeDetailsList.FirstOrDefault(trainee=> trainee.TraineeId==traineeID);
                        if(trainee!=null)
                        {
                            int totalScore = trainee.ScoreDetails.Sum(trainee=> trainee.Mark);
                            System.Console.WriteLine();
                        }
                        else
                        {
                            System.Console.WriteLine("Invalid ID");
                        }
                        break;
                    }
                // to show the first Trainee Id and Trainee Name
                case 10:
                    {
                        var traineeFirst = traineeDetailsList.First();
                        // foreach (var i in traineeList)
                        // {
                            System.Console.WriteLine($"{traineeFirst.TraineeId} {traineeFirst.TraineeName,-10}");
                        // }
                        break;
                    }
                // to show the last Trainee Id and Trainee Name
                case 11:
                    {
                        var traineeLast = traineeDetailsList.Last();
                        System.Console.WriteLine($"{traineeLast.TraineeId} {traineeLast.TraineeName,-10}");
                        break;
                    }
                // to print the total score of each trainee
                case 12:
                    {
                        foreach (var i in traineeDetailsList)
                        {
                            int totalScore = i.ScoreDetails.Sum(score=>score.Mark);
                            System.Console.WriteLine($"{i.TraineeId} {totalScore}");
                        }
                        break;
                    }
                // to show the minimum total score
                case 13:
                {
                    int maxScore = traineeDetailsList.Max(score=>score.ScoreDetails.Sum(add=>add.Mark));
                    System.Console.WriteLine(maxScore);
                    break;
                }
                // to show the minimum total score
                case 14:
                {
                    int minScore = traineeDetailsList.Min(score=>score.ScoreDetails.Sum(add=>add.Mark));
                    System.Console.WriteLine(minScore);
                    break;
                }
                // to show the average of total score
                case 15:
                {
                    double avgScore = traineeDetailsList.Average(score=>score.ScoreDetails.Sum(add=>add.Mark));
                    System.Console.WriteLine(avgScore);
                    break;
                }
                // to show true or false if any one has the more than 40 score using any()
                case 16:
                {
                    bool more = traineeDetailsList.Any(more=> more.ScoreDetails.Sum(add=>add.Mark)>=40);
                    System.Console.WriteLine(more);
                    break;
                }
                // to show true of false if all of them has the more than 20 using all()
                case 17:
                {
                    bool minimumScore = traineeDetailsList.Any(more=>more.ScoreDetails.Sum(add=>add.Mark)>=20);
                    System.Console.WriteLine(minimumScore);
                    break;
                }
                // to show the Trainee Id, Trainee Name, Topic Name, Exercise Name and Mark by show the Trainee Name as descending order and then show the Mark as descending order.
                case 18:
                {
                    var details = traineeDetailsList.SelectMany(trainee=> trainee.ScoreDetails,(trainee,score)=>
                                    new {trainee.TraineeId,trainee.TraineeName,score.TopicName, score.ExerciseName,score.Mark})
                                    .OrderByDescending(trainee=>trainee.TraineeName).ThenByDescending(score=>score.Mark);
                                    foreach (var detail in details)
                                    {
                                        System.Console.WriteLine($"{detail.TraineeId} {detail.TraineeName} {detail.TopicName} {detail.ExerciseName} {detail.Mark}");
                                    }
                    break;
                }
            }
        }
    }
}