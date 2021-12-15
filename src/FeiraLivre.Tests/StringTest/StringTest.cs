using System;
using System.IO;
using NUnit.Framework;
using FeiraLivre.Api.Services;
using FeiraLivre.Api.Domain;
using NSubstitute;

namespace Tests
{
    public class StringTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string workingDirectory = Environment.CurrentDirectory;

            // This will get the current PROJECT directory
            string projectDirectory2 = Directory.GetParent(workingDirectory)
                .Parent
                .Parent
                .Parent
                .Parent
                .FullName;
            string path = Path.Combine(projectDirectory2, "sql", "InitalData", "DEINFO_AB_FEIRASLIVRES_2014.csv");

            ReadFeiraCsv readFeiraCsv = new(path);
            var feiras = readFeiraCsv.LoadData();
        }
    }
}