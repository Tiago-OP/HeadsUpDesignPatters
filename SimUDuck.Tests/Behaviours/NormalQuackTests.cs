﻿using Moq;
using NUnit.Framework;
using SimUDuck.Behaviors;
using SimUDuck.Wrappers;

namespace SimUDuck.Tests.Behaviours
{
    public class NormalQuackTests
    {
        [Test]
        public void NormalQuack()
        {
            var consoleMock = new Mock<IOutput>();
            var normalQuack = new NormalQuack(consoleMock.Object);

            normalQuack.Quack();

            consoleMock.Verify(w => w.Write(It.Is<string>(s => s == "Quack!")));
        }
    }
}