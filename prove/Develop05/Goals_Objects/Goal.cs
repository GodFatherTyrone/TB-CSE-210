namespace Goal_Objects;
using System.Text.Json.Serialization;

[JsonDerivedType(typeof(SimpleGoal), typeDiscriminator: "Simple")]
[JsonDerivedType(typeof(EternalGoal), typeDiscriminator: "Eternal")]
[JsonDerivedType(typeof(ChecklistGoal), typeDiscriminator: "Checklist")]
public abstract class Goal
{
    
    [JsonInclude]
    private string _goalname;
    [JsonInclude]
    private string _goaldescription;
    [JsonInclude]
    private int _goalpoints;
    public Goal() {}
    public Goal(string goalname, string goaldescription, int goalpoints)
    {
        _goalname = goalname;
        _goaldescription = goaldescription;
        _goalpoints = goalpoints;
    }
    public string Get_Goal_Name()
    {
        return _goalname;
    }
    public string Get_Goal_Description()
    {
        return _goaldescription;
    }
    public int Get_Goal_Points()
    {
        return _goalpoints;
    }
    public abstract string Get_Goal();
}