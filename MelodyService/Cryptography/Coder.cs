using Melody.Service.PasswordCoder.Interfaces;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Melody.Service.PasswordCoder
{
  public class Coder : ICoder
  {
    public string CodePassword(string password)
    {
      try
      {
        return System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));
      }
      catch (Exception ex)
      {
        throw new Exception("Exception was occured in Coder.CodePassword. " + ex);
      }
    }

    public string UncodePassword(string password)
    {
      try
      {
        return System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));
      }
      catch (Exception ex)
      {
        throw new Exception("Exception was occured in Coder.UncodePassword. " + ex);
      }
    }

    public string CodeMD5Password(string password)
    {
      try
      {
        byte[] data = UTF8Encoding.UTF8.GetBytes(password);
        using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
        {
          byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(password));
          using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
          {
            ICryptoTransform transform = tripDes.CreateEncryptor();
            byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
            password = Convert.ToBase64String(results, 0, results.Length);
            return password;
          }
        }
      }
      catch (Exception ex)
      {
        throw new Exception("Exception was occured in Coder.CodeMD5Password. " + ex);
      }
    }

    public string UncodeMD5Password(string password)
    {
      try
      {
        byte[] data = Convert.FromBase64String(password); // decrypt the incrypted text
        using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
        {
          byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(password));
          using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
          {
            ICryptoTransform transform = tripDes.CreateDecryptor();
            byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
            password = UTF8Encoding.UTF8.GetString(results);
            return password;
          }
        }
      }
      catch (Exception ex)
      {
        throw new Exception("Exception was occured in Coder.UncodeMD5Password. " + ex);
      }
    }
  }
}