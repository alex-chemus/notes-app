using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://metanit.com/sharp/patterns/2.3.php

namespace Notes
{
    internal class UserState
    {
        private static UserState instance;

        public int id;

        private UserState(int id) {
            this.id = id;
        }

        public static UserState getInstance()
        {
            return instance;
        }

        public static void createInstance(int id)
        {
            instance = new UserState(id);
        }
    }
}
