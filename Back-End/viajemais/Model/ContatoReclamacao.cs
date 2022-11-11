namespace imperiohotel.Model
{
    [Table("Compra")]
    public class Compra
    {
        [Key]
        public int id_compra { get; set; }

        public string date { get; set; }

        public string formadepagamento { get; set; }

       
    }
}