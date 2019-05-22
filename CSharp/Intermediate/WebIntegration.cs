using System;
namespace CSharp.Intermediate
{
    public class WebIntegration
    {
        private readonly Logger _logger;
        private readonly SuccessMessage _successfull;
        public WebIntegration(Logger logger, SuccessMessage success)
        {
            _logger = logger;
            _successfull = success;
        }

        public void StartIntegration()
        {
            _logger.Log("Web Integration started at {0}", DateTime.Now);
            if (true)
            {
                _successfull.Successfull("Intregation Successfully Completed!!!");
            };
        }


    }
}
