namespace AgendamentoDeTarefa.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public EnumStatusTarefa Status { get; set; }
    }
}
