using DP.Website.Models;

namespace DP.Website.Domain
{
    public abstract class Builder
    {
         /// 建立物件
        abstract public Home Init();

        abstract public void BuildParent(Home home);
        abstract public void BuildChild(Home home);
        abstract public void BuildPet(Home home);
    }
}