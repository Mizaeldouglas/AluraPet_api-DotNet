using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AluraPet_api.Models;
using AluraPet_api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AluraPet_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TutorController : ControllerBase
    {
        private readonly ITutorService _tutorService;
        private readonly ILogger<TutorController> _logger;

        public TutorController(ITutorService tutorService, ILogger<TutorController> logger)
        {
            _tutorService = tutorService;
            _logger = logger;
        }


        // GET: api/Tutor
        [HttpGet]
        public async Task<ActionResult<List<Tutor>>> GetAllTutors()
        {
            var tutors = await _tutorService.GetAllTutors();
            return Ok(tutors);
        }

        // GET: api/Tutor/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<ActionResult<Tutor>> GetTutorById(Guid id)
        {
            var tutors = await _tutorService.GetTutorById(id);

            if (tutors == null)
            {
                return NotFound();
            }

            return Ok(tutors);
        }

        // POST: api/Tutor
        [HttpPost]
        public async Task<ActionResult<Tutor>> CreateTutor([FromBody] Tutor tutor)
        {
            var createdTutor = await _tutorService.CreateTutor(tutor);
            return CreatedAtAction(nameof(GetTutorById), new { id = createdTutor.Id }, createdTutor);
        }

        // PUT: api/Tutor/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Tutor>> UpdateTutor(Guid id, [FromBody] Tutor tutor)
        {
            var updatedTutor = await _tutorService.UpdateTutor(id, tutor);
            if (updatedTutor == null)
            {
                return NotFound();
            }

            return Ok(updatedTutor);
        }

        // DELETE: api/Tutor/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(Guid id)
        {
            var result = await _tutorService.DeleteTutor(id);

            if (!result)
            {
                return NotFound();
            }

            return Ok(true);
        }
    }
}