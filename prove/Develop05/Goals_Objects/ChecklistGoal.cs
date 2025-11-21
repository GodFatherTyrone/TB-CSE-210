namespace Goal_Objects;
using System.Text.Json.Serialization;
public class ChecklistGoal : Goal
{
    [JsonInclude]
    private int _goalstreak;
    [JsonInclude]
    private int _goalcompletion;
    [JsonInclude]
    private int _goalbonuspoints;
    public ChecklistGoal() {}
    public ChecklistGoal(string goalname, string goaldescription, int goalpoints, int goalstreak, int goalbonuspoints) : base(goalname, goaldescription, goalpoints)
    {
        _goalstreak = 0;
        _goalcompletion = goalstreak;
        _goalbonuspoints = goalbonuspoints;
    }
    public ChecklistGoal(int goalstreak, int goalcompletion, int goalbonuspoints, string goalname, string goaldescription, int goalpoints) : base(goalname, goaldescription, goalpoints)
    {
        _goalstreak = goalstreak;
        _goalcompletion = goalcompletion;
        _goalbonuspoints = goalbonuspoints;
    }
    public int Get_Goal_Streak()
    {
        return _goalstreak;
    }
    public void increase_Goal_Streak()
    {
        _goalstreak++;
    }
    public int Get_Goal_completion()
    {
        return _goalcompletion;
    }
    public int Get_Goal_Bonuspoints()
    {
        return _goalbonuspoints;
    }
    public override string Get_Goal()
    { 
        return Get_Goal_Name() + " (" + Get_Goal_Description() + ") --- Currently completed: "+ _goalstreak + "/" + _goalcompletion;
    }
}