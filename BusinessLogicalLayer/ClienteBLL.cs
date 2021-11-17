using BusinessLogicalLayer.Interfaces;
using Common;
using Metadata;
using System;
using System.Text;

namespace BusinessLogicalLayer
{
    public class ClienteBLL : IClienteService
    {
        public Response Insert(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Response Update(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Response Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Response Deactivate(int id)
        {
            throw new NotImplementedException();
        }

        public SingleResponse<Cliente> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public SingleResponse<Cliente> GetByCPF(string cpf)
        {
            throw new NotImplementedException();
        }

        public DataResponse<Cliente> GetClientes()
        {
            throw new NotImplementedException();
        }
    }
}
