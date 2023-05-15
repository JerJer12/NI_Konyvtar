using LibrarianClient.Service.LibraryService;
using LibraryApplication.Contracts;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarianClient.Tests
{
    [TestClass]
    internal class AddUserUnitTests
    {

        [TestMethod]
       
        public void AddNewUser()
        {
            User newUser = new User();

            newUser.BirthDate = DateTime.Now;

            
        }  
        

    }
}
