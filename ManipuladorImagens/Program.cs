namespace ManipuladorImagens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var imagemFundo = @"./Imagens/fundo.png";
            var imagem = @"./Imagens/assinatura.png";
            var saida = @"./Imagens/imagem_nova.png";
            LenticularImage.CreateLenticularImage(imagemFundo, imagem,saida, 255);
        }
    }
}