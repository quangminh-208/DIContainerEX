using DIContainerEX.Implement;
using DIContainerEX.Interface;

namespace DIContainerEX.Models
{
    public class Clothing
    {

        private ICLothingAction _clothingAction;
        private ILogTerminal _logTerminal;

        public Clothing(ICLothingAction clothingAction, ILogTerminal logTerminal) 
        { 
            _clothingAction = clothingAction;
            _logTerminal = logTerminal;
        }

        public void PrintOut(string clothingName, string clothingBrand)
        {
            _clothingAction.Save(clothingName);
            _logTerminal.LogInfo(clothingBrand);
        }
    }
}
