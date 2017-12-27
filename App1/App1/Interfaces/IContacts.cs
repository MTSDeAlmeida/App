using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Interfaces
{
    public interface IContacts
    {
        List<Model.ContatoModel> BuscaContato();
    }
}
