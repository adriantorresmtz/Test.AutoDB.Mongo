using AutoDB.Mongo.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ProductApi.Entities;

namespace ProductApi.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        private readonly IRepositoryMongo<Product> _repo;

        public ProductController(IRepositoryMongo<Product> repo)
        {
            this._repo = repo;
        }


        [HttpPost]
        public async Task<ActionResult> Post([FromBody]Product product)
        {
            var result = await _repo.SaveAsync(product);
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var result = await _repo.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(string id)
        {
            var result = await _repo.GetByIdAsync(id);
            return Ok(result);
        }


        [HttpPut]
        public async Task<ActionResult> Update([FromBody] Product product)
        {
            var result = await _repo.SaveAsync(product);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(string id)
        {
            await _repo.DeleteAsync(id);
            return Ok();
        }
    }
}
