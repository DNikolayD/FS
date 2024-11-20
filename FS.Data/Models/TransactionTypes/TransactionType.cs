using FS.Data.Attributes;
using FS.Data.Base;

namespace FS.Data.Models.TransactionTypes
{
    public class TransactionType(string name = "") : Model<int>, ITransactionType
    {
        private string _name = name;

        [ShortTextValidation(nameof(TransactionType), nameof(Name))]
        public string Name { get => _name; set => _name = value; }
    }
}
