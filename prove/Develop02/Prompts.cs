public class Prompts()
{
    public List<string> prompts = new List<string>();
    public string ReturnPrompts(out string chosenP)
    {
        prompts.Add("What was your favite blessing today? ");
        prompts.Add("What was the weather like? ");
        prompts.Add("What is your favorite nickname? ");
        prompts.Add("What color was the sun today? ");
        prompts.Add("Do you like Swimming? ");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, prompts.Count);

        chosenP = prompts[number];
        return chosenP;
    }
}