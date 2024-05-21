﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DIContainerEX.DependencyInjectContainer
{
    public class DIContainer
    {
        private static readonly Dictionary<Type, object> ResgisteredModules = new Dictionary<Type, object>();

        public static void SetModule<TInterface, TModule>()
        {
            SetModule(typeof(TInterface), typeof(TModule));
        }

        private static void SetModule(Type interfaceType, Type moduleType)
        {
            if (!interfaceType.IsAssignableFrom(moduleType))
            {
                throw new Exception("Wrong Module type");
            }

            //Find constructor
            var firstConstructor = moduleType.GetConstructors()[0];
            object module = null;
            //For parameterless constructor
            if (!firstConstructor.GetParameters().Any())
            {
                //Initialize the object
                module = firstConstructor.Invoke(null);
            }
            else
            {
                var constructorParameters = firstConstructor.GetParameters(); //db, log, es
                var moduleDependecies = new List<object>();
                foreach (var parameter in constructorParameters)
                {
                    var dependency = GetModule(parameter.ParameterType);
                    moduleDependecies.Add(dependency);
                }
                module = firstConstructor.Invoke(moduleDependecies.ToArray());
            }
            ResgisteredModules.Add(interfaceType, module);
        }

        public static T GetModule<T>()
        {
            return (T)GetModule(typeof(T));
        }

        private static object GetModule(Type interfaceType)
        {
            if (ResgisteredModules.ContainsKey(interfaceType))
            {
                return ResgisteredModules[interfaceType];
            }
            throw new Exception("Module not register");
        }
    }
}
