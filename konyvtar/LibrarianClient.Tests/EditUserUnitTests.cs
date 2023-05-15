

using LibraryApplication.Contracts;
using System.Text.RegularExpressions;

namespace LibrarianClient.Tests
{
    [TestClass]
    internal class EditUserUnitTests
    {

        [TestMethod]
        public void SaveUser_WasBornBeforeToday()
        {
            User newUser = new User
            {
                Name = "John Doe",
                Address = "Main St",
                BirthDate = DateTime.Today.AddDays(-1)
            };

            //libraryService.AddUser(newUser);

            // Assert
            Assert.IsTrue(newUser.BirthDate < DateTime.Today);

        }


        [TestMethod]

        public void SavewUser_AddressAtleastTWoCharactersLong()
        {
            User newUser = new User
            {
                Name = "John Doe",
                Address = "Main Street",
                BirthDate = DateTime.Today.AddDays(-1)
            };

            //libraryService.AddUser(newUser);

            // Assert
            Assert.IsTrue(newUser.Address.Length >= 2);

        }


        [TestMethod]

        public void SaveUser_IsEmpty()
        {
            User newUser = new User
            {
                Name = "john",
                Address = "Main Street",
                BirthDate = DateTime.Today.AddDays(-1)
            };

            SaveUser(newUser);


            // Assert
            Assert.IsFalse(string.IsNullOrEmpty(newUser.Name));

        }

        private void SaveUser(User newUser)
        {

        }

        [TestMethod]

        public void SaveUser_StartWithWhitePlace()
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

        public void SaveUser_EndsWithWhitePlace()
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

        public void SaveUser_IsNullOrWhiteSpace()
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

        public void SaveUser_HasSpecialCharacters()
        {
            User newUser = new User
            {
                Name = "john!",
                Address = "Main Street",
                BirthDate = DateTime.Today.AddDays(-1)
            };

            string pattern = @"[^a-zA-Z0-9]";

            // Assert
            Assert.IsFalse(Regex.IsMatch(newUser.Name, pattern));

        }

    }
}
