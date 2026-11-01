using Unity;
using Unity.Lifetime;
using Sports_Equipment.Repositories;
using Sports_Equipment.Repositories.Implementations;
using Sports_Equipment.Forms;

namespace Sports_Equipment
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Создаем контейнер и просим его выдать главную форму
            Application.Run(CreateContainer().Resolve<MainForm>());
        }

        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();

            // Регистрация зависимостей (Интерфейс -> Класс-заглушка)
            container.RegisterType<IClientRepository, ClientRepository>(new TransientLifetimeManager());
            container.RegisterType<ITariffRepository, TariffRepository>(new TransientLifetimeManager());
            container.RegisterType<IInventoryItemRepository, InventoryItemRepository>(new TransientLifetimeManager());
            container.RegisterType<IRentalRepository, RentalRepository>(new TransientLifetimeManager());

            return container;
        }
    }
}