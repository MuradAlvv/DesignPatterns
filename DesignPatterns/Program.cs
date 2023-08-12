using DesignPatterns.AbstractFactory;
using DesignPatterns.AbstractFactory.Button;
using DesignPatterns.AbstractFactory.Cursor;
using DesignPatterns.Adapter;
using DesignPatterns.Builder;
using DesignPatterns.Command;
using DesignPatterns.Composite.GraphicExample;
using DesignPatterns.Proxy;
using DesignPatterns.State;

#region AbstractFactory

string os = "windows";

IGUIFactory factory = os switch
{
    "windows" => new WindowsGUIFactory(),
    "mac" => new MacGUIFactory(),
    _ => throw new ArgumentException(),
};

IButton button = factory.CreateButton();
ICursor cursor = factory.CreateCursor();

button.OnClick();
cursor.Hide();

#endregion

#region Builder

Person person = PersonBuilder.Builder()
    .Name("test")
    .Age(20)
    .Address("address")
    .Build();

#endregion

#region Adapter

JsonProcessor jsonProcessor = new JsonProcessor();
IXmlProcessor jsonLib = new JsonAdapter(jsonProcessor);
jsonLib.Process(new Xml("..."));

#endregion

#region Composite

Dot dot = new(1, 2);
Circle circle = new(0, 0, 1);
CompoundGraphic cg0 = new();
cg0.Add(circle);
cg0.Add(dot);

CompoundGraphic cg1 = new();
cg1.Add(new Circle(1, 2, 3));
cg1.Add(new Dot(-4, 8));
cg1.Add(cg0);

cg1.Move(1, 3);
cg1.Draw();

#endregion

#region Proxy

IProductRepository repository = new ProductRepository();
IProductRepository proxy = new CachedProductRepository(repository);
ProductService productService = new ProductService(proxy);

productService.GetById(2);
productService.GetById(0);
productService.GetById(4);
productService.GetById(2);
productService.GetById(0);
productService.GetById(5);

#endregion

#region State

Package package = new Package();
package.PrintStatus();
package.NextState();
package.PrintStatus();
package.NextState();
package.PrintStatus();
package.NextState();
package.PrintStatus();

#endregion

#region Command

InputHandler inputHandler = new InputHandler();
Editor editor = new Editor(inputHandler);
editor.Select();
editor.Undo();
editor.Redo();
#endregion
