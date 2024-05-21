using System;
using DIContainerEX.DependencyInjectContainer;
using DIContainerEX.Interface;
using DIContainerEX.Implement;
using DIContainerEX.Models;

namespace DIContainerEX
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DIContainer.SetModule<ICLothingAction, ClothingAction>();
            DIContainer.SetModule<ILogTerminal, LogTerminal>();
            DIContainer.SetModule<Clothing, Clothing>();

            var myClothing = DIContainer.GetModule<Clothing>();

            myClothing.PrintOut("T-Shirt", "Coolmate");

        }
    }
}
