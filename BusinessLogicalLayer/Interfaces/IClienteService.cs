using Common;
using Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Interfaces
{
    //public interface IEntityCRUD<T> where T: Entity, new()
    //{
    //    Response Insert(T t);

    //}
    public interface IClienteService
    {
        Response Insert(Cliente cliente);
        Response Update(Cliente cliente);
        Response Delete(int id);
        Response Deactivate(int id);
        SingleResponse<Cliente> GetById(int id);
        SingleResponse<Cliente> GetByCPF(string cpf);
        //No mundo real, este dado é paginado!! O fonte pode ser visto na classe ClienteBLL!!
        DataResponse<Cliente> GetClientes();
    }
}
