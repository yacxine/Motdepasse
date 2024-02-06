namespace libMotdepasse
{
    public class Motdepasse
    {
        private string password;
        private string login;
        public Motdepasse(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public bool Verifier(string mdp)
        {
            bool flag = false;
            if (password.Equals(password)) { flag = true; }
            return flag;

        }
        public bool Longueur()
        {
            bool flag = false;
            if (password.Length > 12)
            {
                flag = true;
            }
            return flag;
        }
        public bool EstNumeric()
        {
            bool flag = false;
            int lng = password.Length;
            for (int i = 0; i < lng; i++)
            {
                if (char.IsNumber(password, i))
                {
                    flag = true;
                }
            }
            return flag;
        }
        public bool EstMajuscule()
        {
            bool flag = false;
            int lng = password.Length;
            for (int i = 0; i < lng; i++)
            {
                if (char.IsUpper(password, i))
                {
                    flag = true;
                }
            }
            return flag;



        }
        public bool EstSpecial()
        {
            bool flag = false;
            int lng = password.Length;
            for (int i = 0; i < lng; i++)
            {
                if (char.IsLetterOrDigit(password, i))
                {
                    flag = true;
                }
            }
            return flag;
        }
    }
}