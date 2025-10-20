using System.Threading;
using System.Threading.Tasks;

using STIL.ServiceClient.DTOs.COSA.UMO;

namespace STIL.ServiceClient
{
    internal interface IStilCosaUmoServiceClient
    {
        Task<UmoHentListeResponse> UmoHentListe(
            UmoHentListeRequest dataRequest, CancellationToken cancellationToken = default);

        Task<UmoHentResponse> UmoHent(
            UmoHentRequest dataRequest, CancellationToken cancellationToken = default);
    }
}
