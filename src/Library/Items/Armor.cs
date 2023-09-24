
namespace RoleplayGame
{
    public class Armor : IItemDefense
    {
        public interface IItemDefense
        {
            int DefenseValue { get; }
        }
        
        public int DefenseValue()
        {
            {
                return 25;
            }
        }
    }

}