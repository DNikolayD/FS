namespace FS.Data.Models.Members
{
    public class Member(string name = "") : Model<int>, IMember
    {
        private string _name = name;

        [ShortTextLengthValidation(nameof(Member), nameof(Name))]
        public string Name { get => _name; set => _name = value; }
    }
}
