namespace src
{
    public class Menu
    {
        private string opcao;
        public string Tipo
        {
            get { return opcao; }
            set { opcao = value; }
        }

        public Menu(string opcaoMenu)
        {
            this.opcao = opcaoMenu ;
        }

        public virtual void Cadastrar()
        {

        }
        public virtual void Quantidade()
        {

        }
        public virtual void Verificar()
        {

        }
        public virtual void Excluir()
        {
            
        }
    }

}