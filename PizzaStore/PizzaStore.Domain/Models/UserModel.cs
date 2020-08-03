using System.Collections.Generic;

namespace PizzaStore.Domain.Models
{
  public class UserModel : AModel
  {
    public CrustModel Crust { get; set; }
    public SizeModel Size { get; set; }
    public List<ToppingModel> Toppings { get; set; }
  }
}
