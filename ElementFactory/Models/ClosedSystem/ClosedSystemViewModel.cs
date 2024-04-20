namespace ElementFactory.Models.ClosedSystem
{
    using ElementFactory.Data.Models;
    using ElementFactory.Models.Test;

    public class ClosedSystemViewModel
    {
        public IEnumerable<User> Users { get; set; }

        public IEnumerable<TestViewModel> Tests { get; set; }

        public IEnumerable<string> UsersIds { get; set; }

        public string TestId { get; set; }
    }
}
