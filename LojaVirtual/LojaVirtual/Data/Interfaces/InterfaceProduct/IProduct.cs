using Data.Interfaces.Generics;
using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces.InterfaceProduct
{
    public interface IProduct : IGeneric<Produto>
    {
        Task Add(Produto objeto);
    }
}
