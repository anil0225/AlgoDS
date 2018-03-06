using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class AccountOriginator
    {
        public AccountState CurrentState { get; set; } 
        public string AccountHolder { get; set; }

        public Memento CreateMemento() {
            return new Memento(CurrentState, AccountHolder);
        }

        public void SetMemento(Memento state) {
            CurrentState = state.AccountState;
            AccountHolder = state.AccountGuardian;
        }
    }

    public class AccountState {
        public int CurrentAmmount { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
