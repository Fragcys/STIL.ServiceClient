using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

using STIL.ServiceClient.DTOs.COSA.UMO;

namespace STIL.ServiceClient
{
    /// <inheritdoc />
    public class StilCosaUmoServiceClient : IStilCosaUmoServiceClient
    {
        private const string UrlAreaAffix = "/COSA";
        private readonly IStilServiceClient _stilServiceClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="StilCosaUmoServiceClient"/> class.
        /// </summary>
        /// <param name="baseUrl">The baseUrl for the SOAP services, ex. https://et.integrationsplatformen.dk.</param>
        /// <param name="version"></param>
        /// <param name="clientAndSigningCertificate">The certificate used for both the http client and xml signing.</param>
        public StilCosaUmoServiceClient(string baseUrl, string version, X509Certificate2 clientAndSigningCertificate)
        {
            _stilServiceClient = new StilServiceClient(baseUrl, UrlAreaAffix, clientAndSigningCertificate, clientAndSigningCertificate, version);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StilCosaUmoServiceClient" /> class.
        /// </summary>
        /// <param name="baseUrl">The baseUrl for the SOAP services, ex. https://et.integrationsplatformen.dk.</param>
        /// <param name="version"></param>
        /// <param name="clientCertificate">The http client certificate.</param>
        /// <param name="signingCertificate">The xml signing certificate.</param>
        public StilCosaUmoServiceClient(string baseUrl, string version, X509Certificate2 clientCertificate, X509Certificate2 signingCertificate)
        {
            _stilServiceClient = new StilServiceClient(baseUrl, UrlAreaAffix, clientCertificate, signingCertificate, version);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StilCosaUmoServiceClient" /> class.
        /// </summary>
        /// <param name="stilServiceClient">The STIL service client.</param>
        internal StilCosaUmoServiceClient(IStilServiceClient stilServiceClient)
        {
            _stilServiceClient = stilServiceClient;
        }

        public Task<UmoHentResponse> UmoHent(UmoHentRequest dataRequest, CancellationToken cancellationToken = default)
        {
            return _stilServiceClient.SendSoapRequest<UmoHentRequest, UmoHentResponse, ServiceFaultDetailer>(
                "UMO", dataRequest, cancellationToken: cancellationToken);
        }

        /// <inheritdoc />
        public async Task<UmoHentListeResponse> UmoHentListe(UmoHentListeRequest dataRequest, CancellationToken cancellationToken = default)
        {
            return await _stilServiceClient.SendSoapRequest<UmoHentListeRequest, UmoHentListeResponse, ServiceFaultDetailer>(
                "UMO", dataRequest, cancellationToken: cancellationToken);
        }
    }
}