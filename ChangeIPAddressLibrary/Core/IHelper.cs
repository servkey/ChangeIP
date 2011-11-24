using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChangeIPAddressLibrary.Core
{
    public interface IHelper<E>
    {
        void Add(E e);
        void Delete(E e);
        E GetProfile(E e);
        List<E> GetAll();
    }
}
