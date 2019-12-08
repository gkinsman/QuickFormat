using System.Collections.Generic;
using Autofac;

namespace QuickFormat
{
    public static class Util
    {
        public static string TryAllFormatters(string junk)
        {
            var cb = new ContainerBuilder();
            
            cb.RegisterAssemblyTypes(typeof(IFormatterAssembly).Assembly)
                .As<IJunkFormatter>();

            var container = cb.Build();

            foreach (var formatter in container.Resolve<IEnumerable<IJunkFormatter>>())
            {
                if (formatter.TryFormatJunk(junk, out var result))
                {
                    return result;
                }
            }

            return null;
        }
    }
}