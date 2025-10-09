public class Prompts()
{
    public List<string> prompts = new List<string>();
    public string ReturnPrompts(out string chosenP)
    {
        prompts.Add("What was your favite blessing today? ");
        prompts.Add("What was the weather like? ");
        prompts.Add("What is your favorite nickname? ");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 3);

        chosenP = prompts[number];
        return chosenP;
    }
}