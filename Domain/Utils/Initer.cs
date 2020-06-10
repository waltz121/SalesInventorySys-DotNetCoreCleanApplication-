using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Utils
{
    public static class Initer
    {
        public static void Init(string ConnectionString)
        {
            SessionFactory.Init(ConnectionString);
        }
    }
}
