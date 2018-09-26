namespace Sistemas.Infrastructure
{
    using ViewModels;
    public class Instancelocator
    {
       public MainViewModel Main{get;set;}

        public Instancelocator()
        {
            Main = new MainViewModel();
        }
    }
}
