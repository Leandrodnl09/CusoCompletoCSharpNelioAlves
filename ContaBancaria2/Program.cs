using ContaBancaria2.Entities;

 
Account acc = new Account(1001, "Alex", 0.0);

BusinessAccount bacc = new BusinessAccount(8010, "Bob Bronw", 100.00, 500.00);

Console.WriteLine(bacc.Balance);


//UPCASTING;
Account acc1 = bacc;

Account acc2 = new BusinessAccount(1003, "Rafa", 0.0, 200.0);

Account acc3 = new SavingAccount(1004, "Anna", 0.0, 0.01);

//DOWNCASTING;
BusinessAccount acc4 = (BusinessAccount)acc2;
acc4.Loan(100.00);

//BusinessAccount acc5 = (BusinessAccount)acc3; error;

if(acc3 is BusinessAccount)
{
    BusinessAccount acc5 = (BusinessAccount)acc3;
}

if (acc3 is SavingAccount)
{
    SavingAccount acc5 = (SavingAccount)acc3;
    acc5.UpdateBalance();
    Console.WriteLine("Update!");
    
}


