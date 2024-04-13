using FinalStrategy.API.CompactarStrategy;
using FinalStrategy.API.CompactarStrategy.ConcretCompactarStrategy;
using FinalStrategy.API.ConcretStrategy.Contract;
using FinalStrategy.API.Dto;
using FinalStrategy.API.Enuns;

namespace FinalStrategy.API.Service;

public abstract class CompactarService
{
    private static readonly Dictionary<TipoCompactar, Func<CompactarContract>> _strategies = new()
    {
            { TipoCompactar.Gzip, () => new CompactarGzip() },
            { TipoCompactar.Zip, () => new CompactarZip() },
            { TipoCompactar.Rar, () => new CompactarRar() }
    };
    public static CompactarOutputDto CompactarArquivo(CompactarInputDto dto)
    {
        try
        {
            if (_strategies.TryGetValue(dto.TipoCompactacao, out var strategyFunc))
            {
                var ctx = new CompactarStrategyContext(strategyFunc());
                ctx.CriarArquivoCompactado();

                return new CompactarOutputDto($"Arquivo .{dto.TipoCompactacao} criado com sucesso!");
            }
            else
            {
                return new CompactarOutputDto("Tipo de compactação não suportado.");
            }
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException("Falha ao compactar o arquivo.", ex);
        }
    }
}
