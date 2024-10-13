using FS.Data.Base;

namespace FS.Data.Models.Members
{
    public class Member(string name = "") : Model<int>, IMember
    {
        private string _name = name;

        public string Name { get => _name; set => _name = value; }
    }
}
