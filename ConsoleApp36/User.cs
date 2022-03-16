using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp36
{
    internal class _UserName
    {
        public _UserName(string _UserName)
        {
            this._UserName = _UserName;
        }
        public string _UserName;
        public string _Password;

        public string Username
        {
            get => this.Username;
            set
            {
                if (Username.Length > 5 && Username.Length < 25)
                {
                    this._UserName = value;
                }

    
        }   }
            
        
        public string Password
        {
            get => this.Password;
            set
            {
                for (int i = 0; i < Password.Length; i++)
                {
                    if (Char.IsUpper(Password[i]))
                    {
                        this._Password = value;
                    }
                    if (Char.IsLower(Password[i]))
                    {
                        this._Password = value;
                    }
                    if (Char.IsDigit(Password[i]))
                    {
                        this._Password = value;
                    }
                    if (Password.Length > 7 && Password.Length < 25)
                    {
                        this._Password = value;
                    }

                }

            }


        }
    }
}
