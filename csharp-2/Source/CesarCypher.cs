using System;

namespace Codenation.Challenge
{
    public class CesarCypher : ICrypt, IDecrypt
    {
        ///<summary> Codifica uma mensagem e retorna a mensagem codificada </summary>
        public string Crypt(string message)
        {

            if (!IsValidString(message))
                return "";
            
            int numCasas = 3;
            message = message.ToLower();
            Console.WriteLine("Mensagem: "+message);
            string cryptedMessage = "";
            foreach (char c in message)
            {
                /// Lança uma execeção para todos os caracteres exceto espaço, números e letras minusculas
                isValidChar (c);
                /// Encripta o caractere
                int a = (int) c < 97 ? 
                        c : 
                        (int) c + numCasas > 122 ? 
                        97 + (((int) c - 122 + 3) - 1) : 
                        (int) c + numCasas;

                cryptedMessage += (char) a;
            }
            Console.WriteLine("Cifrada: "+cryptedMessage+"\n");
            return cryptedMessage;
        }

        ///<summary> Decodifica uma mensagem e retorna a mensagem decodificada </summary>
        public string Decrypt(string cryptedMessage)
        {
            // Lança uma execeção se a string for nula
            if (!IsValidString(cryptedMessage))
                return "";

            int numCasas = 3;
            cryptedMessage = cryptedMessage.ToLower();
            Console.WriteLine("Cifrada: "+cryptedMessage);
            string decryptedMessage = "";
            foreach (char c in cryptedMessage)
            {
                /// Lança uma execeção para todos os caracteres exceto espaço, números e letras minusculas
                isValidChar (c);
                /// Decripta o caractere
                int a = (int)c < 97 ? 
                        c : 
                        (int) c - numCasas < 97 ? 
                        122 - (numCasas - ((int) c - 97) - 1) : 
                        (int) c - numCasas;

                decryptedMessage += (char) a;
            }
            Console.WriteLine("Decifrada: "+decryptedMessage);
            return decryptedMessage;
        }

        public bool isValidChar (char c){
            if (((int) c > 90 && (int) c < 97) || ((int) c > 57 && (int) c < 65) || (int) c > 122 || (int) c < 48 && (int) c != 32){
                    Console.WriteLine("Erro no caractere "+c);
                    throw new ArgumentOutOfRangeException();
            }
            return true;
        }
        public bool IsValidString (string text){
            if (string.IsNullOrEmpty(text)) {
                throw new ArgumentNullException();
            }
            /// Retorna uma string vazia caso receba uma vazia
            if (text.Equals(string.Empty))
                return false;
            
            return true;
        }
    }

    
}
