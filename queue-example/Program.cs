// See https://aka.ms/new-console-template for more information

using queue_example;

Console.WriteLine("Hello, World!");

MyQueue q = new MyQueue();
// q.Enqueue(1);
// q.Enqueue(2);
// q.Enqueue(3);
// q.Enqueue(4);
// q.Enqueue(5);
//
// Console.WriteLine($"{q.Size().ToString()}");
// Console.WriteLine(q.Dequeue().ToString());
//
// q.Enqueue(6);
//
// Console.WriteLine(q.Dequeue().ToString());
// Console.WriteLine(q.Dequeue().ToString());
// Console.WriteLine(q.Dequeue().ToString());
// Console.WriteLine(q.Dequeue().ToString());
// Console.WriteLine(q.Dequeue().ToString());

for (int i = 0; i < 1000; i++)
{
    q.Enqueue(i);
    // Console.WriteLine(q.Dequeue().ToString());
}
Console.WriteLine($"{q.Size().ToString()}");

// MyThread thread = new MyThread();
// thread.Start();
// thread.Join();