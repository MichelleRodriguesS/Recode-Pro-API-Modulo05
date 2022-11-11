namespace imperiohotel.Model
{
    [Table("Destino")]
    public class Destino
    {
        [Key]
        public int id_destino { get; set; }

        public string cidade { get; set; }

        public string estado { get; set; }

        public double aeroporto { get; set; }
    }
}