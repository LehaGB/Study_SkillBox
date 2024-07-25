using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._4
{

    // 7.4 Описание членов структуры: свойства

    /// <summary>
    /// Позователь
    /// </summary>
    struct Account
    {
        /// <summary>
        /// Логин
        /// </summary>
        private string _login;

        /// <summary>
        /// Свойство о замене логина
        /// </summary>
        public string Login
        {
            get { return this._login; }
        }

        /// <summary>
        /// Пароль
        /// </summary>
        private string _password;

        /// <summary>
        /// Установка нового пароля
        /// </summary>
        /// <param name="Password">Новый пароль</param>
        public string Paswword
        {
            get { return this._password; }
            set { this._password = value; }
        }

        /// <summary>
        /// Создание учетной записи
        /// </summary>
        /// <param name="Login"></param>
        /// <param name="Password"></param>
        public Account(string Login, string Password)
        {
            this._login = Login;
            this._password = Password;
        }
    }
}
