﻿

using Microsoft.Extensions.DependencyInjection;
using RG2System_Garage.Domain.Interfaces.Repositories;
using RG2System_Garage.Domain.Interfaces.Repositories.Base;
using RG2System_Garage.Domain.Interfaces.Services;
using RG2System_Garage.Domain.Service;
using RG2System_Garage.Infra.Repositories;
using RG2System_Garage.Infra.Repositories.Transactions;
using RG2System_Garage.Viwer.Formulario;
using System;
using System.Windows.Forms;

namespace RG2System_Garage.Viwer
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(new frmPrincipal());
        }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddScoped<RB2System_GarageContext, RB2System_GarageContext>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddTransient<IRepositoryVeiculo, RepositoryVeiculo>();
            services.AddTransient<IRepositoryProduto, RepositoryProduto>();
            services.AddTransient<IRepositoyCliente, RepositoryCliente>();
            services.AddTransient<IRepositoyClienteVeiculo, RepositoryClienteVeiculo>();
            services.AddTransient<IRepositoryEstoqueProduto, RepositoryEstoqueProduto>();

            services.AddTransient<IServiceVeiculo, ServiceVeiculo>();
            services.AddTransient<IServiceProduto, ServiceProduto>();
            services.AddTransient<IServiceCliente, ServiceCliente>();

            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
