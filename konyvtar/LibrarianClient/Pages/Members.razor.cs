namespace LibrarianClient.Pages
{
    public partial class Members
    {
        private bool showAddUserForm;
        private User newUser = new User();

        private void OpenAddUserForm()
        {
            showAddUserForm = true;
        }

        private async Task AddUser()
        {
            try
            {
                await LibraryService.AddUser(newUser);
                showAddUserForm = false;
                newUser = new User();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to add user: {ex.Message}");
            }
        }

        private async Task CancelAdd()
        {
            newUser = new User();
            showAddUserForm = false;
        }

        protected override async Task OnInitializedAsync()
        {
            try
            {
                await LibraryService.GetUsers();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to retrieve users: {ex.Message}");
            }
        }
    }
}
