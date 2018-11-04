using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserPOJO
    {
        public int Id { get; set; }
        public String Nickname { get; set; }
        public String Password { get; set; }
        public String Type { get; set; }

        public UserPOJO() { }

        public UserPOJO(int id, String nickname, String password, String type) {
            Id = id;
            Nickname = nickname;
            Password = password;
            Type = type;
        }

        public UserPOJO(String nickname, String password)
        {
            Nickname = nickname;
            Password = password;
        }

    }
}
