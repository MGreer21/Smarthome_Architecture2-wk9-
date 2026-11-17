using SmartHomeController;
try
{
    SmartDevice badDevice = new SmartLight(0, "Red", 0, "test light", false);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

