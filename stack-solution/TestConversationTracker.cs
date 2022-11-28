namespace stack_solution;

public static class TestConversationTracker {
    public static void Run() {
        var conversation = new ConversationTracker();

        Console.WriteLine("----------------Test 1-----------");
        // See current name when no names have been added to conversation.
        conversation.WhosTalking();    // Expected Outcome: Null

        // Bugs Found: 

        Console.WriteLine("----------------Test 2-----------");
        // Add six names to conversation
        conversation.NewTalker("Kate");
        conversation.NewTalker("Lewis");
        conversation.NewTalker("Bob");
        conversation.NewTalker("Lisa");
        conversation.NewTalker("Melissa");
        conversation.NewTalker("Joan");      // Expected outcome: some error message

        // Bugs Found: 

        Console.WriteLine("----------------Test 3-----------");
        // Add one name- "Nelly", and check that is the current name.

        // Start new conversation.
        conversation = new ConversationTracker();
        conversation.NewTalker("Nelly");
        conversation.WhosTalking();     // Expected Outcome: Nelly

        // Bugs Found: 

        Console.WriteLine("----------------Test 4-----------");
        // Add two names and then remove one and check that the current talker is the first name added.
        conversation.NewTalker("Kyle");
        conversation.NewTalker("Ethan");
        conversation.DoneTalking();
        conversation.WhosTalking();     // Expected Outcome: Kyle

    }
}