namespace Goal_Objects;
public class EternalGoal : Goal
{
    public EternalGoal() {}
    public EternalGoal(string goalname, string goaldescription, int goalpoints) : base(goalname, goaldescription, goalpoints)
    {
        
    }
    public override string Get_Goal()
    {
        return Get_Goal_Name() + " (" + Get_Goal_Description() + ")";
    }
}