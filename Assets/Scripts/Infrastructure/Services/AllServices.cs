﻿using Infrastructure.Factory;
using Logic.Ship.Weapon;

namespace Infrastructure.Services
{
    public class AllServices
    {
        private static AllServices instance;
        public static AllServices Container => instance ??= new AllServices();

        public void RegisterSingle<TService>(TService implementation) where TService : IService => 
            Implementation<TService>.ServiceInstance = implementation;
        
        public TService Single<TService>() where TService : IService => 
            Implementation<TService>.ServiceInstance;

        private static class Implementation<TService> where TService : IService
        {
            public static TService ServiceInstance;
        }
    }
}