using Metafar_Challenge.Models;
using System.Linq.Expressions;

namespace WebApp.WebTools.DataTable
{
    public class DataTableResponse<T, K> where T : Actions where K : DataTableRow
    {
        public DataTableResponse()
        {

        }
        public DataTableResponse(DataTableRequest req, IQueryable<T> query, Func<T, K> selector, Expression<Func<T, bool>> predicate = null, Expression<Func<T, object>> order = null)
        {
            recordsTotal = query.Count();

            if (predicate != null)
                query = query.Where(predicate);

            recordsFiltered = query.Count();

            if (req.order.Count == 0)
            {  /*query = query.OrderByDescending(t => t.CreatedDate); */ }
            else
            {
                if (order != null)
                {
                    if (req.order.First().dir == "asc")
                        query = query.AsEnumerable().OrderBy(order.Compile()).AsQueryable();
                    else
                        query = query.AsEnumerable().OrderByDescending(order.Compile()).AsQueryable();

                }
                else { /*query = query.AsEnumerable().OrderBy(p => p.Name).AsQueryable(); */ }
            }
            if (req.length >= 0)
            {
                query = query.Skip((req.page - 1) * req.length).Take(req.length);
            }

            draw = req.draw;

            data = query.ToList().Select(selector).ToList();
        }

        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public object data { get; set; }
        public string error { get; set; }
    }
}