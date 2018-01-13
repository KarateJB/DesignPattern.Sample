using DP.Website.Models;

namespace DP.Website.Domain
{
    public abstract class Builder
    {
         /// 建立物件
        abstract public Home Init();

        abstract protected void CreateParent(Home home);
        abstract protected void CreateChild(Home home);
        abstract protected void CreatePet(Home home);
    }
}