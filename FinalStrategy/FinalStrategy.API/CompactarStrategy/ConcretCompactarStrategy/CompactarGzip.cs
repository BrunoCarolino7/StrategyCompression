using FinalStrategy.API.ConcretStrategy.Contract;

namespace FinalStrategy.API.CompactarStrategy.ConcretCompactarStrategy;

public class CompactarGzip : CompactarContract
{
    public override void CompactarArquivo()
    {
        Console.WriteLine("Arquivo compactado para .Gzip");
    }
}
