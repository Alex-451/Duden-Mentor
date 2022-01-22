using System.Net.Http;
using DryIoc;

namespace DudenMentor.Avalonia
{
    public static class InversionOfControl
    {
        private static IContainer _container;

        public static IContainer Container => GetOrInitContainer();

        private static IContainer GetOrInitContainer()
        {
            if (_container is null)
                InitializeContainer();

            return _container;
        }

        private static void InitializeContainer()
        {
            _container = new Container(Rules.Default.WithAutoConcreteTypeResolution());
        }
    }
}