using System.Xml.Schema;

public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Add to queue the following values and priorities: Cook a meal(1) and Do the homework(2). Dequeue and display them in order of priority.
        // Run the Dequeue method a third time to check if the empty queue error displays.
        // Expected Result: Do the homework, Cook a meal, The queue is empty
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Cook a meal", 1);
        priorityQueue.Enqueue("Do the homework", 2);
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();

        // Defect(s) Found: The Dequeue method wasn't comparing if the queue only had two elements. It was also not removing the values from the queue
        //                  or displaying the value

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Add to queue the following values and priorities: Cook a meal(5), Do the homework(6),
        //           Wash the dishes (4), Play games(2), Watch TV(2), Drink water (9), Read a book (6). 
        //           Dequeue and display them in order of priority. If two have the same priority, dequeue in the order they were in the enqueued.
        // Expected Result: Drink water, Do the homework, Read a book, Cook a meal, Wash the dishes, Play games, Watch TV
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("Cook a meal", 5);
        priorityQueue.Enqueue("Do the homework", 6);
        priorityQueue.Enqueue("Wash the dishes", 4);
        priorityQueue.Enqueue("Play games", 2);
        priorityQueue.Enqueue("Watch TV", 2);
        priorityQueue.Enqueue("Drink water", 9);
        priorityQueue.Enqueue("Read a book", 6);
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        priorityQueue.Dequeue();
        // Defect(s) Found: The Dequeue method wasn't removing elements with the same priority in the correct order.

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}