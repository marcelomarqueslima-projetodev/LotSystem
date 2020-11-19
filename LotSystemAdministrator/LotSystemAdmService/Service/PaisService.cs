using LotSystemAdmDomain.Entities;
using LotSystemAdmDomain.Interfaces;
using LotSystemAdmService.Validator;
using System.Collections.Generic;
using FluentValidation;
using System;
using System.ComponentModel.DataAnnotations;

namespace LotSystemAdmService.Service
{
    public class PaisService : IPaisService
    {
        private readonly IPaisRepository _paisRepository;

        public PaisService(IPaisRepository paisRepository)
        {
            _paisRepository = paisRepository;
        }

        public IList<Pais> Browse() => _paisRepository.GetAll();

        public void Delete(int id)
        {
            _paisRepository.Remove(id);
        }

        public Pais Insert(Pais pais)
        {
            Validate(pais, new PaisValidator());
            _paisRepository.Save(pais);
            return pais;

        }

        public Pais RecoverById(int id) => _paisRepository.GetById(id);

        public Pais Update(Pais pais)
        {
            Validate(pais, new PaisValidator());
            _paisRepository.Save(pais);
            return pais;
            throw new NotImplementedException();
        }

        private void Validate(Pais pais, PaisValidator validator)
        {
            if(pais == null)
              throw new Exception("Pais não encontrado!");
            validator.ValidateAndThrow(pais);
        }
    }
}
