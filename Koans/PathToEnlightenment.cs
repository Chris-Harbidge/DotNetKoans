using System;
using DotNetKoans.Engine;

namespace DotNetKoans.Koans;

public class PathToEnlightenment : Path
{
	public PathToEnlightenment()
	{
		Types = new Type[]
		{
			typeof(AboutAsserts),
			typeof(AboutBooleans),
			typeof(AboutStrings),
			typeof(AboutFloats),
			typeof(AboutDecimals),
			typeof(AboutNull),
			typeof(AboutConstants),
			typeof(AboutArrays),
			typeof(AboutAssignments),
			typeof(AboutEnumerations),
			typeof(AboutDictionary),
			typeof(AboutClasses),
			typeof(AboutInheritance),
			typeof(AboutMethods),
			typeof(AboutControlStatements),
			typeof(AboutIteration),
			typeof(AboutExceptions),
			typeof(AboutGenericContainers),
			typeof(AboutLambdas),
			typeof(AboutLinq),
			typeof(AboutDestructuring),
			typeof(AboutPatternMatching),
			typeof(AboutTuples),
			typeof(AboutDisposable),
			typeof(AboutTasks),
			typeof(AboutInterfaces)
        };
	}
}