using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej9.Domain;

public class BankAccount
{
    private AccountType _type;
    private string _number;
    private decimal _balance;
    private Status _status;
    private decimal _interestRate;
    private decimal _overdraftLimit;
    private decimal _commission;
    private string[] _holders;

    public BankAccount(string number, decimal balance, AccountType type, string[] holders)
    {
        _number = number;
        _balance = balance;
        _type = type;
        _status = Status.Active;
        _holders = holders;
    }
    #region Getters/Setters
    public string GetNumber()
    {
        return _number;
    }

    public decimal GetBalance()
    {
        return _balance;
    }
    public AccountType GetAccountType()
    {
        return _type;
    }

    public Status GetStatus()
    {
        return _status;
    }

    public void SetStatus(Status status)
    {
        _status = status;
    }

    public decimal GetInterestRate()
    {
        return _interestRate;
    }

    public void SetInterestRate(decimal interestRate)
    {
        _interestRate = interestRate;
    }

    public decimal GetOverdraftLimit()
    {
        return _overdraftLimit;
    }

    public void SetOverdraftLimit(decimal overdraftLimit)
    {
        _overdraftLimit = overdraftLimit;
    }

    public decimal GetCommission()
    {
        return _commission;
    }

    public void SetCommission(decimal commission)
    {
        _commission = commission;
    }

    public string[] GetHolders()
    {
        return _holders;
    }
    #endregion

    public void Deposit(decimal amount)
    {
        if (_type == AccountType.SavingsAccount)
        {
            _balance += amount;
        }
        else if (_type == AccountType.CheckingAccount)
        {
            amount -= amount * _commission;
            _balance += amount;
        }
    }

    public void Withdraw(decimal amount)
    {
        if (_type == AccountType.SavingsAccount)
        {
            _balance -= amount;
        }
        else if (_type == AccountType.CheckingAccount)
        {
            if (_balance - amount >= -_overdraftLimit)
            {
                _balance -= amount;
            }
            if (_balance < 0)
            {
                _status = Status.Suspended;
            }
        }
    }

    public void ApplyInterest()
    {
        if (_type == AccountType.SavingsAccount)
        {
            _balance += _balance * _interestRate;
        }
    }
}
