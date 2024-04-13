using FinalStrategy.API.ConcretStrategy.Contract;

namespace FinalStrategy.API.CompactarStrategy;

public class CompactarStrategyContext(CompactarContract contract)
{
    private CompactarContract _context = contract;

    public void DefineStrategy(CompactarContract compactar)
    {
        _context = compactar;
    }

    public void CriarArquivoCompactado()
    {
        _context.CompactarArquivo();
    }
}
