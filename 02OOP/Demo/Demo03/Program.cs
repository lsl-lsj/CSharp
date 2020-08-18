using System;

/*
 * 验证属性值得有效性
 */

namespace Demo03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            User u = new User();

            try
            {
                u.Usernmae = "zhangsan";
                u.Password = "*****";
            }
            catch (Exception e)
            {
                Console.WriteLine($"错误：{e.Message}");
            }
        }
    }

    internal class User
    {
        private string _username;

        public string Usernmae
        {
            get { return _username; }
            set
            {
                if (value.Length > 15)
                {
                    throw new ArgumentException("用户名长度不能超过15个位");
                }
                _username = value;
            }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                if (value.Length < 9)
                {
                    throw new ArgumentException("密码长度不能小于9位");
                }
                _password = value;
            }
        }
    }
}