using AluraPet_api.Models;

namespace AluraPet_api.Services;

public interface ITutorService
{
    Task<List<Tutor>> GetAllTutors();
    Task<Tutor> GetTutorById(Guid id);
    Task<Tutor> CreateTutor(Tutor category);
    Task<Tutor> UpdateTutor(Guid id, Tutor tutor);
    Task<bool> DeleteTutor(Guid id);
}