﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Microsoft.Azure.Commands.ServiceFabric.Models
{
    public class PSKeyVault
    {
        public X509Certificate2 Certificate { get; set; }

        public string Thumbprint { get; set; }

        public string KeyVaultName { get; set; }

        public string KeyVaultCertificateName { get; set; }

        public string KeyVaultSecretName { get; set; }

        public string KeyVaultSecretVersion { get; set; }


        public override string ToString()
        {
            var sb = new StringBuilder();

            const string spaces = "    ";
            sb.AppendLine(string.Format("{0} {1} : {2}", "", "KeyVaultName", this.KeyVaultName));
            sb.AppendLine(string.Format("{0} {1} :", "    ", "Certificate:"));
            sb.AppendLine(string.Format("{0} {1}", spaces, this.Certificate));
            sb.AppendLine(string.Format("{0} {1} : {2}", spaces, "KeyVaultCertificateName", this.KeyVaultCertificateName));
            sb.AppendLine(string.Format("{0} {1} : {2}", spaces, "KeyVaultSecretName", this.KeyVaultSecretName));
            sb.AppendLine(string.Format("{0} {1} : {2}", spaces, "KeyVaultSecretVersion", this.KeyVaultSecretVersion));
            sb.AppendLine(string.Format("{0} {1} : {2}", spaces, "Thumbprint", this.Thumbprint));

            return sb.ToString();
        }
    }
}
