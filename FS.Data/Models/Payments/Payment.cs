// ReSharper disable MissingXmlDoc
namespace FS.Data.Models.Payments;

using Transactions;

public class Payment(ITransaction transaction) : Model<string>, IPayment
{
    public float Amount => Transaction.SumToPay;

    public string TransactionId => Transaction.Id;

    public ITransaction Transaction => transaction;
}