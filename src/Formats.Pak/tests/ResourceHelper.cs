namespace CXModdingTools.PakEdit.Formats.Pak.Tests;

internal static class ResourceHelper
{
	internal static Stream GetResourceStream(string resourceName)
	{
		var resourcePath = Path.Combine(Directory.GetCurrentDirectory(), "Resources", resourceName);

		return File.OpenRead(resourcePath);
	}
}
