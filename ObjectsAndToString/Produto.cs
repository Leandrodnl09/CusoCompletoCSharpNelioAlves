namespace ObjectsAndToString
{
    public class Produto // Nome de classes com letras maiúsculas;
    {
        //Nomes de atributos com letras maiúsculas;
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        
        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2") + ", " + Quantidade + " unidades, Total: $" + ValorTotalEmEstoque().ToString("F2");
        }
    }
}