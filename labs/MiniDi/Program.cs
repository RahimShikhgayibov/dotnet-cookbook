using MiniDi;

var emailOrders = new OrderService(new EmailSender());
emailOrders.CreateOrder("Laptop");

var smsOrders = new OrderService(new SmsSender());
smsOrders.CreateOrder("Phone");