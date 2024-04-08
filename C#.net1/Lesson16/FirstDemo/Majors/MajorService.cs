using FirstDemo.Entities;
using FirstDemo.RepositoriesUOW;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.Majors
{
    public interface IMajorService
    {
        Task CreateMajor(CreateMajorViewModel model);
        Task UpdateMajor(UpdateMajorViewModel model);
        Task DeleteMajor(Guid majorId);
        Task<List<MajorViewModel>> GetAllMajor();
        Task<MajorViewModel?> GetMajorById(Guid majorId);
    }

    public class MajorService : IMajorService
    {

        private readonly IGenericRepository<Major, Guid> _majorRepository;
        private readonly IUnitOfWork _unitOfWork;
        public MajorService(
            IGenericRepository<Major, Guid> majorRepository,
            IUnitOfWork unitOfWork
            )
        {

            _majorRepository = majorRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task CreateMajor(CreateMajorViewModel model)
        {
            var major = new Major
            {
                Id = Guid.NewGuid(),
                MajorName = model.MajorName,
                Status = EntityStatus.Active,
                CreatedDate = DateTime.Now,
            };

            _majorRepository.Add(major);
            await _unitOfWork.SaveChange();
        }

        public async Task DeleteMajor(Guid majorId)
        {
            var major = await _majorRepository.FindById(majorId);
            if (major == null)
            {
                throw new Exception("major is not found");
            }
            //_context.Majors.Remove(major);
            //_context.SaveChanges();
            _majorRepository.Delete(major);
            await _unitOfWork.SaveChange();
        }

        public async Task<List<MajorViewModel>> GetAllMajor()
        {
            var majors = _majorRepository.FindAll();
            var majorViewModels = await majors.Select(s => new MajorViewModel
            {
                Id = s.Id,
                MajorName = s.MajorName,
                StatusName = s.Status.ToString()
            }).ToListAsync();
            return majorViewModels;
        }

        public async Task<MajorViewModel?> GetMajorById(Guid majorId)
        {
            //var major = _context.Majors.FirstOrDefault(s => s.Id == majorId);
            var major = await _majorRepository.FindById(majorId);
            if (major == null)
            {
                return null;
            }
            else
            {
                var majorViewModel = new MajorViewModel
                {
                    Id = major.Id,
                    MajorName = major.MajorName,
                    StatusName = major.Status.ToString(),
                    Status = major.Status
                };
                return majorViewModel;
            }
        }

        public async Task UpdateMajor(UpdateMajorViewModel model)
        {
            var major = await _majorRepository.FindById(model.Id);
            if (major == null)
            {
                throw new Exception("major is not found");
            }
            else
            {
                major.MajorName = model.MajorName;
                major.Status = model.Status;
                _majorRepository.Update(major);
                await _unitOfWork.SaveChange();
            }
        }
    }
}


