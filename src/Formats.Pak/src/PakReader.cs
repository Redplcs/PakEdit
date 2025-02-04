namespace CXModdingTools.PakEdit.Formats.Pak;

public sealed class PakReader : IDisposable
{
	private readonly Stream _packageStream;

	public PakReader(Stream packageStream)
	{
		_packageStream = packageStream;
	}

	public void Dispose()
	{
		_packageStream.Dispose();
	}

	public PakEntry? GetNextEntry()
	{
		return new PakEntry()
		{
			Name = @"Gfx/Interfaz.txt"
		};
	}
}
