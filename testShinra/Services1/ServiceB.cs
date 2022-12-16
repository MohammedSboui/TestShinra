using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testShinra.Services
{
    public class ServiceB
    {
        private readonly ServiceA _serviceA;
        private readonly IServiceProvider _serviceProvider;
        public ServiceB(ServiceA serviceA , IServiceProvider serviceProvider)
        {
            _serviceA=serviceA;
            _serviceProvider = serviceProvider;
            
        }
         public void afficher(object state)
    {
        using var scope = _serviceProvider.CreateScope() ;
        var sc = scope.ServiceProvider.GetRequiredService<ServiceA>();
        
    
    }
    }
}