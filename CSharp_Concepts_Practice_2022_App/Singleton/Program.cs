using Singleton;

Logger logger = Logger.GetLogger();


// Retrieve the logger instance again
Logger logger2 = Logger.GetLogger();

// Verify that the same instance is returned
Console.WriteLine("logger == logger2 : " + (logger == logger2)); // should output "True"