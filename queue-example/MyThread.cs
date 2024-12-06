namespace queue_example;

public class MyThread : BaseThread
{
    public MyThread() : base()
    {
    }

    public override void RunThread()
    {
        // Do some stuff
        Console.WriteLine("I'm in the thread");
    }
}
