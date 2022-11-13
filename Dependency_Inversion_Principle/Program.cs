
// See https://aka.ms/new-console-template for more information
using Dependency_Inversion_Principle;

Console.WriteLine("Hello, World!");

MailService MailService = new ();
MailService.SendMail(new Hotmail(), "Onur Yurdagelen", "Hello!");MailService.SendMail(new Gmail(), "Onur Yurdagelen", "Hello!");