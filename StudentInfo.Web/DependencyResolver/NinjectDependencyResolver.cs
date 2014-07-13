using Ninject;
using StudentInfo.Domain.Repository;
using StudentInfo.Infrastructure.Data.Repository;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace StudentInfo.Web.DependencyResolver
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            kernel.Bind<IRegistrationRepository>().To<RegistrationRepository>();
        }
    }
}
