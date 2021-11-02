namespace Exercicio_16
{
    public class Livros
    {
        public int QntTotal=0;

        public int AdicionarLivro(int qnt){
            return QntTotal += qnt;
        }

        public int RemoverLivro(int qnt){
            return QntTotal -= qnt;
        }

        public override string ToString()
        {
            return "Quantidade total de livros: " + QntTotal;
        }
        
    }
}