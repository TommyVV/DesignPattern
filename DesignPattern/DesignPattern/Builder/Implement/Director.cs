using DesignPattern.Builder.Model;

namespace DesignPattern.Builder.Implement
{
    public class Director
    {
        public Computer Construct(Base.Builder builder)
        {
            return builder.BuildComputer();
        }
    }    
}
