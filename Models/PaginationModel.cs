using System.Collections.Generic;
using SuperHero.Models;

namespace SuperHero.Controllers
{
  public class PaginationModel
  {
    public List<Character> Data { get; set; }
    public int Total { get; set; }
    public int PerPage { get;set; }
    public int Page { get;set;}
    public string PreviousPage { get;set;}
    public string NextPage { get; set; }
  }
}