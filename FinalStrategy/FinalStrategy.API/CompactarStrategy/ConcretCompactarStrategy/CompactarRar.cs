using FinalStrategy.API.ConcretStrategy.Contract;

namespace FinalStrategy.API.CompactarStrategy.ConcretCompactarStrategy;

public class CompactarRar : CompactarContract
{
    public override void CompactarArquivo()
    {
        Console.WriteLine("Arquivo compactado para .Rar");
    }
}
