namespace stack_solution;

public class ConversationTracker {
    public Stack<string> names = new Stack<string>();
    public string? currName;

    public void NewTalker(string name){
        if (currName != null && names.Count < 4) {
            names.Push(currName);
        }
        else if (names.Count >= 4) {
            Console.WriteLine("You have too many people starting stories! Let's wrap this up first.");
        }
        currName = name;
    }

    public void DoneTalking() {
        if (names.Count > 0) {
            currName = names.Pop();
        }
        else {

        }
    }

    public void WhosTalking() {
        if (currName != null) {
            Console.WriteLine(currName);
        }
        else {
            Console.WriteLine("No one is talking! Lets start a new conversation!");
        }
    }

}