using Command_Demo;

var dataReceiver = new DataReceiver();
var invoker = new DataCommandInvoker();
invoker.SetCommand(new UpsertCommand("item1", "value1", dataReceiver));
invoker.ExecuteCommand();
invoker.SetCommand(new DeleteCommand("item1", dataReceiver));
invoker.ExecuteCommand();
Console.ReadKey();