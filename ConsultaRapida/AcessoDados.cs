using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace ConsultaRapida
{
    class AcessoDados
    {
        public sealed class AccessData
        {
            private String _username;
            private String _password;
            private String _ipv4;

            [XmlIgnore] //Esta propriedade não irá para o arquivo .XML quando for serializada
            public String UserName
            {
                get { return _username; }
                set { _username = value; }
            }

            [XmlElement("UserName")] //No XML o valor será armazenado em uma tag "UserName"
            public String UserNameSecure
            {
                get { return Security.Encrypt("S3Nh@S3GuR@", _username); }
                set { _username = Security.Decrypt("S3Nh@S3GuR@", value); }
            }

            [XmlIgnore] //Esta propriedade não irá para o arquivo .XML quando for serializada
            public String Password
            {
                get { return _password; }
                set { _password = value; }
            }

            [XmlElement("Password")] //No XML o valor será armazenado em uma tag "Password"
            public String PasswordSecure
            {
                get { return Security.Encrypt("S3Nh@S3GuR@", _password); }
                set { _password = Security.Decrypt("S3Nh@S3GuR@", value); }
            }

            [XmlIgnore] //Esta propriedade não irá para o arquivo .XML quando for serializada
            public String IPV4
            {
                get { return _ipv4; }
                set { _ipv4 = value; }
            }

            [XmlElement("IPAddress")] //No XML o valor será armazenado em uma tag "IPAddress"
            public String IPV4Secure
            {
                get { return Security.Encrypt("S3Nh@S3GuR@", _ipv4); }
                set { _ipv4 = Security.Decrypt("S3Nh@S3GuR@", value); }
            }
        }

        internal static class Security
        {
            private const String SaltKey = "umaStringDeSalt";
            private const String ViKey = "UmaChaveQualquer";

            public static String Encrypt(String password, String value)
            {
                byte[] plainTextBytes = Encoding.UTF8.GetBytes(value);

                byte[] keyBytes = new Rfc2898DeriveBytes(password, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
                var symmetricKey = new RijndaelManaged { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
                var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(ViKey));

                byte[] cipherTextBytes;

                using (var memoryStream = new MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                        cryptoStream.FlushFinalBlock();
                        cipherTextBytes = memoryStream.ToArray();
                        cryptoStream.Close();
                    }
                    memoryStream.Close();
                }
                return Convert.ToBase64String(cipherTextBytes);
            }

            public static String Decrypt(String password, String value)
            {
                byte[] cipherTextBytes = Convert.FromBase64String(value);
                byte[] keyBytes = new Rfc2898DeriveBytes(password, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
                var symmetricKey = new RijndaelManaged { Mode = CipherMode.CBC, Padding = PaddingMode.None };

                var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(ViKey));
                var memoryStream = new MemoryStream(cipherTextBytes);
                var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                var plainTextBytes = new byte[cipherTextBytes.Length];

                int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                memoryStream.Close();
                cryptoStream.Close();
                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
            }
        }
    }
}
