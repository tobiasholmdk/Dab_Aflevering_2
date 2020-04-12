using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dab_aflevering_2.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Dab_aflevering_2.Pages
{
    public class IndexModel : PageModel
    {
      //  private readonly Repository<> repository;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            
        }
    }
}