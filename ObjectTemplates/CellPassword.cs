
namespace Hidepass.ObjectTemplates
{
    internal class CellPassword(/*int id,*/ string name, string description, string login, string password)
    {
        //public int Id { get; } = id;
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
        public string Login {  get; set; } = login;
        public string Password { get; set; } = password;
        public string CreateTime { get; } = DateTime.Now.ToString("dd.MM.y HH:m");
        public string ChangeTime { get; set; } = DateTime.Now.ToString("dd.MM.y HH:m");
    }
}
