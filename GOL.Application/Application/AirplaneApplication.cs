using System;
using System.Collections.Generic;
using System.Text;
using GOL.Application.IApplication;
using AutoMapper;
using GOL.Domain;

namespace GOL.Application
{
    public class AirplaneApplication : IAirplaneApplication
    {
        private readonly IAirplaneRepository _repository;
        public AirplaneApplication(IAirplaneRepository repository)
        {
            _repository = repository;
        }

        public void Apagar(AirplaneViewModel registro)
        {
            _repository.Apagar(Mapper.Map<AirplaneViewModel,Airplane>(registro));
        }

        public void Atualizar(AirplaneViewModel registro)
        {
            _repository.Atualizar(Mapper.Map<AirplaneViewModel, Airplane>(registro));
        }

        public void Inserir(AirplaneViewModel registro)
        {
            _repository.Inserir(Mapper.Map<AirplaneViewModel, Airplane>(registro));
        }

        public IEnumerable<AirplaneViewModel> Listar()
        {
             return Mapper.Map<IEnumerable<Airplane>,IEnumerable<AirplaneViewModel>>(_repository.Listar());
       
        }

        public AirplaneViewModel PesquisarPorId(int id)
        {
            return Mapper.Map<Airplane, AirplaneViewModel>(_repository.PesquisarPorId(id));
        }
    }
}
