﻿using DddInPractice.Logic.Utils;

namespace DddInPractice.Logic.UI
{
    public partial class App
    {
        public App()
        {
            Initer.Init(@"Server=(localdb)\MSSQLLocalDB;Database=DddInPractice;Trusted_Connection=true");
        }
    }
}
