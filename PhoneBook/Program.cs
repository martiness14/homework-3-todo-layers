using System.Text;

Console.OutputEncoding = Encoding.UTF8;   // за да се виждат кирилица
Console.InputEncoding = Encoding.UTF8;

var repository = new ContactRepository();
var view = new ContactView();
var controller = new ContactController(repository, view);

controller.Run();
