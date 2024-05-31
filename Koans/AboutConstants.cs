using DotNetKoans.Engine;
using Xunit;

namespace DotNetKoans.Koans;

public class AboutConstants : Koan
{
	[Step(1)]
	public void ConstantsMustBeInitializedAsDeclared()
	{
		const int months = 12;
		Assert.Equal(FILL_ME_IN, 12);
	}

	[Step(2)]
	public void ConstantsCannotBeChanged()
	{
		//Since C# inserts literal values into compiled
		//code, you will not achieve zen when attempting
		//to change them after definition.
		const int days = 365;
		//days = days + 1; //
		Assert.Equal(FILL_ME_IN, 365);
	}

	[Step(3)]
	public void ConstantsOfTheSameTypeCanBeDeclaredAtTheSameTime()
	{
		//You can achieve zen (and save keystrokes) by defining
		//constants of the same type as one.
		const int months = 12, weeks = 52, days = 365;
		Assert.Equal(typeof(FillMeIn), months.GetType());
		Assert.Equal(typeof(FillMeIn), weeks.GetType());
		Assert.Equal(typeof(FillMeIn), days.GetType());
	}

	[Step(4)]
	public void ConstantsCanBeUsedInExpressionsToInitializeOtherConstants()
	{
		const int months = 12;
		const int weeks = 52;
		const int days = 365;

		const double daysPerWeek = (double)days / (double)weeks;
		const double daysPerMonth = (double)days / (double)months;
		Assert.Equal(FILL_ME_IN, daysPerWeek);
		Assert.Equal(FILL_ME_IN, daysPerMonth);

		//Constants can be used in arithmetic to set other constant values.
		//They can also initialize each other.
	}
}