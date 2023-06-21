using System.Security.Cryptography;
using System.Text;
using System.Drawing.Imaging;
using static System.Net.Mime.MediaTypeNames;

namespace PizzariaDoZe.DAO;
/// string hash = ClassFuncoes.Sha256Hash(textBoxSenha.Text);

public class ClassFuncoes
{
    public static string Sha256Hash(string senha)
    {
        // Create a new Stringbuilder to collect the bytes and create a string.
        var hash = new StringBuilder();
        using (SHA256 sha256Hash = SHA256.Create())
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));
            // Loop through each byte of the hashed data and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                hash.Append(data[i].ToString("x2"));
            }
        }
        // retorna o hash SHA256.
        return hash.ToString();
    }
}