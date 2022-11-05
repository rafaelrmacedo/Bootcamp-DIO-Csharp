using module4.Models;

CheckingAccount checkingAccount = new CheckingAccount(1234, 2500M);

checkingAccount.ShowBalance();
checkingAccount.WithDraw(2500M);
checkingAccount.ShowBalance();














//Abstration
// Person person = new Person();

// person.Name = "Rafael";
// person.Age = 18;
// person.Presentation();