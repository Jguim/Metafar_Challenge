using Metafar_Challenge.Model.DTOs;
using Microsoft.Extensions.Primitives;

namespace Metafar_Challenge.Db;

public partial class TwelvedataSample
{
    public List<StockDTO> Stocks { get; set; }
    public String status { get; set; }


}
