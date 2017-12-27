using System;
using System.Collections.Generic;
using System.Linq;
using Android.Views;
using App1.Model;
using System.Threading.Tasks;
using Plugin.Contacts;
using Plugin.Permissions;
using Xamarin.Forms;
using static Android.Manifest;
using Plugin.Permissions.Abstractions;
using Plugin.Contacts.Abstractions;
using App1.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(App1.Droid.Implements.Contacts))]
namespace App1.Droid.Implements
{
    public class Contacts : App1.Interfaces.IContacts
    {
        public Contacts() { }


        public async Task<List<Model.ContatoModel>> BuscaContato()
        {       
            List<Model.ContatoModel> ct = new List<Model.ContatoModel>();
            var book = new AddressBook(Forms.Context);
            if (true)
            {
                foreach (Contact contact in book.OrderBy(c => c.LastName))
                {
                    ct.Add(new Model.ContatoModel()
                    {
                        Nome = contact.DisplayName,
                        Fone = contact.Phones.Any() ? contact.Phones.FirstOrDefault().Number : ""
                    });
                }
            }          

            return ct;
        }

        List<ContatoModel> Interfaces.IContacts.BuscaContato()
        {
            return new List<Model.ContatoModel>{
                new ContatoModel(){Nome="Arthur",Fone="+55 (31) 1111-1111"},
                new ContatoModel(){Nome="Daniel",Fone="+55 (31) 2222-2222"},
                new ContatoModel(){Nome="Micaella",Fone="+55 (31) 3333-3333"},
                new ContatoModel(){Nome="Rafael",Fone="+55 (31) 4444-4444"},
            };
        }
    }
}