using DotNetKoans.Engine;
using Xunit;

namespace DotNetKoans.Koans;

public class AboutInterfaces : Koan
{
    // Interfaces define methods that an implementing class must provide an implementation for
    // They are different from abstract classes in that:
    // - They do not provide default implementations (*NB* There are exceptions to this we won't go into)
    // - An implementing class can implement more than one interface, whereas only one class can be subclassed

    interface Step1Interface
    {
        bool ReturnsTrue();
    }

    class Step1Implementor : FillMeIn
    {
        
    }

    [Step(1)]
    public void ClassImplementsInterface()
    {
        Step1Interface implementor = FILL_ME_IN;

        Assert.IsType<Step1Implementor>(implementor);
        Assert.True(implementor.ReturnsTrue());
    }
    
    // Interfaces can also inherit other interfaces

    interface Step2ParentInterface
    {
        bool ReturnsTrue();
    }

    interface Step2ChildInterface : Step2ParentInterface
    {
        bool ReturnsFalse();
    }

    class Step2Implementor : FillMeIn
    {
        
    }

    [Step(2)]
    public void ClassImplementsInheritedInterfaces()
    {
        Step2ChildInterface implementor = FILL_ME_IN;

        Assert.IsType<Step2Implementor>(implementor);
        Assert.True(implementor.ReturnsTrue());
        Assert.False(implementor.ReturnsFalse());
    }

    interface Step3Interface
    {
        bool ReturnsBoolean();
    }

    class Step3FirstImplementor : Step3Interface
    {
        public bool ReturnsBoolean()
        {
            throw new System.NotImplementedException();
        }
    }
    
    class Step3SecondImplementor : Step3Interface
    {
        public bool ReturnsBoolean()
        {
            throw new System.NotImplementedException();
        }
    }

    [Step(3)]
    public void ClassesImplementingTheSameInterfaceAreSwappable()
    {
        Step3Interface instance;

        instance = new Step3FirstImplementor();
        
        Assert.False(instance.ReturnsBoolean());

        instance = new Step3SecondImplementor();
        
        Assert.True(instance.ReturnsBoolean());
    }

}