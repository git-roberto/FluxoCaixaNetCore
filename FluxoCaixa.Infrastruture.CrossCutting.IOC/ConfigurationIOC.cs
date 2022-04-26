using Autofac;
using FluxoCaixa.Application.Interfaces;
using FluxoCaixa.Application.Service;
using FluxoCaixa.Domain.Core.Interfaces.Repositorys;
using FluxoCaixa.Domain.Core.Interfaces.Services;
using FluxoCaixa.Domain.Services.Services;
using FluxoCaixa.Infrastruture.CrossCutting.Adapter.Interfaces;
using FluxoCaixa.Infrastruture.CrossCutting.Adapter.Map;
using FluxoCaixa.Infrastruture.Repository.Repositorys;
using System;
using System.Collections.Generic;
using System.Text;

namespace FluxoCaixa.Infrastruture.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Registra IOC

            #region IOC Application
            builder.RegisterType<ApplicationServiceTipoLancamento>().As<IApplicationServiceTipoLancamento>();
            builder.RegisterType<ApplicationServiceLancamento>().As<IApplicationServiceLancamento>();
            #endregion

            #region IOC Services
            builder.RegisterType<ServiceTipoLancamento>().As<IServiceTipoLancamento>();
            builder.RegisterType<ServiceLancamento>().As<IServiceLancamento>();
            #endregion

            #region IOC Repositorys SQL
            builder.RegisterType<RepositoryTipoLancamento>().As<IRepositoryTipoLancamento>();
            builder.RegisterType<RepositoryLancamento>().As<IRepositoryLancamento>();
            #endregion

            #region IOC Mapper
            builder.RegisterType<MapperTipoLancamento>().As<IMapperTipoLancamento>();
            builder.RegisterType<MapperLancamento>().As<IMapperLancamento>();
            #endregion

            #endregion

        }
    }
}
