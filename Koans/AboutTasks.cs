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
    // Methods which do asynchronous work should have a return type of `Task` or `Task<T>` 
    
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
            return true;
        }

        async Task<bool> slowTask()
        {
            await Task.Delay(500);
            return true;
        }

        await Task.WaitAll(FILL_ME_IN, FILL_ME_IN);
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

        var result = await Task.WhenAll(FILL_ME_IN, FILL_ME_IN);
        
        Assert.Equal(new bool[]{FILL_ME_IN, FILL_ME_IN}, result);
    }

}