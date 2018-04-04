using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using DasMulli.Win32.ServiceUtils;

namespace EmailService
{
    public class Program
    {
        private const string RunAsServiceFlag = "--run-as-service";
        private const string RegisterServiceFlag = "--register-service";
        private const string UnregisterServiceFlag = "--unregister-service";

        internal const string ServiceName = "EmailService";
        private const string ServiceDisplayName = "ESB Demo EmailService";
        private const string ServiceDescription = "Controls sending of emails via Maropost/SendGrid.";

        public static void Main(string[] args)
        {
            try
            {
                if (args.Contains(RunAsServiceFlag))
                {
                    RunAsService(args);
                }
                else if (args.Contains(RegisterServiceFlag))
                {
                    RegisterService();
                }
                else if (args.Contains(UnregisterServiceFlag))
                {
                    UnregisterService();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error ocurred: {ex.Message}");
            }
        }

        private static void RunAsService(string[] args)
        {
            var testService = new EmailService(args.Where(a => a != RunAsServiceFlag).ToArray());
            var serviceHost = new Win32ServiceHost(testService);
            serviceHost.Run();
        }

        private static void RegisterService()
        {
            // Environment.GetCommandLineArgs() includes the current DLL from a "dotnet my.dll --register-service" call, which is not passed to Main()
            var remainingArgs = Environment.GetCommandLineArgs()
                .Where(arg => arg != RegisterServiceFlag)
                .Select(EscapeCommandLineArgument)
                .Append(RunAsServiceFlag);

            var host = Process.GetCurrentProcess().MainModule.FileName;

            if (!host.EndsWith("dotnet.exe", StringComparison.OrdinalIgnoreCase))
            {
                // For self-contained apps, skip the dll path
                remainingArgs = remainingArgs.Skip(1);
            }

            var fullServiceCommand = host + " " + string.Join(" ", remainingArgs);

            // Do not use LocalSystem in production.. but this is good for demos as LocalSystem will have access to some random git-clone path
            // Note that when the service is already registered and running, it will be reconfigured but not restarted
            var serviceDefinition = new ServiceDefinitionBuilder(ServiceName)
                .WithDisplayName(ServiceDisplayName)
                .WithDescription(ServiceDescription)
                .WithBinaryPath(fullServiceCommand)
                .WithCredentials(Win32ServiceCredentials.LocalSystem)
                .WithAutoStart(true)
                .Build();

            new Win32ServiceManager().CreateOrUpdateService(serviceDefinition, startImmediately: true);

            Console.WriteLine($@"Successfully registered and started service ""{ServiceDisplayName}"" (""{ServiceDescription}"")");
        }

        private static void UnregisterService()
        {
            new Win32ServiceManager()
                .DeleteService(ServiceName);

            Console.WriteLine($@"Successfully unregistered service ""{ServiceDisplayName}"" (""{ServiceDescription}"")");
        }

        private static string EscapeCommandLineArgument(string arg)
        {
            // http://stackoverflow.com/a/6040946/784387
            arg = Regex.Replace(arg, @"(\\*)" + "\"", @"$1$1\" + "\"");
            arg = "\"" + Regex.Replace(arg, @"(\\+)$", @"$1$1") + "\"";
            return arg;
        }
    }
}
