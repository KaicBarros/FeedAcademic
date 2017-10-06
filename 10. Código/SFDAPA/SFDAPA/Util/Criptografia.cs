using System.Security.Cryptography;
using System.Text;

namespace BibliotecaWeb.Util
{
    public class Criptografia
    {
        /// <summary>
        /// Enum ALGORITMOS - Representa os tipos de algoritmos de hash disponíveis para geração de senhas.
        /// </summary>
        private enum ALGORITMOS { SHA1, MD5, SHA256 };

        /// <summary>
        /// Propriedade Algoritmo - Representa o algoritmo de hash específico.
        /// </summary>
        private static HashAlgorithm Algoritmo { get; set; }

        /// <summary>
        /// Método AlgoritmoFactory - Cria um algoritmo de hash específico conforme a opção escolhida.
        /// </summary>
        /// <param name="opcao"> Tipo do algoritmo. </param>
        private static void AlgoritmoFactory(ALGORITMOS opcao)
        {
            if (opcao == ALGORITMOS.MD5)
                Algoritmo = MD5.Create();
            else if (opcao == ALGORITMOS.SHA1)
                Algoritmo = SHA1.Create();
            else
                Algoritmo = SHA256.Create();
        }

        /// <summary>
        /// Método GerarHashSenha - Gera um hash específico utilizado para gerar senhas.
        /// </summary>
        /// <param name="senha"> Senha em texto plano (sem aplicação de Hash ou Criptografia). </param>
        /// <returns> Hash da senha fornecida. </returns>
        public static string GerarHashSenha(string senha)
        {
            var senhaCifrada = Encoding.UTF8.GetBytes(senha);

            // Aplicação da sequência MD5, SHA256, MD5, SHA256.
            AlgoritmoFactory(ALGORITMOS.MD5);
            senhaCifrada = Algoritmo.ComputeHash(senhaCifrada);
            AlgoritmoFactory(ALGORITMOS.SHA256);
            senhaCifrada = Algoritmo.ComputeHash(senhaCifrada);
            AlgoritmoFactory(ALGORITMOS.MD5);
            senhaCifrada = Algoritmo.ComputeHash(senhaCifrada);
            AlgoritmoFactory(ALGORITMOS.SHA256);
            senhaCifrada = Algoritmo.ComputeHash(senhaCifrada);

            var stringSenha = new StringBuilder();
            foreach(var caractere in senhaCifrada)
                stringSenha.Append(caractere.ToString("X2"));

            return stringSenha.ToString();
        }

        /// <summary>
        /// Método CompararSenhas - Compara o hash de duas senhas.
        /// </summary>
        /// <param name="senhaDigitada"> Senha fornecida pelo usuário (em texto plano). </param>
        /// <param name="senhaCadastrada"> Hash da senha armazenada em uma base de dados. </param>
        /// <returns> Um valor booleano indicando se os hash das senhas são iguais ou não. </returns>
        public static bool CompararSenhas(string senhaDigitada, string senhaCadastrada)
        {
            senhaDigitada = GerarHashSenha(senhaDigitada);
            return senhaDigitada.Equals(senhaCadastrada);
        }
    }
}