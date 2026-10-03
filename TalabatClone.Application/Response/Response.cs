

namespace TalabatClone.Application.Response
{
    public record Response<T>(bool IsSucced, T? Data, string? ErrorMessege) where T : class;
   
}
