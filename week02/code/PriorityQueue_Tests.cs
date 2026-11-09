using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    //Add John (proority 1), Mary (prirority 2) amnd Peter (priority 10).
    // Expected Result: 
    //Peter should be removed first because he has the highest priority.
    // Defect(s) Found: 
    //The does not check the last item in the queue.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("John", 1);
        priorityQueue.Enqueue("Mary", 2);
        priorityQueue.Enqueue("Peter", 10);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("Peter", result);
    }

    [TestMethod]
    // Scenario: 
    //Add John (priority 5), Mary (priority 5) and Peter (priority 5).
    // Expected Result: 
    //John should be removed first because he was added first.
    // Defect(s) Found: 
    //The >= comparison allows later items with equal priority
    // to replace earlier items on the queue, thus breaking FIFO ordering.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("John", 5);
        priorityQueue.Enqueue("Mary", 5);
        priorityQueue.Enqueue("Peter", 5);

        var result = priorityQueue.Dequeue();


        Assert.AreEqual("John", result);
    }

    // Add more test cases as needed below.
}