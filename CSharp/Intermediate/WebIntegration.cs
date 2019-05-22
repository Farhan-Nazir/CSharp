using System;
namespace CSharp.Intermediate
{
    public class WebIntegration
    {
        private readonly Logger _logger;
        public WebIntegration(Logger logger)
        {
            _logger = logger;
        }

        public void StartIntegration()
        {
            _logger.Log("Web Integration started at {0}", DateTime.Now);
        }


    }
}
