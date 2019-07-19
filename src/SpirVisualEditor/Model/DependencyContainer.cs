using Autofac;
using Autofac.Core;
using SpirVisualEditor.ViewModel;
using Toe.Scripting.WPF.ViewModels;

namespace SpirVisualEditor.Model
{
    public class DependencyContainer
    {
        private readonly IContainer _container;

        public DependencyContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterInstance(this).AsSelf().SingleInstance();

            builder.RegisterType<MainViewModel>().AsSelf().SingleInstance();
            builder.RegisterType<ScriptViewModel>().AsSelf().SingleInstance();

            _container = builder.Build();
        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        public T ResolveNamed<T>(string name, params Parameter[] parameters)
        {
            return _container.ResolveNamed<T>(name, parameters);
        }

        public bool TryResolveNamed<T>(string name, out T service, params Parameter[] parameters)
        {
            object res;
            if (!_container.TryResolveService(new KeyedService(name, typeof(T)), parameters,
                out res))
            {
                service = default;
                return false;
            }

            service = (T) res;
            return true;
        }
    }
}