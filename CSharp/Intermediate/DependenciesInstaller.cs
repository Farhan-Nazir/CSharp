using System;
namespace CSharp.Intermediate
{
    public class DependenciesInstaller
    {
        private readonly Logger _logger;
        public DependenciesInstaller(Logger logger)
        {
            _logger = logger;
        }
        public void DependenciesInstallerStarted()
        {
            _logger.Log("Dependencied Installer started at {0}", DateTime.Now);
        }
    }
}
