﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Craft.Net.World.Test
{
    [TestFixture]
    public class LevelTest
    {
        [Test]
        public void TestSaveAndLoad()
        {
            var level = new Level();
            level.LevelName = "Example";
            level.Save("test.dat");
            var loaded = Level.LoadFrom("test.dat");
            Assert.AreEqual(level.LevelName, loaded.LevelName);
        }
    }
}
