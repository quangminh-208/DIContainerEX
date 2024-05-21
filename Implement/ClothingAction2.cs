using DIContainerEX.Interface;
using System;

namespace DIContainerEX.Implement
{
    public class ClothingAction2 : ICLothingAction
    {
        public void Save(string clothingName)
        {
            Console.WriteLine("In other action, the clothing name: " + clothingName);
        }
    }
}
