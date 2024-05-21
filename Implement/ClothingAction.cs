using System;
using DIContainerEX.Interface;

namespace DIContainerEX.Implement
{
    public class ClothingAction : ICLothingAction
    {
        public void Save(string clothingName)
        {
            Console.WriteLine("The clothing name: " + clothingName);
        }
    }
}
