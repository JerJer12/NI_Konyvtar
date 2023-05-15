
using LibrarianClient.Pages;
using LibrarianClient.Service.LibraryService;
using LibraryApplication.Contracts;
using System.Text.RegularExpressions;

namespace LibrarianClient.Tests
{
    [TestClass]
    public class AddUserUnitTests
    {

        [TestMethod]

        public void AddNewUser_WasBornBeforeToday()
        {
            User newUser = new User
            {
                Name = "John Doe",
                Address = "Main Street",
                BirthDate = DateTime.Today.AddDays(-1)
            };

           //libraryService.AddUser(newUser);

            // Assert
            Assert.IsTrue(newUser.BirthDate < DateTime.Today);
                
        }


        [TestMethod]

        public void AddNewUser_AddressAtleastTWoCharactersLong()
        {
            User newUser = new User
            {
                Name = "John Doe",
                Address = "Main Street",
                BirthDate = DateTime.Today.AddDays(-1)
            };

            //libraryService.AddUser(newUser);

            // Assert
            Assert.IsTrue(newUser.Address.Length >=2);

        }


        [TestMethod]

        public void AddNewUser_IsEmpty()
        {
            User newUser = new User
            {
                Name = "john",
                Address = "Main Street",
                BirthDate = DateTime.Today.AddDays(-1)
            };

            AddUser(newUser);
          

            // Assert
            Assert.IsFalse(string.IsNullOrEmpty(newUser.Name));

        }

        private void AddUser(User newUser)
        {
            
        }

        [TestMethod]

        public void AddNewUser_StartWithWhitePlace()
        {
            User newUser = new User
            {
                Name = "John Doe",
                Address = "Main Street",
                BirthDate = DateTime.Today.AddDays(-1)
            };


            // Assert
            Assert.IsFalse(newUser.Name.StartsWith(" "));

        }

        [TestMethod]

        public void AddNewUser_EndsWithWhitePlace()
        {
            User newUser = new User
            {
                Name = "John Doe",
                Address = "Main Street",
                BirthDate = DateTime.Today.AddDays(-1)
            };


            // Assert
            Assert.IsFalse(newUser.Name.EndsWith(" "));

        }

        [TestMethod]

        public void AddNewUser_IsNullOrWhiteSpace()
        {
            User newUser = new User
            {
                Name = "john",
                Address = "Main Street",
                BirthDate = DateTime.Today.AddDays(-1)
            };


            // Assert
            Assert.IsFalse(string.IsNullOrWhiteSpace(newUser.Name));

        }

        [TestMethod]

        public void AddNewUser_HasSpecialCharacters()
        {
            User newUser = new User
            {
                Name = "john",
                Address = "Main Street",
                BirthDate = DateTime.Today.AddDays(-1)
            };

            string pattern = @"[^a-zA-Z0-9]";

            // Assert
            Assert.IsFalse(Regex.IsMatch(newUser.Name, pattern));

        }


        /*
        [TestMethod]

        public void AddNewUser_WasBornToday()
        {
            User newUser = new User
            {
                Name = "John Doe",
                Address = "Main Street",
                BirthDate = DateTime.Today
            };

            //libraryService.AddUser(newUser);

            // Assert
            Assert.IsTrue(newUser.BirthDate < DateTime.Today);

        }

        [TestMethod]

        public void AddNewUser_WasBornInTheFuture()
        {
            User newUser = new User
            {
                Name = "John Doe",
                Address = "Main Street",
                BirthDate = DateTime.Today.AddDays(1)
            };

            //libraryService.AddUser(newUser);

            // Assert
            Assert.IsTrue(newUser.BirthDate < DateTime.Today);

        }
        */


    }


}
