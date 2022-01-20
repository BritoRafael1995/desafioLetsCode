using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BACK.API.Filters
{
    public class ResultFilter : IResultFilter
    {
        public void OnResultExecuting(ResultExecutingContext context)
        {
            var actionName = context.ActionDescriptor.RouteValues.First().Value;

            switch (actionName)
            {
                case "Delete":
                    Console.WriteLine($"{DateTime.Now} - Card {context.ModelState.First().Value.RawValue} - Removido");
                    break;
                case "Put":
                    Console.WriteLine($"{DateTime.Now} - Card {context.ModelState.First().Value.RawValue} - Alterado");
                    break;
            }
                
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
        }
    }
}
