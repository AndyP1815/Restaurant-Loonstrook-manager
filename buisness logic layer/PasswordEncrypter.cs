using System;
using System.Security.Cryptography;
using System.Text;

namespace business_logic_layer
{
	public class PasswordEncrypter
	{
		
		private static readonly DataProtectionScope Scope = DataProtectionScope.CurrentUser;

		public string Encrypt(string plainText)
		{
			if (plainText == null) throw new ArgumentNullException("plainText");

		
			var data = Encoding.Unicode.GetBytes(plainText);
			byte[] encrypted = ProtectedData.Protect(data, null, Scope);

			return Convert.ToBase64String(encrypted);
		}

		public string Decrypt(string cipher)
		{
			if (cipher == null) throw new ArgumentNullException("cipher");

			
			byte[] data = Convert.FromBase64String(cipher);

			byte[] decrypted = ProtectedData.Unprotect(data, null, Scope);
			return Encoding.Unicode.GetString(decrypted);
		}
	}
}
