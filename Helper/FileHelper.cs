using System.IO;

namespace ExemploPOO.Helper
{
    public class FileHelper
    {


              public void ListarDiretorios(string caminho){

                     var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

                     foreach ( var retorno in retornoCaminho)
                     {


                                Console.WriteLine(retorno);



                        
                     }

              }


              public void ListarArquivosDiretorios(string caminho){

                     var retornoArquivos = Directory.GetFiles(caminho, "*2*", SearchOption.AllDirectories);

                     foreach ( var retorno in retornoArquivos)
                     {


                                Console.WriteLine(retorno);



                        
                     }

              }

              public void CriarDiretorio(string caminho){

                     var retorno = Directory.CreateDirectory(caminho);

                     Console.WriteLine(retorno.FullName);

              }

              public void ApagarDiretorio(string caminho, bool apagarArquivos){ //Deletou, já era. Não vai para lixeira.

                     Directory.Delete(caminho, apagarArquivos);

                    

              }  

              public void CriarArquivoTexto(String caminho, String conteudo){

                     if (!File.Exists(caminho))

                            File.WriteAllText(caminho,conteudo);

                     

              }    





    }
}