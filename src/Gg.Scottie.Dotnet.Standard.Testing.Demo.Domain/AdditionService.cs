namespace Gg.Scottie.Dotnet.Standard.Testing.Demo.Domain
{
    public class AdditionService : IAdditionService
    {
        public decimal Add(decimal first, decimal second)
        {
            return first + second;
        }
    }
}