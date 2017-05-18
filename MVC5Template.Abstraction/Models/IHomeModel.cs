using System;

namespace MVC5Template.Abstraction.Models
{
    public interface IHomeModel
    {
        string Name { get; set; }
        int Years { get; set; }
    }
}
