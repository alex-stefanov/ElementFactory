namespace ElementFactory.Tests.UnitTests.Mocks
{
    using ElementFactory.Data;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Static class used for getting a mock with the Database
    /// </summary>
    public static class DatabaseMock
    {
        public static ApplicationDbContext Mock
        {
            get
            {
                var dbContextOptions = new
                    DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase("ElementFactoryDb" + DateTime.Now.Ticks)
                    .Options;

                return new ApplicationDbContext(dbContextOptions);
            }
        }
    }
}
