namespace ElementFactory.Tests
{
    using ElementFactory.Data;
    using ElementFactory.Tests.UnitTests.Mocks;
    using NUnit.Framework;

    public class UnitTestBase
    {
        /// <summary>
        /// ApplicationDbContext
        /// </summary>
        protected ApplicationDbContext context;

        /// <summary>
        /// Default constructor
        /// </summary>
        public UnitTestBase()
        {
            this.context = DatabaseMock.Mock;
        }

        /// <summary>
        /// Tear down method for db
        /// </summary>
        [TearDown]
        public void TearDownDb()
        {
            this.context.Dispose();
        }
    }
}
