using System;
using System.Net;

namespace Certify.Utils
{
    public class CertificateBindingUtils
    {
        public static readonly Guid IisAppId = new Guid("4DC3E181-E14B-4a21-B022-59FC669B0914");

        public SslCertBinding.Net.CertificateBinding[] GetAllCertificateBindings(IPEndPoint queryIp = null)
        {
            var results = new SslCertBinding.Net.CertificateBindingConfiguration().Query(queryIp);
            foreach (var binding in results)
            {
                if (binding.AppId == IisAppId)
                {
                    System.Diagnostics.Debug.WriteLine(binding.ToString());
                }
            }
            return results;
        }
    }
}