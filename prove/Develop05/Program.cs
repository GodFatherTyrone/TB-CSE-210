using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using Goal_Objects;
class Program
{
    private List<Goal> _goalslist = new List<Goal>();
    private int _totalpoints = 0;
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        Console.WriteLine("This is Eternal Quest Program");

        Program program1 = new Program();
        Console.Clear();
        program1.Run_Goal_Program();
    }
    public void Run_Goal_Program()
    {
        string _navigation;
        Console.WriteLine("Eternal Quest Program Start");
        do{
            Console.WriteLine($"\nYou have {_totalpoints} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Progress");
            Console.WriteLine(" 6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            _navigation = Console.ReadLine();
            Console.Clear();

            if (_navigation == "1") // 1. Create New Goal
            {
                Console.WriteLine("You have chosen to create a new goal. ");
                Create_New_Goal();
            }
            else if (_navigation == "2") // 2. List Goals
            {
                Display_Goals();
            }
            else if (_navigation == "3") // 3. Save Goals
            {
                Console.WriteLine("You have chosen to save your current list of goals. ");
                Save_GoalsList_Json();
            }
            else if (_navigation == "4") // 4. Load Goals
            {
                Console.WriteLine("You have chosen to load your list of goals from a seperate file. ");
                Load_GoalsList_Json();
            }
            else if (_navigation == "5") // 5. Record Progress
            {
                Console.WriteLine("You have chosen to record your goal's progress. ");
                Record_Goal_Progress();
            }
            else if (_navigation == "6")// 6. Quit
            {
                Console.WriteLine("Thank you for useing Eternal Quest Program. \nHave a nice day!");
                for (int i = 3; i > 0; i--) //counts down (per sec) from i
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
            }
            else
            {
                Console.WriteLine("Sorry, I didn't quite catch that? Please try again: \n");
                
            }
        }while (_navigation != "6");
    }
    private void Create_New_Goal()
    {
        Console.WriteLine("\nThe Types of goals you can create are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.WriteLine("Which Type of goal whould you like to create? ");
        string _answer = Console.ReadLine();
        Console.WriteLine("What is the name of your goal? ");
        string _newname = Console.ReadLine();
        Console.WriteLine("What is a short description of it? ");
        string _newdescription = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        int _newgoalpoints = int.Parse(Console.ReadLine()); //Crashes if input is not a number

        if (_answer == "1")
        {
            SimpleGoal simple1 = new SimpleGoal(_newname, _newdescription, _newgoalpoints);
            _goalslist.Add(simple1);
            Console.Clear();
            Console.WriteLine($"You have created and added the goal: \n{simple1.Get_Goal()}");
        }
        else if (_answer == "2")
        {
            EternalGoal eternal1 = new EternalGoal(_newname, _newdescription, _newgoalpoints);
            _goalslist.Add(eternal1);
            Console.Clear();
            Console.WriteLine($"You have created and added the goal: \n{eternal1.Get_Goal()}");
        }
        else if (_answer == "3")
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
            int _newgoalstreak = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing is that many times? ");
            int _newgoalbonuspoints = int.Parse(Console.ReadLine()); //Crashes if input is not a number

            ChecklistGoal checklist1 = new ChecklistGoal(_newname, _newdescription, _newgoalpoints, _newgoalstreak, _newgoalbonuspoints);
            _goalslist.Add(checklist1);
            Console.Clear();
            Console.WriteLine($"You have created and added the goal: \n{checklist1.Get_Goal()}");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Sorry, your type of goal was invalid. Please try again:");
        }
    }
    private void Display_Goals()
    {   
        if (_goalslist.Count() == 0)
        {
            Console.WriteLine("You currently have no Goals. ");
        }
        else
        {
            Console.WriteLine("Here are your current goals: ");
            int i = 1;
            foreach(Goal goal in _goalslist)
            {
                string _checkmark = "[ ]";
                if (goal is SimpleGoal simple)
                {
                    bool _hasbeencompleted = simple.Get_Goal_Completed();
                    if (_hasbeencompleted)
                    {
                        _checkmark = "[X]";
                    }  
                }
                else if (goal is ChecklistGoal checklist)
                {
                    int _goalstreak = checklist.Get_Goal_Streak();
                    int _goalcompletion = checklist.Get_Goal_completion();
                    if (_goalstreak >= _goalcompletion)
                    {
                        _checkmark = "[X]";
                    }
                }
                Console.WriteLine($" {i}. {_checkmark} {goal.Get_Goal()}");
                i++;
            }
        }
    }
    private void Save_GoalsList_Json()
    {
        Console.WriteLine("\nWhat is the file name for your goal file? \n(Case sensitive, Exclude '.txt') ");
        string _filepath = Console.ReadLine() + ".json";
        
        Console.Clear();
        Console.WriteLine($"Trying to save data to '{_filepath}' ...");
        try
        {
            var Points_And_Goalslist = new {TotalPointsEarned = _totalpoints, ListofGoals = _goalslist}; //Puts the point total at the top
            string jsonString = JsonSerializer.Serialize(Points_And_Goalslist, new JsonSerializerOptions { WriteIndented = true }); //converts my object's data to the json format
            File.WriteAllText(_filepath, jsonString);

            Console.WriteLine($"\nGoals saved successfully in '{_filepath}'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"\nError message: \n{ex.Message}");
            Console.WriteLine($"File: '{_filepath}', Not saved");
        }
    }
    private void Load_GoalsList_Json()
    {
        Console.WriteLine("\nWhat is the file name for your goal file? \n(Case sensitive, Exclude filename extension EX: '.txt') ");
        string _filepath = Console.ReadLine() + ".json";
        
        if (File.Exists(_filepath))
        {
            Console.Clear();
            Console.WriteLine($"Trying to load data from '{_filepath}' ...");
            try
            {
                string jsonString = File.ReadAllText(_filepath); //Load data to string
                GoalSaveData loadedData = JsonSerializer.Deserialize<GoalSaveData>(jsonString); //decode string into objects
                //seperate usefull data
                _totalpoints = loadedData.TotalPointsEarned;
                _goalslist = loadedData.ListofGoals;
                //Display completed task
                //Console.Clear();
                Console.WriteLine($"\nFile '{_filepath}' has been Loaded in. \n");
                Display_Goals();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError message: \n  '{ex.Message}'");
                Console.WriteLine($"Summary:\n File: '{_filepath}', Not loaded.");
            }
        }
        else
        {
            Console.WriteLine($"\nFile not found");
            Console.WriteLine($"File: {_filepath}, Not loaded");  
        }
    }
    private void Record_Goal_Progress()
    {
        if (_goalslist.Count() == 0)
        {
            Console.WriteLine("You currently have no Goals. ");
        }
        else
        {
            Console.WriteLine("Here are your current goals: ");
            int i = 1;
            foreach(Goal g in _goalslist)
            {
                Console.WriteLine($" {i}. {g.Get_Goal_Name()}");
                i++;
            }
        }
        Console.WriteLine("Which goal did you accomplish? ");
        Goal goal = _goalslist[int.Parse(Console.ReadLine()) - 1];//reads the input, turns into int, minus 1, grabs correct goal.
        //Crashes if input is not a number
        int _points = goal.Get_Goal_Points(); //gets goal points.

        if (goal is SimpleGoal simple)
        {
            
            bool _hasbeencompleted = simple.Get_Goal_Completed();
            if (!_hasbeencompleted)
            {
                simple.Switch_Goal_Completed(); //switch completed value
                _totalpoints += _points; //adds goal points to point total.
                Console.WriteLine($"Congratulations! By completing the goal {goal.Get_Goal_Name()}. You earned {_points} points.");
            }
            else if (_hasbeencompleted)
            {
                Console.WriteLine($"Good job completing that goal again, but you don't get more points.");
            }   
        }
        else if (goal is EternalGoal)
        {
            _totalpoints += _points; //adds goal points to point total.
            Console.WriteLine($"Congratulations! By completing the goal {goal.Get_Goal_Name()}. You earned {_points} points.");
        }
        else if (goal is ChecklistGoal checklist)
        {
            checklist.increase_Goal_Streak();
            int _goalstreak = checklist.Get_Goal_Streak();
            int _goalcompletion = checklist.Get_Goal_completion();
            if (_goalstreak < _goalcompletion)
            {
                _totalpoints += _points; //adds goal points to point total.
                Console.WriteLine($"Congratulations! By completing the goal {goal.Get_Goal_Name()}. You earned {_points} points.");
            }
            else if (_goalstreak == _goalcompletion)
            {
                int _bonuspoints = checklist.Get_Goal_Bonuspoints();
                _totalpoints += _points + _bonuspoints; //adds goal and bonus points to point total.
                Console.WriteLine($"Congratulations! By completing the goal {goal.Get_Goal_Name()}. You earned {_points} points. \nand you completed this goal {_goalstreak}/{_goalcompletion} times, you get a bonus of {_bonuspoints} points");
            }
            else if (_goalstreak > _goalcompletion)
            {
                Console.WriteLine($"Good job completing that goal again, but you don't get more points.");
            }
        }
    }
}
public class GoalSaveData //This a a class specifically to allow the loading of a json file back into the program
{
    //Json requires { get; set; }
    public int TotalPointsEarned { get; set; }
    public List<Goal> ListofGoals { get; set; }
}