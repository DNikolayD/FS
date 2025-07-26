using FS.Data.Base;
using FS.Data.Models.FinanceTypes;
using FS.Reusable.Attributes.ErrorHandlingAtrtibutes;

namespace FS.Data.Models.FinanceInstitutions
{
    public class FinanceInstitution(string name = "") : Model<int>, IFinanceInstitution
    {
        private string _name = name;

        [LengthValidation(nameof(FinanceInstitution), nameof(Name))]
        public string Name { get => _name; set => _name = value; }
        
        public required IEnumerable<IFinanceType> FinanceTypes { get; set; }
    }
}