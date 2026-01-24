using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Adding people to the list
    // Expected Result: the person with the highest priority is in the front
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {

        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Tim", 4);
        priorityQueue.Enqueue("Bob", 5);
        priorityQueue.Enqueue("Sue", 3);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Bob", result);
    }

    [TestMethod]
    // Scenario: There are more than one person with hte same number of prioriry
    // Expected Result: Dequeue the person near to the front
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Tim", 4);
        priorityQueue.Enqueue("Bob", 5);
        priorityQueue.Enqueue("Juan", 5);
        priorityQueue.Enqueue("Sue", 3);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Juan", result);

    }


    [TestMethod]
    // Scenario: If the queue is empty the function need to fail
    // Expected Result: Throws an InvalidOperationException
    // Defect(s) Found: 
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();


        var exception = Assert.ThrowsException<InvalidOperationException>(() =>
        {
            priorityQueue.Dequeue();
        });
        Assert.AreEqual("The queue is empty.", exception.Message);

    }




    // Add more test cases as needed below.
}