Namespace: System.Threading.Thread
A thread controls the flow of an executable program. 
By default, a program has one thread called Main Thread. 
Main Thread starts when control enters in the Main method and it terminates when Main method returns.

If the execution of a program is controlled by more than one thread, 
it's called a Multithreaded Application. 
Such a program increases the performance and response time of an application. 

**NOTE**: _A thread can only be manipulated on a method. For example, MainThread needs a Main method to control the flow of a progam._

Unstarted: Thread is created but not started yet

Running: Thread is executing a program

WaitSleepJoin: Thread is blocked due to Wait, Sleep or Join method

Suspended: Thread is suspended

Stopped: Thread is stopped, either normally or aborted

Start(): Changes state of thread to Running

Join(): Wait for finishing a thread before executing calling thread

Sleep(): Suspend a thread for specified number of miliseconds

Resume(): Resume the execution of suspended thread

Abort(): Terminates the execution of a thread

CurrentThread: Returns a reference of the current thread

IsAlive: Returns true if thread has not been terminated or aborted

IsBackground: Get or set to indicate a thread is or is not a background thread

Name: Get or set name of a thread

ThreadState: Returns the current state of thread


Syntax

Thread variableName = new Thread(new ThreadStart(voidMethod));

Thread variableName = new Thread(voidMethod);

**ThreadStart** is a delegate; it represents the method that executes on a Thread
............
## Thread Pool
The cost of instantiating a thread is higher than reusing a free Thread.
A  TP is a collection of Background threads. (created by a system and are avilable to perform any task when required.

It is efficient to use a existing thread as their is no over head of creating it.

ThreadPool Class in .net uses QueueUserWorkItem() to queue the excution of available threads in the thread pool.

............
## Task Parallel library
Task is a light weight Object which asynchronously managesthe unit of work. 
Task doesn't create new Threads.
It efficiently manages the threads of a threadpool.
### Features
Allows to return a result
