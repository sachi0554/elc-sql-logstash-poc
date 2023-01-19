using ElasticSearchPOC.POCO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nest;

namespace ElasticSearchPOC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly IElasticClient _elasticClient;
        private readonly ILogger<WeatherForecastController> _logger;
        public SearchController(ILogger<WeatherForecastController> logger , IElasticClient elasticClient)
        {
            _logger = logger;
            _elasticClient = elasticClient;
        }
        [HttpGet]
        public async Task<IList<Product>> GetSearch(string keyword)
        {
            
                var result = await _elasticClient.SearchAsync<Product>(s => s.Query(q => q.QueryString(d => d.Query('*' + keyword + '*'))).Size(100));
                var finalResult = result;
                var finalContent = finalResult.Documents.ToList();
                return finalContent;
            
            
        }
    }
}
