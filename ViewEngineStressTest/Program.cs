using Furion.ViewEngine;
ViewEngine _viewEngine = new ViewEngine();
for (int i = 0; i < 100000; i++)
{
    _viewEngine.RunCompile("Hello @Model.Name", new { Name = "Furion" });
}
