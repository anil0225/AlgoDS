using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Memento
    {
        private AccountState _accountState;
        private string _acountGuardian;

        public Memento(AccountState accountState, string accountGuardian)
        {
            this._accountState = new AccountState
            {
                CurrentAmmount = accountState.CurrentAmmount,
                LastUpdated = accountState.LastUpdated
            };
            this._acountGuardian = accountGuardian;
        }

        public AccountState AccountState
        {
            get
            {
                return _accountState;
            }
        }

        public string AccountGuardian
        {
            get
            {
                return _acountGuardian;
            }
        }
    }
}
