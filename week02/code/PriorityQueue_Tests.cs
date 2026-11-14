using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: check if the first high priority is the first out.
    // Expected Result: [third,second,fourth,first,fifth]
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var first = new PriorityItem("first", 5);
        var second = new PriorityItem("second", 6);
        var third = new PriorityItem("third", 9);
        var fourth = new PriorityItem("fourth", 6);
        var fifth = new PriorityItem("fifth", 1);

        PriorityItem[] expectedResult = [third, second, fourth, first, fifth];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(first.Value, first.Priority);
        priorityQueue.Enqueue(second.Value, second.Priority);
        priorityQueue.Enqueue(third.Value, third.Priority);
        priorityQueue.Enqueue(fourth.Value, fourth.Priority);
        priorityQueue.Enqueue(fifth.Value, fifth.Priority);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual(expectedResult[0].Value, result);
    }

    [TestMethod]
    // Scenario: check if the first high priority is the first out.
    // Expected Result: [highest,medium,low]
    // Defect(s) Found: We need to add a remove statement and arrange the loop 
    public void TestPriorityQueue_2()
    {
        var low = new PriorityItem("low", 1);
        var medium = new PriorityItem("medium", 2);
        var highest = new PriorityItem("highest", 3);


        PriorityItem[] expectedResult = [highest, medium, low];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(low.Value, low.Priority);
        priorityQueue.Enqueue(medium.Value, medium.Priority);
        priorityQueue.Enqueue(highest.Value, highest.Priority);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual(expectedResult[0].Value, result);
    }

}