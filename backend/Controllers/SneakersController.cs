using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SneakersController : ControllerBase
    {
        Sneakers[] sneakers = new Sneakers[]
        {
            new Sneakers {Id = 1, Name = "Yeezy Boost 350 V2 'Clay'", Brand="Adidas", Gender="Male", Description = "Shoes", Price = 265},
            new Sneakers {Id = 2, Name = "NMD_R1 'Duck Camo'", Brand="Adidas", Gender="Male", Description = "Shoes", Price = 85},
            new Sneakers {Id = 3, Name = "SF Air Force 1 High 'Winter Camo'", Brand="Nike", Gender="Male", Description = "Shoes", Price = 115},
            new Sneakers {Id = 4, Name = "Yeezy Boost 700 'Analog'", Brand="Adidas", Gender="Male", Description = "Shoes", Price = 245},
            new Sneakers {Id = 5, Name = "Pharrell x Solar Hu Glide ST 'Chinese New Year'", Brand="Adidas", Gender="Male", Description = "Shoes", Price = 120},
            new Sneakers {Id = 6, Name = "Air Jordan 1 Mid 'Multicolor Swoosh Black'", Brand="Nike", Gender="Male", Description = "Shoes", Price = 80},
            new Sneakers {Id = 7, Name = "NMD_R1 'Blizzard'", Brand="Adidas", Gender="Male", Description = "Shoes", Price = 100},
            new Sneakers {Id = 8, Name = "Air Jordan 6 Retro 'Infrared' 2019", Brand="Nike", Gender="Male", Description = "Shoes", Price = 190},
            new Sneakers {Id = 9, Name = "Pharrell x NMD Human Race 'Inspiration Pack'", Brand="Adidas", Gender="Male", Description = "Shoes", Price = 220},
            new Sneakers {Id = 10, Name = "NMD_R1 'Carbon'", Brand="Adidas", Gender="Male", Description = "Shoes", Price = 100},
        };
        // GET api/values
        [HttpGet]
        public IEnumerable<Sneakers> Get()
        {
            return sneakers;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var sneaker = sneakers.FirstOrDefault((p) => p.Id == id);

            if(sneaker == null)
            {
                return NotFound();
            }
            return Ok(sneaker);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
