using System;
using System.Collections.Generic;
using System.Linq;
using App1.Droid;
using Xamarin.Forms;
using App1.Droid.Implements;

using Plugin.Contacts;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Plugin.Contacts.Abstractions;

[assembly: Dependency(typeof(AddressBookInformation))]
namespace App1.Droid.Implements
{
    using System.Threading.Tasks;
    using App1.Model;
    using App1.Interfaces;

   // using Xamarin.Contacts;
    using Xamarin.Forms;

    public class AddressBookInformation : IAddressBookInformation
    {
        private AddressBook book = null;

        public AddressBookInformation()
        {
            this.book = new AddressBook(Forms.Context.ApplicationContext);
        }


        public Task<List<Model.Contacts>> GetContacts()
        {
            throw new NotImplementedException();
        }
    }
}