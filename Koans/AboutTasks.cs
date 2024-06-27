using System.Threading;
using System.Threading.Tasks;
using DotNetKoans.Engine;
using Xunit;

namespace DotNetKoans.Koans;

public class AboutTasks : Koan
{

    // Tasks and async/await allow us to do asynchronous work in C# (such as making network requests)
    // without blocking the main thread.
    // Tasks are an abstraction over multi-threading and mean we don't have to worry about
    // thread pools etc.
    // We use `await` to pause execution until a task has completed
    // The `async` keyword indicates a method is `await`able
    // Methods which do asynchronous work should have a return type of `Task` or `Task<[Some Type]>` 
    
    [Step(1)]
    public async Task BasicAsyncAwait()
    {
        // Note the `async` keyword and `Task<bool>` return type
        async Task<bool> bar()
        {
            await Task.Delay(10000);
            return true;
        } 
    
        var result = await FILL_ME_IN;
        
        Assert.True(result);
    }
    
    [Step(2)]
    public async Task RunningMultipleTasks()
    {
        async Task<bool> quickTask()
        {
            await Task.Delay(10);
            return false;
        }
    
        async Task<bool> slowTask()
        {
            await Task.Delay(500);
            return true;
        }
    
        await Task.WaitAll(FILL_ME_IN, FILL_ME_IN);
        // Task.WaitAll does not return the values from the tasks
        // We can still get the results from each task using `.Result()`
        // N.B. You should *not* use `.Result()` on a task unless the task has already been awaited
        // Calling `.Result()` on an un-awaited task will cause the main thread to block until the task has completed
        Assert.Equal(quickTask().Result, FILL_ME_IN);
        Assert.Equal(slowTask().Result, FILL_ME_IN);
    }
    
    [Step(3)]
    public async Task GettingResultsFromMultipleTasks()
    {
        async Task<bool> quickTask()
        {
            await Task.Delay(10);
            return true;
        }
    
        async Task<bool> slowTask()
        {
            await Task.Delay(500);
            return true;
        }
    
        // Using Task.WhenAll returns the values from each task in an array
        var result = await Task.WhenAll(FILL_ME_IN, FILL_ME_IN);
        
        Assert.Equal(new bool[]{FILL_ME_IN, FILL_ME_IN}, result);
    }
    
    [Step(4)]
    public async Task UsingCancellingTokens()
    {
        // Cancellation tokens are a core part of Api programming in Dotnet
        // They allow us to quickly cancel tasks if the connection to the client is lost, for example
        // Almost all asynchronous methods offered by the Dotnet libraries will have a version which accepts a cancellation token
        
        async Task longRunningTaskToCancel(CancellationToken cancellationToken)
        {
            var counter = 0;
            while (cancellationToken.IsCancellationRequested == false)
            {
                counter++;
                await Task.Delay(10);
                if (counter > 12)
                {
                    Assert.Fail("Task was not cancelled");
                }
            }
        }

        var cancellationTokenSource = new CancellationTokenSource();
        var cancellationToken = cancellationTokenSource.Token;
        cancellationTokenSource.CancelAfter(100);

        var longRunningTask = longRunningTaskToCancel(FILL_ME_IN);
        
        await longRunningTask;
    }
}