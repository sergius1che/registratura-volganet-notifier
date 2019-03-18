using Microsoft.Extensions.Configuration;
using RegVlg.DataAccess.Firebase;
using RegVlg.DataAccess.Test.Common;
using System;
using Xunit;

namespace RegVlg.DataAccess.Test
{
    public class FirebaseRepositoryTest
    {
        private readonly IConfigurationRoot _config;
        public FirebaseRepositoryTest()
        {
            // set enviroment to api key
            var path = System.IO.Path.GetFullPath(@"Configs\firebase-apikey.json");
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);

            _config = Factory.GetConfiguration();
        }

        [Fact]
        public void TryConnect()
        {
            var db = new FirebaseRepository(_config["projectId"]);

            Assert.NotNull(db);
        }
    }
}
