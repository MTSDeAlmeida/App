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
        private AddressBook book = null;
        public Contacts() {
            this.book = new AddressBook(Forms.Context.ApplicationContext);
        }

        public async Task<List<Model.ContatoModel>> BuscaContato()
        {
            var contacts = new List<ContatoModel>();
            // var permissionResult = await this.book.RequestPermission();
            var permissionResult = true;
            if (permissionResult)
            {
                if (!this.book.Any())
                {
                    Console.WriteLine("No contacts found");
                }

                foreach (Contact contact in book.OrderBy(c => c.LastName))
                {
                    // Note: on certain android device(Htc for example) it show name in DisplayName Field
                    contacts.Add(new ContatoModel() { Nome = contact.FirstName });
                }
            }

            return contacts;
         
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