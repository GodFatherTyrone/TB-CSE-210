namespace Goal_Objects;
using System.Text.Json.Serialization;
public class SimpleGoal : Goal
{
    [JsonInclude]
    private bool _goalcompleted;
    public SimpleGoal() {}
    public SimpleGoal(string goalname, string goaldescription, int goalpoints) : base(goalname, goaldescription, goalpoints)
    {
        _goalcompleted = false;
    }
    public SimpleGoal(bool goalcompleted, string goalname, string goaldescription, int goalpoints) : base(goalname, goaldescription, goalpoints)
    {
        _goalcompleted = goalcompleted;
    }
    public void Switch_Goal_Completed()
    {
        _goalcompleted = !_goalcompleted;
    }
    public bool Get_Goal_Completed()
    {
        return _goalcompleted;
    }
    public override string Get_Goal()
    {
        return  Get_Goal_Name() + " (" + Get_Goal_Description() + ")";

    }
}