using cs_notes_and_code.challenges.EmployeeSystem;
using cs_notes_and_code.challenges.NotificationSystem;
using cs_notes_and_code.challenges.NotificationSystem.Interfaces;

DateTime dateSent =  DateTime.UtcNow;

//  Email
INotifier notifier = new EmailNotifier();
AlertService alertService = new AlertService(notifier);
alertService.SendAlert("hello@gmail.com", "Hello! This is my first implementation of Dependency Injection.", dateSent); 


// SMS
INotifier smsNotifier = new SmsNotifier();
AlertService alertService1 = new AlertService(smsNotifier);
alertService1.SendAlert("Jane Doe", "Hi, Jane! Do you want to hang out tonight?", dateSent);