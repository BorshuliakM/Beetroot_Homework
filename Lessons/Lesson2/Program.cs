using Lesson;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<VoteTopic> voteTopics = new List<VoteTopic>();

        while (true)
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Create a vote topic");
            Console.WriteLine("2. Vote on a topic");
            Console.WriteLine("3. View voting results");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the name of the vote topic:");
                    string topicName = Console.ReadLine();

                    Console.WriteLine("Enter the number of options:");
                    int numOptions = Convert.ToInt32(Console.ReadLine());

                    List<string> options = new List<string>();
                    for (int i = 1; i <= numOptions; i++)
                    {
                        Console.WriteLine($"Enter option {i}:");
                        options.Add(Console.ReadLine());
                    }

                    VoteTopic voteTopic = new VoteTopic(topicName, options);
                    voteTopics.Add(voteTopic);
                    Console.WriteLine($"Vote topic '{topicName}' created.");
                    break;

                case 2:
                    Console.WriteLine("Choose a vote topic:");
                    for (int i = 0; i < voteTopics.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {voteTopics[i].TopicName}");
                    }

                    int topicChoice = Convert.ToInt32(Console.ReadLine());
                    VoteTopic chosenTopic = voteTopics[topicChoice - 1];

                    chosenTopic.DisplayOptions();
                    Console.WriteLine("Choose an option:");
                    int optionChoice = Convert.ToInt32(Console.ReadLine());
                    chosenTopic.Vote(optionChoice);
                    break;

                case 3:
                    Console.WriteLine("Choose a vote topic:");
                    for (int i = 0; i < voteTopics.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {voteTopics[i].TopicName}");
                    }

                    int resultChoice = Convert.ToInt32(Console.ReadLine());
                    VoteTopic chosenResult = voteTopics[resultChoice - 1];
                    chosenResult.DisplayResults();
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
