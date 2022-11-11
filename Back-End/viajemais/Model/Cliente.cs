namespace imperiohotel.Model
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        public string Nome { get; set; }

        public string cpf { get; set; }
        
        public string Nascimento { get; set; }

        public string telefone { get; set; }
    }
}