namespace tictactoe.Models
{
    public class User
    {
        public User(string name,string nickname)
        {
            Name=name;
            Nickname=nickname;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Nickname {get; set;}

        
        public string ToString()
        {
            return $"Имя:{Name} Ник:{Nickname}";
        }
    }
}
