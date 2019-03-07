﻿using ClientCore.Account;

namespace ClientCore.Factory
{
    public interface IAccountSetupFactory
    {
        IAccountProvider Create();
    }
}
