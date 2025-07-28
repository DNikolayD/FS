namespace FS.Data.Models.TransactionTypes
{
    public interface ITransactionType : IModel<int>
    {
        public string Name { get; set; }
    }
}
