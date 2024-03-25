using FirstDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.Majors
{
    public interface IMajorService 
    {
        void CreateMajor(CreateMajorViewModel model);
        void UpdateMajor(UpdateMajorViewModel model);
        void DeletelMajor(Guid majorId);
        List<MajorViewModel> GetAllMajor();
        MajorViewModel GetMajorById(Guid majorId);
    
    }
    
    public class MajorService : IMajorService
    {
        private readonly StudentDbContext _context;
        public MajorService(StudentDbContext context) 
        {
            _context = context;
        
        }

        public void CreateMajor(CreateMajorViewModel model)
        {
            var major = new Major
            {
                Id =Guid.NewGuid(),
                MajorName=model.MajorName,
                Status = EntityStatus.Active,
                CreatedDate = DateTime.Now,

            };
            _context.Majors.Add(major);
            _context.SaveChanges();


        }

        public void DeletelMajor(Guid majorId)
        {

            var major = _context.Majors.FirstOrDefault(s => s.Id == majorId);
            if (major == null)
            {
                throw new ArgumentException("Major is not found!");
            }
            _context.Majors.Remove(major);
            _context.SaveChanges();
        }

       


        public List<MajorViewModel> GetAllMajor()
        {
            var majors = _context.Majors;
            var majorViewModels = majors.Select(s => new MajorViewModel
            {
                Id = s.Id,
                MajorName = s.MajorName,
                StatusName = s.Status.ToString()



            }).ToList();
            return majorViewModels;
        }

        public MajorViewModel GetMajorById(Guid majorId)
        {
            var major = _context.Majors.FirstOrDefault(s => s.Id == majorId);
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
                    StatusName = major.Status.ToString()

                };
                return majorViewModel;
            
            }
        }

        public void UpdateMajor(UpdateMajorViewModel model)
        {
            var major = _context.Majors.FirstOrDefault(s => s.Id == model.Id);
            if (major == null)
            {
                throw new Exception("major is not found");
            }
            else
            {
                major.MajorName= model.MajorName;
                major.Status = model.Status;
                _context.Majors.Update(major);
                _context.SaveChanges();


            }
        }

        internal void DeletelMajor(MajorViewModel majorToDelete)
        {
            throw new NotImplementedException();
        }
    }

}
