using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaStore.Domain.Factories;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client.Models
{
  public class PizzaViewModel
  {
    //out to the client
    public List<CrustModel> Crusts { get; set; }
    public List<SizeModel> Sizes { get; set; }
    public List<ToppingModel> Toppings { get; set; }

    // public PizzaViewModel(repository)
    // {
    //   Crusts = new List<CrustModel>() {new CrustModel};
    // }
    
    //in from the client
    [Required]
    public CrustModel Crust { get; set; }

    [Required]
    public SizeModel Size { get; set; }

    [Range(2,5)]
    public List<ToppingModel> SelectedToppings { get; set; }
    public bool SelectedTopping { get; set; }
  }
}
