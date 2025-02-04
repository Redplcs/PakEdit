namespace CXModdingTools.PakEdit.Formats.Pak.Tests;

public class PakReaderTests
{
	[Fact]
	public void Design()
	{
		using var stream = ResourceHelper.GetResourceStream(Resources.GlobalEK);
		using var reader = new PakReader(stream);

		var entry = reader.GetNextEntry();

		Assert.NotNull(entry);
		Assert.Equal(@"Gfx/Interfaz.txt", entry.Name);
	}
}
