class ClassWithSemaphore
     {
         private static semaphores _semaphore = new semaphore (3, 3);
    
          private static int _counter = 0;
     
          public void DoSomething ()
          {
             _semaphore.WaitOne ();
    
             _counter ++;
             Console .WriteLine (_counter);
          Thread .Sleep (50);
           _counter-;
 
           _semaphore.Release ();
         }
    }
 
 
 //Limits the number of threads that can access a resource or pool of resources concurrently.