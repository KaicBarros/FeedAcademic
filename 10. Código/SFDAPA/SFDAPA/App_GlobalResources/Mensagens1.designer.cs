//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources {
    using System;
    
    
    /// <summary>
    ///   Uma classe de recurso fortemente tipados, para pesquisar cadeias de caracteres localizadas etc.
    /// </summary>
    // Essa classe foi gerada automaticamente pela classe StronglyTypedResourceBuilder
    // classe através de uma ferramenta como ResGen ou Visual Studio.
    // Para adicionar ou remover um associado, edite o arquivo .ResX e execute ResGen novamente
    // com a opção /str ou recompile o projeto do Visual Studio.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Web.Application.StronglyTypedResourceProxyBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Mensagens {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Mensagens() {
        }
        
        /// <summary>
        ///   Retorna a instância cacheada de ResourceManager utilizada por esta classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Resources.Mensagens", global::System.Reflection.Assembly.Load("App_GlobalResources"));
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Substitui a propriedade CurrentUICulture do thread atual para todas
        ///   as pesquisas de recursos que usam esta classe de recursos fortemente tipados.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Pesquisa uma cadeia de caracteres localizada semelhante a O nome do assunto é obrigatório..
        /// </summary>
        internal static string AssuntoRequerido {
            get {
                return ResourceManager.GetString("AssuntoRequerido", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Pesquisa uma cadeia de caracteres localizada semelhante a O email é obrigatório..
        /// </summary>
        internal static string EmailRequerido {
            get {
                return ResourceManager.GetString("EmailRequerido", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Pesquisa uma cadeia de caracteres localizada semelhante a Login existente..
        /// </summary>
        internal static string LoginExistente {
            get {
                return ResourceManager.GetString("LoginExistente", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Pesquisa uma cadeia de caracteres localizada semelhante a O Login é obrigatório..
        /// </summary>
        internal static string LoginRequerido {
            get {
                return ResourceManager.GetString("LoginRequerido", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Pesquisa uma cadeia de caracteres localizada semelhante a O nome completo é obrigatório..
        /// </summary>
        internal static string NomeRequerido {
            get {
                return ResourceManager.GetString("NomeRequerido", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Pesquisa uma cadeia de caracteres localizada semelhante a O título da pergunta é obrigatório..
        /// </summary>
        internal static string PerguntaRequerida {
            get {
                return ResourceManager.GetString("PerguntaRequerida", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Pesquisa uma cadeia de caracteres localizada semelhante a A senha e sua confirmação não são correspondentes..
        /// </summary>
        internal static string SenhaDiferente {
            get {
                return ResourceManager.GetString("SenhaDiferente", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Pesquisa uma cadeia de caracteres localizada semelhante a A senha é obrigatória..
        /// </summary>
        internal static string SenhaRequerida {
            get {
                return ResourceManager.GetString("SenhaRequerida", resourceCulture);
            }
        }
    }
}
