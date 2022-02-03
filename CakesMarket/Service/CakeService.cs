using AutoMapper;
using CakesMarket.Models;
using CakesMarket.Models.Model;
using CakesMarket.Models.Repository;
using CakesMarket.Models.Services;
using CakesMarket.Models.ViewModel;
using CakesMarket.Web.Repository;
using CakesMarket.Web.UOfWork;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CakesMarket.Web.Service
{
    public class CakeService : ICakeService
    {
        private readonly ICakeRepository _repository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CakeService(ICakeRepository repository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this._unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }
        public void Add(Cake cake)
        {
            try
            {
                _repository.Add(cake);
                _unitOfWork.SaveChanges(); 
            }
            catch(Exception ex)
            {
                Trace.Write(ex);
            }
        }

        public CakesListViewModel GetAll()
        {
            CakesListViewModel cakesListView = new CakesListViewModel();
            cakesListView.Cakes = _mapper.Map<IEnumerable<CakeViewModel>>(_repository.GetAll());

            return cakesListView;
        }

        public void Remove(Cake cake)
        {
            try
            {
                _repository.Delete(cake);
                _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                Trace.Write(ex);
            }
        }

        public void Update(Cake cake)
        {
            try
            {
                _repository.Update(cake);
                _unitOfWork.SaveChanges();
            }
            catch (Exception ex)
            {
                Trace.Write(ex);
            }
        }
    }
}
