using SmsMicroService.Application.UseCases.SendSms;
using System.Reflection;

namespace SmsMicroService.Application
{
    internal static class Assemblies
    {
        public static readonly Assembly Application = typeof(SendSmsCommand).Assembly;
    }
}
