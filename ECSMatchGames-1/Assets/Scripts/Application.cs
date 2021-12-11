using Entitas;

namespace DefaultNamespace
{
    public class Application
    {
        private readonly Systems _systems;

        public Application(Contexts contexts)
        {
            _systems = new ApplicationFeature(contexts);
        }

        public void Initialize()
        {
            _systems.Initialize();
        }

        public void Execute()
        {
            _systems.Execute();
            _systems.Cleanup();
        }
    }
}